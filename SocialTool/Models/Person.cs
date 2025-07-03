using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public Double Income { get; set; }

        public Person(Double income)
        {
            this.Id = Guid.NewGuid();
            this.Income = income;
        }
    }
}
