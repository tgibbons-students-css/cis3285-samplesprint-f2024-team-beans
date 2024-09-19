namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
        }
        //  Changes Sprint 1 -- I want to create a room record for storing data to specefic rooms -- Alec Lindberg  

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
