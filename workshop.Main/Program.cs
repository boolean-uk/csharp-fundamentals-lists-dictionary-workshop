
using System.Security.Cryptography;

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
            var JavaClass = new List<string>()
            {
                "Java Nigel",
                "Java Bob",
                "Java Linda",
                "Java Emma"
            };

            var CSharpClass = new List<string>()
            {
                "C# Emily",
                "C# Nadine",
                "C# Marie",
                "C# Frederic",
                "C# Mo"
            };

            //var BothClasses = new List<string>();
            //BothClasses.AddRange(JavaClass);
            //BothClasses.AddRange(CSharpClass);



            var UnassignedStudents = new List<string>()
            {
                "Footballer Ronaldo",
                "Footballer Maradona"
            };

            List<string> AllStudents = new List<string>();
            AllStudents.AddRange(JavaClass);
            AllStudents.AddRange(CSharpClass);
            AllStudents.AddRange(UnassignedStudents);

            JavaClass.Add("JAVA Barry");

            //var AllStudents = JavaClass.Concat(CSharpClass).Concat(UnassignedStudents).ToList();



            List<Person> people1 = new List<Person>()
            {
                new Person() { Name = "bob"},
                new Person() { Name = "bib"},
                new Person() { Name = "bab"},
                new Person() { Name = "bub"}
            };

            List<Person> people2 = new List<Person>()
            {
                new Person() { Name = "1bob"},
                new Person() { Name = "1bib"},
                new Person() { Name = "1bab"},
                new Person() { Name = "1bub"}
            };



            //var both = Persons.Concat(Persons2).ToList<Person>();
            List<Person> both = new List<Person>();
            //both.AddRange(Persons);
            //both.AddRange(Persons2);

            people1.ForEach(p => { 
                both.Add(new Person() { Name = p.Name });
            });
            people2.ForEach(p => {
                both.Add(new Person() { Name = p.Name });
            });

            people2.ForEach(x => {
                x.Name = $"v2.2_{x.Name}";
            });







            //4
            var ages = new List<int>();
            ages.Add(2);
            ages.Add(3);
            ages.Add(2);
            ages.Add(5);
            ages.Add(3);





            //querying strings
            Dictionary<string, int> MyFridge = new Dictionary<string, int>();
            MyFridge.Add("Carrots", 5);
            MyFridge.Add("Potatoes", 8);
            MyFridge.Add("Peppers", 5);
            MyFridge.Add("Beetroot", 4);
            MyFridge.Add("Cucumber", 2);
            MyFridge.Add("Broccoli", 1);
            MyFridge.Add("Onions", 8);
            MyFridge.Add("Shallots", 8);



            //lamda
            var lamda_low_veg = MyFridge.Where(x => x.Value <= 2).ToList();
            
            //linq
            var linq_low_veg = (from item in MyFridge where item.Value <= 2 select item).ToList();


            //lamda returing single item
            var lamda_danger = MyFridge.First(x => x.Key == "Carrots");  //FYI if it can't find a carrot throws exception (bad!)
            var lamda_carrot = MyFridge.Where(x => x.Key == "Carrots").FirstOrDefault();

            //linq carrot
            var linq_lamda_carrot = (from item in MyFridge where item.Key == "Carrrot" select item);

            //lamda
            var lamda_p_items = MyFridge.Where(item => item.Key.ToLower().StartsWith("p")).ToList();

            //linq
            var linq_p_items = (from item in MyFridge where item.Key.ToLower().StartsWith("p") select item).ToList();
            Console.ReadLine();
        }
    }
}