using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._1.Pupil;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil badPupil = new BadPupil("плохо", "плохо", "средне", "отлично");
            GoodPupil goodPupil = new GoodPupil("отлично", "отлично", "хорошо", "хорошо");
            ExcelentPupil excelentPupil = new ExcelentPupil("средне", "средне", "плохо", "средне");
            ClassRoom classRoom = new ClassRoom(badPupil, goodPupil, excelentPupil);
            classRoom.Show();
            Console.ReadKey();
        }
    }
}
