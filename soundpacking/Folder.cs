using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundpacking
{
    class Folder
    {
        // this class represents the folders that will contain the Audio Files & Folder path as data memeber "Out Put"
        private static List<AudioFile> Audios = new List<AudioFile>();
        public static int MaxCap; 
        public int RemainCap;
        //Folder()
        //{
            //Audios = new List<AudioFile>();
           // RemainCap = MaxCap;

       // }
        public static void setmax(int max)
        {
            MaxCap = max;
        }

        public static void  AddFile(AudioFile File)
        {
            //RemainCap -= File.GetDuation();
            
            Audios.Add(File);
            

        }
        /*public bool IfAccept(ref AudioFile File)
        {
            //return (File.GetDuation() <= RemainCap);
        }*/
    }
}
