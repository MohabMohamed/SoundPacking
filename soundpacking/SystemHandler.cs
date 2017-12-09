using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        //where we'll call all the methods
        public static void start()
        {
            List<AudioFile> audiolist = getAudioFiles();
            Methods.worstFitDecreasingLS(audiolist, (int)maxcap.TotalSeconds);

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

        public void createFolders(List<Folder> myFolders)
        {
            List<string> path = SystemHandler.folderPath.Split('/').ToList<string>();
            path.RemoveAt(path.Count - 1);
            path.Add("OUTPUT");
            path.Add("WorstFitDecreasingLS");
            string outputpath = string.Join("/",path);
            DirectoryInfo di = Directory.CreateDirectory(outputpath);

            for (int i = 0; i < myFolders.Count; i++)
            {
                string foldername = "F" + i;
                foldername = Path.Combine(outputpath, foldername);
                DirectoryInfo f = Directory.CreateDirectory(foldername);

                for (int j = 0; j < myFolders[i].files.Count; j++)
                {

                }
            }

        }
        
       

    }
}
