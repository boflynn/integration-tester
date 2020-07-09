using System;
using System.Collections.Generic;
using System.Linq;

namespace BoFlynn.Math
{
    public class Adder
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Add2(int left, int right)
        {
            return left + right;
        }

        public int Add3(int left, int right)
        {
            return left + right;
        }

        public int Awful(int one, int two, int three, int four, int five, int six, int seven, int eight, int nine, int ten, int eleven)
        {
            return 0;
        }

        public void Bad()
        {
            var things = Thing.GetThings();

            foreach(var t in things)
            {
                System.Console.WriteLine(t.Id);
            }
        }

        public override string ToString()
        {
            // This should be a bug
            return null;
        }
    }

    public class Thing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static IEnumerable<Thing> GetThings()
        {
            return null;
        }

    }
}
