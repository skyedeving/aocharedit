using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace Attorney_Online_Character_Editor
{
    partial class AboutBox : Form
    {
        IWavePlayer waveOutDevice;
        MemoryStream mp3File;
        Mp3FileReader mp3Reader;
        LoopStream loop;

        public AboutBox()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();
            mp3File = new MemoryStream(Properties.Resources.about);
            mp3Reader = new Mp3FileReader(mp3File);
            loop = new LoopStream(mp3Reader);

            waveOutDevice.Init(loop);
            waveOutDevice.Play();
        }

        private void AboutBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            waveOutDevice.Stop();
            waveOutDevice.Dispose();
        }
    }

    /// <summary>
    /// Stream for looping playback
    /// Credits: http://mark-dot-net.blogspot.com/2009/10/looped-playback-in-net-with-naudio.html
    /// </summary>
    public class LoopStream : WaveStream
    {
        WaveStream sourceStream;

        /// <summary>
        /// Creates a new Loop stream
        /// </summary>
        /// <param name="sourceStream">The stream to read from. Note: the Read method of this stream should return 0 when it reaches the end
        /// or else we will not loop to the start again.</param>
        public LoopStream(WaveStream sourceStream)
        {
            this.sourceStream = sourceStream;
            this.EnableLooping = true;
        }

        /// <summary>
        /// Use this to turn looping on or off
        /// </summary>
        public bool EnableLooping { get; set; }

        /// <summary>
        /// Return source stream's wave format
        /// </summary>
        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }

        /// <summary>
        /// LoopStream simply returns
        /// </summary>
        public override long Length
        {
            get { return sourceStream.Length; }
        }

        /// <summary>
        /// LoopStream simply passes on positioning to source stream
        /// </summary>
        public override long Position
        {
            get { return sourceStream.Position; }
            set { sourceStream.Position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;

            while (totalBytesRead < count)
            {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                if (bytesRead == 0)
                {
                    if (sourceStream.Position == 0 || !EnableLooping)
                    {
                        // something wrong with the source stream
                        break;
                    }
                    // loop
                    sourceStream.Position = 0;
                }
                totalBytesRead += bytesRead;
            }
            return totalBytesRead;
        }
    }
}
