namespace SignalR_API.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public Room Room { get; set; }
        public int RoomID { get; set; }
    }
}
