using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpConfig;
using System.Reflection;
using System.Drawing.Imaging;
using System.IO;
using NAudio.Wave;

namespace Attorney_Online_Character_Editor
{
    public partial class Form1 : Form
    {
        private AOCharacter character;
        WaveOutEvent woPlayer;
        WaveFileReader wavReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (iniFileDialog.ShowDialog() != DialogResult.OK)
                this.Close();
            else
            {
                character = new AOCharacter(iniFileDialog.FileName);

                readInOptions();

                Console.WriteLine(character.IniFolder);
                Console.WriteLine(character.Name);
                Console.WriteLine(character.ButtonsFolder);

                foreach (Setting setting in character.IniConfig["Time"])
                {
                    Console.WriteLine(setting.Name);
                }
                string s = "123##789#a#";
                char[] d = { '#' };
                string[] words = s.Split(d);
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                woPlayer = new WaveOutEvent();

                wavReader = new WaveFileReader(Directory.GetParent(Directory.GetParent(character.IniFolder).ToString()).ToString()
                    + "\\sounds\\general\\" + "sfx-blipmale" + ".wav");
                woPlayer.Init(wavReader);
            }

        }

        private void readInOptions()
        {
            nameTextBox.Text = character.Name;
            clientNameTextBox.Text = character.ClientName;
            blipSelectList.SelectedItem = character.BlipSFX;
            positionSelectList.SelectedItem = character.Position;

            foreach (Setting setting in character.IniConfig["Time"])
            {
                preanimationsListBox.Items.Add(setting.Name);
            }

            for (int emotionsIndex = 1; emotionsIndex <= character.EmotionsCount; emotionsIndex++)
            {
                emotionsListBox.Items.Add(emotionsIndex.ToString());
            }
            if (character.IniConfig["Emotions"].Contains("firstmode"))
            {
                emotionsListBox.SelectedIndex = character.IniConfig["Emotions"]["firstmode"].IntValue - 1;
            }
            else emotionsListBox.SelectedIndex = 0;
        }

        private void emotionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            emotionTimer.Enabled = false;
            blipTimer.Enabled = false;
            preanimationTimer.Enabled = false;

            emotionsButtonOn.Image = Image.FromFile(character.ButtonsFolder + "\\button" + emotionsListBox.SelectedItem.ToString() + "_on.png");
            emotionsButtonOff.Image = Image.FromFile(character.ButtonsFolder + "\\button" + emotionsListBox.SelectedItem.ToString() + "_off.png");

            emotionSettingTextBox.Text = character.IniConfig["Emotions"][emotionsListBox.SelectedItem.ToString()].StringValue;
            sfxTextBox.Text = character.IniConfig["SoundN"][emotionsListBox.SelectedItem.ToString()].StringValue;
            sfxTimeValueBox.Value = character.IniConfig["SoundT"][emotionsListBox.SelectedItem.ToString()].IntValue;

            if (sfxTimeValueBox.Value > 0)
            {
                sfxTimer.Interval = (int)sfxTimeValueBox.Value * 60;
                sfxTimer.Enabled = true;
            }
            else { playSFX(sfxTextBox.Text); }


            char[] delimiter = { '#' };
            string[] parsedEmotionSetting = emotionSettingTextBox.Text.Split(delimiter);
            // 0 = comment
            // 1 = idle
            // 2 = talking
            // 3 = setting
            //     0 - No preanimation
            //     1 - Play preanimation
            //     5 - ZOOM!
            if (parsedEmotionSetting.Length >= 4)
                switch (Int32.Parse(parsedEmotionSetting[3]))
                {
                    case 0:
                        showAnimation("(a)" + parsedEmotionSetting[1]);
                        break;
                    case 1:
                        //string imagePath = character.IniFolder + "\\" + parsedEmotionSetting[1] + ".gif";
                        //Image image = Image.FromFile(imagePath);
                        showAnimation(parsedEmotionSetting[1]);
                        if (character.IniConfig["Time"].Contains(parsedEmotionSetting[1]))
                        {
                            emotionTimer.Interval = character.IniConfig["Time"][parsedEmotionSetting[1]].IntValue * 60;
                            emotionTimer.Enabled = true;
                        }
                        else
                        {
                            showAnimation("(b)" + parsedEmotionSetting[2]);
                        }
                        break;
                    default:
                        showAnimation("(b)" + parsedEmotionSetting[2]);
                        break;
                }
        }

        private void emotionTimer_Tick(object sender, EventArgs e)
        {
            emotionTimer.Enabled = false;
            blipTimer.Enabled = false;
            sfxTimer.Enabled = false;

            char[] delimiter = { '#' };
            string[] parsedEmotionSetting = emotionSettingTextBox.Text.Split(delimiter);
            showAnimation("(b)" + parsedEmotionSetting[2]);
        }

        private void showAnimation(string name)
        {
            string imagePath = character.IniFolder + "\\" + name + ".gif";
            if (File.Exists(imagePath))
                spriteBox.Image = Image.FromFile(imagePath);
            else if (name.Length >= 3)
            {
                string maybePath = character.IniFolder + "\\" + name.Substring(3) + ".gif";
                if (File.Exists(maybePath))
                    spriteBox.Image = Image.FromFile(maybePath);
            }
        }


        private void preanimationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            emotionTimer.Enabled = false;
            blipTimer.Enabled = false;
            preanimationTimer.Enabled = false;

            preanimationTimeValueBox.ReadOnly = false;

            showAnimation(preanimationsListBox.SelectedItem.ToString());
            preanimationTimeValueBox.Value = character.IniConfig["Time"][preanimationsListBox.SelectedItem.ToString()].IntValue;

            preanimationTimer.Interval = (int)preanimationTimeValueBox.Value * 60;
            preanimationTimer.Enabled = true;

            Console.WriteLine(animationTime(spriteBox.Image));
        }

        private void preanimationTimer_Tick(object sender, EventArgs e)
        {
            preanimationTimer.Enabled = false;
            spriteBox.Image = null;
        }

        private void preanimationTimeValueBox_ValueChanged(object sender, EventArgs e)
        {
            character.IniConfig["Time"][preanimationsListBox.SelectedItem.ToString()].SetValue(preanimationTimeValueBox.Value);
        }

        Image[] getFrames(Image originalImg)
        {
            int numberOfFrames = originalImg.GetFrameCount(FrameDimension.Time);
            Image[] frames = new Image[numberOfFrames];

            for (int i = 0; i < numberOfFrames; i++)
            {
                originalImg.SelectActiveFrame(FrameDimension.Time, i);
                frames[i] = ((Image)originalImg.Clone());
            }

            return frames;
        }

        private int animationTime(Image gif)
        {
            PropertyItem item = gif.GetPropertyItem(0x5100);
            byte[] bytes = item.Value;

            int frames = gif.GetFrameCount(FrameDimension.Time);

            int delay = 0;
            for (int frame = 0; frame != frames; frame++)
            {
                delay += BitConverter.ToInt32(bytes, frame * 4) * 10;
            }
            return delay;
        }

        private void playSFX(string name)
        {
            string sfxPath = Directory.GetParent(Directory.GetParent(character.IniFolder).ToString()).ToString()
                + "\\sounds\\general\\" + name + ".wav";

            SoundPlayer player = new SoundPlayer(sfxPath);

            if (File.Exists(sfxPath))
            {
                player.Play();
            }
        }

        private void playInterjection(string name)
        {
            SoundPlayer simpleSound = new SoundPlayer(character.IniFolder
                + "\\" + name + ".wav");
            simpleSound.Play();
        }

        private void holdItButton_Click(object sender, EventArgs e)
        {
            playInterjection("holdit");
        }

        private void holdItButton_MouseEnter(object sender, EventArgs e)
        {
            holdItButton.Image = Properties.Resources.holdItButtonOn;
        }

        private void holdItButton_MouseLeave(object sender, EventArgs e)
        {
            holdItButton.Image = Properties.Resources.holdItButtonOff;
        }

        private void objectionButton_Click(object sender, EventArgs e)
        {
            playInterjection("objection");
        }

        private void objectionButton_MouseEnter(object sender, EventArgs e)
        {
            objectionButton.Image = Properties.Resources.objectionButtonOn;
        }

        private void objectionButton_MouseLeave(object sender, EventArgs e)
        {
            objectionButton.Image = Properties.Resources.objectionButtonOff;
        }

        private void takeThatButton_Click(object sender, EventArgs e)
        {
            playInterjection("takethat");
        }

        private void takeThatButton_MouseEnter(object sender, EventArgs e)
        {
            takeThatButton.Image = Properties.Resources.takeThatButtonOn;
        }

        private void takeThatButton_MouseLeave(object sender, EventArgs e)
        {
            takeThatButton.Image = Properties.Resources.takeThatButtonOff;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            character.save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                character.saveAs(saveFileDialog1.FileName);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            character.Name = nameTextBox.Text;
        }

        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            character.ClientName = clientNameTextBox.Text;
        }

        private void blipSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.BlipSFX = blipSelectList.SelectedItem.ToString();
        }

        private void positionSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.Position = positionSelectList.SelectedItem.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void emotionSettingTextBox_TextChanged(object sender, EventArgs e)
        {
            character.IniConfig["Emotions"][emotionsListBox.SelectedItem.ToString()].SetValue(emotionSettingTextBox.Text);
        }

        private void sfxTextBox_TextChanged(object sender, EventArgs e)
        {
            character.IniConfig["SoundN"][emotionsListBox.SelectedItem.ToString()].SetValue(sfxTextBox.Text);
        }

        private void sfxTimeValueBox_ValueChanged(object sender, EventArgs e)
        {
            character.IniConfig["SoundT"][emotionsListBox.SelectedItem.ToString()].SetValue((int)sfxTimeValueBox.Value);

        }

        private void sfxTimer_Tick(object sender, EventArgs e)
        {
            playSFX(sfxTextBox.Text);
            sfxTimer.Enabled = false;
        }

        private void emotionsButtonOn_Click(object sender, EventArgs e)
        {
            char[] delimiter = { '#' };
            string[] parsedEmotionSetting = emotionSettingTextBox.Text.Split(delimiter);
            showAnimation("(b)" + parsedEmotionSetting[2]);

            blipTimer.Enabled = true;
        }

        private void emotionsButtonOff_Click(object sender, EventArgs e)
        {
            char[] delimiter = { '#' };
            string[] parsedEmotionSetting = emotionSettingTextBox.Text.Split(delimiter);
            showAnimation("(a)" + parsedEmotionSetting[1]);
            blipTimer.Enabled = false;
        }

        private void blipTimer_Tick(object sender, EventArgs e)
        {
            playSFX("sfx-blip" + character.BlipSFX);
        }
    }
}
