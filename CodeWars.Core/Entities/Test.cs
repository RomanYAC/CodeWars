using System.Collections;
using System.Collections.Generic;

namespace CodeWars.Core.Entities
{
    public class Test : IEntity<int>
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int SuccessCoefficient { get; set; }
        public CodingTask CodingTask { get; set; }
        public TestType TestType { get; set; }
        public ICollection<TestValue> TestValues { get; set; }
    }
}
