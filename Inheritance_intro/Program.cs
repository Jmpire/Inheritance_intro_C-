using System;
using System.Text;
using System.Linq;

namespace Inheritance_intro
{
    class Program
    {
        // Aggregation: has a relationship
        // Example one of aggregation, A person has an address
        class Person
        {
            public string name;
            public int age;
            public Address address;
            public Person(string nName, int nAge, Address address)
            {
                this.name = nName;
                this.age = nAge;
                this.address = address;
            }

            public void details()
            {
                Console.WriteLine($"Name: {name}, Age: {age}, Street: {address.street}, Town: {address.town}, Country: {address.country}");
            }
        }
        // Address exists on it's own
        class Address
        {
            public string street;
            public string town;
            public string country;

            public Address(string street, string nTown, string nCountry)
            {
                this.street = street;
                this.town = nTown;
                this.country = nCountry;
            }
        }

        // Example 2, a business has an asset(a pen)
        class Business
        {
            public string name;
            public Asset asset;
            public Business(string name, Asset asset)
            {
                this.name = name;
                this.asset = asset;
            }
            public void Details()
            {
                Console.WriteLine($"Business name: {name}, Asset: {asset.type}, Colour: {asset.colour}");
            }
        }
        // An asset exists on it's own
        class Asset
        {
            public string type;
            public string colour;
            public Asset(string type, string colour)
            {
                this.type = type;
                this.colour = colour;
            }
        }

        // A simple example of composition
        // A heart won't be able to exist if a human being is not born
        class Human
        {
            public string name;
            // We call the heart class inside the Person class instead of main method
            Heart heart = new Heart();
            public Human(string name)
            {
                this.name = name;
            }
            // Call the Beats method of the heart class
            public void Start_beating()
            {
                heart.Beats();
            }
        }
        class Heart
        {
            public void Beats()
            {
                Console.WriteLine("Heart is beating");
            }
        }
        static void Main(string[] args)
        {
            // Instance(objects) of Address and Person, Example 1
            Address address = new Address("Witvalk str", "Windhoek", "Namibia");
            Person p = new Person("Andrew Garfield", 20, address);
            p.details();

            // Example 2
            Asset asset = new Asset("Pen", "Black");
            Business business = new Business("ISTRH", asset);
            business.Details();

            // Composition
            Human h = new Human("Joseph Isaacks");
            h.Start_beating();
        }
    }
}
