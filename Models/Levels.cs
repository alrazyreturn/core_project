using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Levels
    {
        public Levels()
        {
            Students = new HashSet<Students>();
            Subjects = new HashSet<Subjects>();
            TimeTable = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string LevelCode { get; set; }
        public string LevelArabic { get; set; }
        public string LevelEnglish { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Students> Students { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
        public ICollection<TimeTable> TimeTable { get; set; }
    }
}
