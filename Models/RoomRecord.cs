namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // User Story 2D: Add userLimit attribute to control the maximum number of users per room (Alec Lindberg)
        public RoomRecord(string name, int roomId)
        {
            // Changes Sprint 1 -- "As a message posting user, I want to create rooms for categorizing conversations." -- Bethany Helwig
            Name = name;
            RoomId1 = roomId;
        }
         

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
