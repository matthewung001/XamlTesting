using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlReview
{
    class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        // Override IEqautable
        public bool Equals(Car car) => this == car;

        public static bool operator==(Car car1, Car car2)
        {
            return car1.Make == car2.Make && car1.Model == car2.Model && car1.Year == car2.Year;
        }

        public static bool operator!=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }
    }

    interface IDimensions
    {
        float getLength();
        float getWidth();
    }

    class Box : IDimensions
    {
        float length;
        float width;

        public Box(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        // Explicit interface member implementations
        float IDimensions.getLength()
        {
            return length;
        }

        float IDimensions.getWidth()
        {
            return width;
        }
    }

    // Inheritance testing
    public class A
    {
        public virtual void DoWork() => Console.WriteLine("Class A");
    }

    public class B : A
    {
        public override void DoWork() => Console.WriteLine("Class B");
    }

    public class C : B
    {
        public sealed override void DoWork() => Console.WriteLine("Class C");
    }

    public class D : C
    {
        public new void DoWork() => Console.WriteLine("Class D");
    }
}
