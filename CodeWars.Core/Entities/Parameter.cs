using System.Collections;
using System.Collections.Generic;

namespace CodeWars.Core.Entities
{
    public class Parameter : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsResult { get; set; }
        public int TaskId { get; set; }
        public CodingTask CodingTask { get; set; }
        public ICollection<TestValue> TestValues { get; set; }
    }
}
