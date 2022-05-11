using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
       
    public class Animal
    {
        public string Kind
        {
            get;
        }
     public string Country
        {
            get;
        }
        
        public Animal(string kind, string country)
        {
            Kind = kind;
            Country = country;
        }
        public override bool Equals(object obj)
        {
            if (obj is Animal animal) return Kind == animal.Kind && animal.Country == Country;
            else return false;
        }
        public override string ToString()
        {
            return $"Тварина {Kind} {Country}";
        }
        public override int GetHashCode()
        {
            return (Kind, Country).GetHashCode();
        }

    }
     
    public class Dog : Animal
    {
        public string Breed
        {
            get;
        }
        public Dog(string kind, string country, string breed) : base(kind, country)
        {
            Breed = breed;
        }
        public override bool Equals(object obj)
        {
            if (obj is  Dog dog) 
            
              return Breed == dog.Breed;
            return false;
        }
        public override string ToString()
        {
            return $"Собака {Breed}";
        }
        public override int GetHashCode()
        {
            return Breed.GetHashCode();
        }

    }

    public class Puppy : Dog
    {
        public int Age
        {
            get;
        }
        public string Name
        {
            get;
        }
        public Puppy(string name, int age, string kind, string country, string breed) : base ( kind,  country,  breed)
        {
            Name = name;
            Age = age;
        }
        public void Say()
        {
            Console.WriteLine("Gav");
        }
        public void Run()
        {
            Console.WriteLine("Puppy running");
        }
        public  void Bites()
        {
            Console.WriteLine("Puppy bites");
        }
        public void jumps()
        {
            Console.WriteLine("Puppy jumps");
        } 

        public override bool Equals(object obj)
        {
            if (obj is Puppy puppy) 

            return Name == puppy.Name  && puppy.Age == Age;
            return false;
        }
        public override string ToString()
        {
            return $"Puppy {Name}\n {Age}\n {Kind}\n {Country}\n {Breed}\n";
        }
        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Puppy(" Name: Tom", 5, "Kind : Home", "Country: Switzerland", "Breed: Bernese Mountain Dog");
            Console.WriteLine(puppy);
          


            puppy.Run();
            puppy.jumps();
            puppy.Say();
            puppy.Bites();


        }
    }
}
