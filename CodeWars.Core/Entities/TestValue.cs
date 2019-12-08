namespace CodeWars.Core.Entities
{
    public class TestValue: IEntity<int>
    {
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public string Value { get; set; }
        public int TestId { get; set; }
        public Parameter Parameter { get; set; }
        public Test Test { get; set; }
    }
}
