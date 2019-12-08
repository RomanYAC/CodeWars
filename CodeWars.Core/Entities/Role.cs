namespace CodeWars.Core.Entities
{
    public class Role : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
