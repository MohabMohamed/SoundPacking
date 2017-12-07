using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundpacking
{
    class SystemHandler
    {
        public static void ReadInPut(string FolderPath) {

            string[] Lines = System.IO.File.ReadAllLines(FolderPath + @"\AudiosInfo.txt");
            int NumberOfFiles = Int32.Parse(Lines[0]);

            for (int Counter = 1; Counter <= NumberOfFiles; Counter++)
            {
                string[] FileInfo = Lines[Counter].Split(' ');
                AudioFile AudioFile = new AudioFile();
                AudioFile.SetFileName(FileInfo[0]);
                AudioFile.SetDuration(FileInfo[1]);
                Folder.AddFile(AudioFile);
            }


        }
    }
}
