using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundpacking
{
    class Folder
    {
        public static TimeSpan MaxDur;
        public TimeSpan RemainCap;
        public  List<AudioFile> Audios ;
        public Folder()
        {
            RemainCap = MaxDur;
            Audios = new List<AudioFile>();
        }

        public static void SetMaxDur(TimeSpan MaxDuration)
        {
            MaxDur = MaxDuration;
        }
        public void AddFile(AudioFile File)
        {
            Audios.Add(File);
            RemainCap-= File.GetDuation();

        }

    }
}
