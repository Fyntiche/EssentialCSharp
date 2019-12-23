using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1.Pupil
{
    class BadPupil : Pupil
    {
        protected override void Study(string value)
        {
            base.Study(value);
        }

        protected override void Read(string value)
        {
            base.Read(value);
        }

        protected override void Write(string value)
        {
            base.Write(value);
        }

        protected override void Relax(string value)
        {
            base.Relax(value);
        }

        public BadPupil(string studValue, string readValue, string writeValue, string relaxValue)
            : base(studValue, readValue, writeValue, relaxValue)
        {

        }
    }
}
