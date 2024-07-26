using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Domain
{
    public class PersonalTrainingMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;
        public PersonalTrainingMembership(decimal price)
        {
            _name = "PersonalTrainingMembership";
            _price = price;
        }
        public string Name => _name;
        public decimal GetPrice() => _price;
        public string Description { get; set; }
    }
}
