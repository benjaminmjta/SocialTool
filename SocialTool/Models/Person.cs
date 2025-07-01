using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Income { get; set; }
        public int Balance { get; set; }
        public Guid? Spouse { get; set; }
        public List<Guid> Children { get; set; }

        public Person()
        {

        }
    }
}
