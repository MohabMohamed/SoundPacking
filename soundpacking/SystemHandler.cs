using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundpacking
{
    class SystemHandler
    {
        private static string folderPath;
        private static TimeSpan maxcap;

        public static void setMaxCap(TimeSpan max)
        {
            maxcap = max;
        }
        public static void setFolderPath(string name)
        {
            folderPath = name;
        }

        public static List<AudioFile> getAudioFiles()
        {
            string[] Lines = System.IO.File.ReadAllLines(folderPath + @"\AudiosInfo.txt");
            int NumberOfFiles = Int32.Parse(Lines[0]);
            List<AudioFile> inputlist = new List<AudioFile>();

            for (int i = 1; i <= NumberOfFiles; i++)
            {
                string[] FileInfo = Lines[i].Split(' ');
                
                AudioFile audiofile = new AudioFile();
                audiofile.SetFileName(FileInfo[0]);
                audiofile.SetDuration(TimeSpan.Parse(FileInfo[1]));
                inputlist.Add(audiofile);  
                
            }
            return inputlist;
        }
        //where we'll call all the methods
        public static void start()
        {
            List<AudioFile> audiolist = getAudioFiles();
            Folder.SetMaxDur(maxcap);
            List<AudioFile> Audios = getAudioFiles();
            Pack.WorstFit(ref Audios);

        }
       

    }
}
