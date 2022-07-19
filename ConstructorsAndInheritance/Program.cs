using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243566#content
namespace ConstructorsAndInheritance
{
    // Constructor Inheritance
    // * Base class constructors are always executed first
    // * Base class constructors are not inherited - it is required to redefine
    // constructors 

    public class Vehicle
    {
        private string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
    public class Car : Vehicle
    {
        //Constructor of Car class receives an argument called registrationNumber
        //and then it is passed to the base class constructor:
        public Car(string registrationNumber) : base(registrationNumber)
        {
            
        }
        
        //This is not a good way of initializing a base class constructor:
        //public Car(string registrationNumber)
        //{
        //    _registrationNumber = registrationNumber;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(2));
        }
        static int cube(int num)
        {
            int result = num * num * num;
            int result2 = result * num;
            return result;
        }
    }
}