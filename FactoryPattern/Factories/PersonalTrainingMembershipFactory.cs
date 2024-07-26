using FactoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    internal class PersonalTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;
        public PersonalTrainingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            PersonalTrainingMembership PersonalTrainingMembership = new PersonalTrainingMembership(_price)
            {
                Description = _description,
            };
            return PersonalTrainingMembership;
        }
    }
}
