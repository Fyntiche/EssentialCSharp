using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{

    

    class Program
    {

        public enum Post
        {
            Rang1 = 10,
            Rang2 = 20,
            Rang3 = 30,
            Rang4 = 40
            }

        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            Console.WriteLine(accauntant.AskForBonus(Post.Rang4, 39));
            Console.ReadKey();
        }
    }
}
