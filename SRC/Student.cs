using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRC
{
   public class Student
    {
        private string familija;
        private string name;
        private string gruppa;
        public string Familija
        {
            get { return this.familija; }
            set { this.familija = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Gruppa
        {
            get { return this.gruppa; }
            set { this.gruppa = value; }
        }
    }
}
