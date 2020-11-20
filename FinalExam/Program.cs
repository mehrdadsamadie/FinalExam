using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult[] adults = new Adult[2] { new Adult() {FirstName="alex" ,LastName="Sad"}, new Adult() { FirstName = "Mehrdad", LastName = "samadie" } };

            Child[] childs = new Child[2] { new Child() { FirstName = "Sherman", LastName = "hahi" }, new Child() { FirstName = "Mohammad", LastName = "Ali" } };
            IPerson[] array = new IPerson[4];
            array[0] = adults[0];
            array[1] = adults[1];
            array[2] = childs[0];
            array[3] = childs[1];
            Print(adults);
            Print(childs);
            Print(array);
        }
        static void Print(IPerson[] a) 
        {
            foreach(var item in a) 
            {
                Console.WriteLine( item.FirstName+" - "+item.LastName);
            }
        }
    }


    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Adult : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Child : IPerson 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
