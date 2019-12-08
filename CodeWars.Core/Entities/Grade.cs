namespace CodeWars.Core.Entities
{
    public class Grade : IEntity<int>
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Answer { get; set; }
        public uint Result { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public CodingTask CodingTask { get; set; }
    }
}
