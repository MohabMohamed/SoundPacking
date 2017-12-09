using System.Collections.Generic;

namespace soundpacking
{
    class Pack
    {
        public static void  WorstFit(ref List <AudioFile> files)
        {
            LinkedList<Folder> folders = new LinkedList<Folder>();
            for (int i = 0; i < files.Count; i++)
            {
                for (LinkedListNode<Folder> it = folders.First; it != null; it = it.Next)
                {
                    if (it.Value.RemainCap >= files[i].GetDuation())
                    {
                        it.Value.AddFile(files[i]);
                        break;

                    }


                }
                Folder f = new Folder();
                f.AddFile(files[i]);
                folders.AddLast(f);

            }



        }

    }
}
