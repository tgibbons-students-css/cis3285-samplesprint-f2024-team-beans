namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // User Story 2A: Adds markdown text formatting to messages (Max Lasitsa)
        public MessageRecord(int roomID, string authorName, string text)
        {
            // Changes Sprint 2 -- "As a message poster, I want to send markdown text that will be correctly formatted." -- Bethany Helwig
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        // User Story 2C: Ensure RoomID supports high concurrent user access (Max Lasitsa)
        public int RoomID
        {
            get;
            private set;
        }

        // User Story 2A: This represents the text content that supports markdown formatting (Max Lasitsa)
        public string Text
        {
            // Changes Sprint 2 -- "As a message poster, I want to send markdown text that will be correctly formatted." -- Bethany Helwig
            get;
            private set;
        }

        // User Story 2C: Ensure room name management is efficient for many concurrent users (Max Lasitsa)
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
