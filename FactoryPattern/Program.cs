using System;
using FactoryPattern.Domain;
using FactoryPattern.Factories;
namespace FactoryPattern
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to FitnessClub ");

            Console.WriteLine("Please Enter the MemberShip type would you like to create: ");

            Console.WriteLine(" G - Gym ");
            Console.WriteLine(" P - Gym + Pool ");
            Console.WriteLine(" T - Personal Training");

            string MembershipType = Console.ReadLine();

            MembershipFactory membership = Program.GetFactory(MembershipType);
            IMembership membership1 = membership.GetMembership();

            Console.WriteLine("your MemberShip is created");

            Console.WriteLine(
                $"Name: {membership1.Name}\t" +
                $"price: {membership1.GetPrice()}\t\t" +
                $"Description: {membership1.Description}\t"
                );

            Console.ReadLine();
        }

        private static MembershipFactory GetFactory(string MembershipType)
        {
            switch (MembershipType.ToLower())
            {
                case "g":
                    return new GymMembershipFactory(100, "BasicMembership");
                case "p":
                    return new GymPlusPoolMembershipFactory(200, "Good price Membership");
                case "t":
                    return new PersonalTrainingMembershipFactory(300, "professional Training");
                default:
                    throw new Exception("invalid Membership");
            }
        }
    }
}
