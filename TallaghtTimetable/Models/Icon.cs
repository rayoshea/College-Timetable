using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallaghtTimetable.Models
{
    public class Icon
    {
        // public Rooms Room { get; set; }  // Can get a Room
        //[Key]
        //[ForeignKey("IconID")] Foreign Key Attribute

        public int ID { get; set; }


        public int LecturersID { get; set; }

        public string LecturerName { get; set; }

        // public int StudysID { get; set; }

        // public virtual Study Studys { get; set; }

        public virtual List<Lecturer> Lecturers { get; set; } // In web api have a get so that user can choose by lecturer

        public DayOfWeek Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; } // Admin creates Timetable database



        //public LibraryStudy LibraryStudies { get; set; }

        //public Room229 Room229s { get; set; }

        public bool Availability
        {
            get;
            set;
        }

        public bool Bookroom { get; set; }

    }
}