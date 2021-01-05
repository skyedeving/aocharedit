using SharpConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attorney_Online_Character_Editor
{
    class AOCharacter
    {
        private Configuration iniConfig;
        private string iniFileName;
        private string iniFolder;

        public AOCharacter(string fileName)
        {
            Configuration.IgnoreInlineComments = true;
            Configuration.ValidCommentChars =  new char[] { '#', ';', '\'', '\\' };
            foreach (char d in Configuration.ValidCommentChars)
            {
                Console.WriteLine(d);
            }
            load(fileName);
        }

        public void load(string fileName)
        {
            iniFileName = fileName;
            iniConfig = Configuration.LoadFromFile(iniFileName);
            iniFolder = Path.GetDirectoryName(iniFileName);
        }

        public void saveAs(string fileName)
        {
            iniConfig.SaveToFile(fileName);
            load(fileName);
        }

        public void save ()
        {
            saveAs(iniFileName);
        }

        public string Name
        {
            get { return IniConfig["Options"]["Name"].StringValue; }
            set { IniConfig["Options"]["Name"].SetValue(value); }
        }

        public string ClientName
        {
            get { return IniConfig["Options"]["showname"].StringValue; }
            set { IniConfig["Options"]["showname"].SetValue(value); }
        }

        public string BlipSFX
        {
            get { return IniConfig["Options"]["gender"].StringValue; }
            set { IniConfig["Options"]["gender"].SetValue(value); }
        }

        public string Position
        {
            get { return IniConfig["Options"]["side"].StringValue; }
            set { IniConfig["Options"]["side"].SetValue(value); }
        }

        public int EmotionsCount
        {
            get { return IniConfig["Emotions"]["number"].IntValue; }
            set { IniConfig["Emotions"]["number"].SetValue(value); }
        }

        public string IniFolder { get { return iniFolder; } }

        public Configuration IniConfig { get { return iniConfig; } }

        public string IniFileName { get { return iniFileName; } }

        public string ButtonsFolder
        {
            get { return Directory.GetDirectories(iniFolder, "emotions")[0]; }
        }
    }
}
