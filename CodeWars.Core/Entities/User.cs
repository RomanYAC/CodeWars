namespace CodeWars.Core.Entities
{
    public class User: IEntity<int>
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string GroupName { get; set; }
        public string HashedPassword { get; set; }
        public Role Role { get; set; }
    }
}
