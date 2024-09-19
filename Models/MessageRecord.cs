namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // User Story 2A: Adds markdown text formatting to messages (Max Lasitsa)
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        // User Story 2A: This represents the text content that supports markdown formatting (Max Lasitsa)
        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
