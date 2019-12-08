using System.Collections.Generic;

namespace CodeWars.Core.Entities
{
    public class CodingTask : IEntity<int>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string AnswerExample { get; set; }
        public ICollection<Test> Tests{ get; set; }
        public ICollection<Parameter> Parameters { get; set; }
    }
}
