namespace Classes
{
    // class
    class Person
    {
        // Fields
        public int Id;
        public string Name;
        public List<int> Numbers;

        // Constructor
        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Numbers = new List<int>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1, "John");
            person.Numbers.Add(10);
            person.Numbers.Add(20);

            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(string.Join(", ", person.Numbers));
        }

    }
}