using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class person
    {
        public string Name { get; set; }
        public string Feet { get; set; }
        public string Arms { get; set; }
        public string Toes { get; set; }
        public int Age { get; set; }
        public bool CanDrive { get; set; }
        public bool CanVote { get; set; }
        public int YearsTillDrive { get; set; }
        public int YearsTillVote { get; set; }

        public person()
        {
            this.Feet = "";
            this.Arms = "";
            this.Toes = "";
            this.Age = 0;
            this.Name = "";
            this.CanDrive = false;
            this.CanVote = false;
            this.YearsTillDrive = 0;
            this.YearsTillVote = 0;
        }

    }//class

}//ns
