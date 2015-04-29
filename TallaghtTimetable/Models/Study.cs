using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallaghtTimetable.Models
{
    public class Study
    {

        public int ID { get; set; }

        public int LecturersID { get; set; }

        public string LecturerName { get; set; }

        // public int IconsID { get; set; }

        public DayOfWeek Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; } // Admin creates Timetable database

        // public virtual Icon Icons { get; set; }

        public virtual List<Lecturer> Lecturers { get; set; } // In web api have a get so that user can choose by lecturer

        //public LibraryStudy LibraryStudies { get; set; }

        //public Room229 Room229s { get; set; }

        public bool Availability
        {
            get;
            set;
        }

        public bool Holiday { get; set; }

        public bool Bookroom { get; set; }


    }
}