using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallaghtTimetable.Models
{
    public enum Module { Programming, Web, Database, Architecture }
    public class Lecturer
    {

        public int ID { get; set; }

        public int IconsID { get; set; }

        public int StudysID { get; set; }
        public string Name { get; set; }

        public Module Modules { get; set; }

        public virtual List<Icon> Icons { get; set; }

        public virtual List<Study> Studys { get; set; }


    }
}