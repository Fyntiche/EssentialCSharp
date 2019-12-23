using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1.Pupil
{
    class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();
        
        public ClassRoom(Pupil pupil)
        {
            if ((pupils.Count) <= 4)
            {
                pupils.Add(pupil);
            }
            else
            {
                Console.WriteLine($"При добавлении студента класс будет переполнен");
            }
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
            : this(pupil1)
        {
            if ((pupils.Count) <= 4)
            {
                pupils.Add(pupil2);
            }
            else
            {
                Console.WriteLine($"При добавлении студента класс будет переполнен");
            }
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this(pupil1, pupil2)
        {
            if ((pupils.Count) <= 4)
            {
                pupils.Add(pupil3);
            }
            else
            {
                Console.WriteLine($"При добавлении студента класс будет переполнен");
            }
        }

        public void Show()
        {
            foreach (var pupil in pupils)
            {
                pupil.Show();
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
        }
    }
}
