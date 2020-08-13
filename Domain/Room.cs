using System.Collections.Generic;

namespace Domain
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int Number { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}