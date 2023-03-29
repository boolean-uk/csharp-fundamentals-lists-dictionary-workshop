namespace workshop.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Dictionary<string,string> dictionary = new Dictionary<string,string>();

            dictionary.Add("fish", "a creature that swims in water");
            dictionary.Add("lion", "a creature that lives in a zoo");
            dictionary.Add("banana", "a piece of fruit that is yellow");


            Console.WriteLine(dictionary["fish"]);


            //2
            //why the var keyword?  well we can change the dictionary easily
            //declares type on assign
            var zoo = new Dictionary<string, int>()
            {
                {"cat", 2},
                {"dog", 1},
                {"snake",4},
                {"llama", 0},
                {"iguana", 11}
            };

            zoo.ToList().ForEach(x => {
                Console.WriteLine($"{x.Key}:{x.Value}");
            });


            //3
            var passengerList = new List<string>()
            {
                "Nigel",
                "Bob",
                "Linda",
                "Emma"
            };

            
            //4
            var ages = new List<int>();
            ages.Add(2);
            ages.Add(3);
            ages.Add(2);
            ages.Add(5);
            ages.Add(3);












            Console.ReadLine();
        }
    }
}