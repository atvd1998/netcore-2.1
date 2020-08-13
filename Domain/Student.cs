using System;

namespace Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime BirthOfDate { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
