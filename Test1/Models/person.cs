using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class person
    {
        public string name { get; set; }
        public  string foot { get; set; }
        public string arm { get; set; }
        public string toes { get; set; }
        public int age { get; set; }
        public bool canDrive { get; set; }
        public bool canVote { get; set; }
        public int yearsTillDrive { get; set; }
        public int yearsTillVote { get; set; }

        public person()
        {
            this.foot = "";
            this.arm = "";
            this.toes = "";
            this.age = 0;
            this.name = "";
            this.canDrive = false;
            this.canVote = false;
            this.yearsTillDrive = 0;
            this.yearsTillVote = 0;
        }

    }//class

}//ns
