using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1.Pupil
{
    class Pupil
    {
        private string studValue;
        private string readValue;
        private string writeValue;
        private string relaxValue;


        protected virtual void Study(string value)
        {
            studValue = value;
        }

        protected virtual void Read(string value)
        {
            readValue = value;
        }

        protected virtual void Write(string value)
        {
            writeValue = value;
        }

        protected virtual void Relax(string value)
        {
            relaxValue = value;
        }

        public void Show()
        {
            Console.WriteLine($"Учится {studValue}, читает {readValue}, пишет {writeValue}, отдыхает {relaxValue}");
        }

        public Pupil(string studValue, string readValue, string writeValue, string relaxValue)
        {
            this.studValue = studValue;
            this.readValue = readValue;
            this.writeValue = writeValue;
            this.relaxValue = relaxValue;
    }

    }
}
