namespace SeconDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            String name = string.Empty;
            name = Console.ReadLine();
            int age;
            age = Convert.ToInt32(Console.ReadLine()); //age data type int cần convert sang string
            /*age = Console.ReadLine();*/
            ShowName(name, age);
            DateTime time = DateTime.Now;
            Console.WriteLine($"At the time: {time}");
        }
        /// <summary>
        /// 
        /// </summary>
        
        
        public static void ShowName(String name, int age)
        {
            Console.WriteLine("My name is {0}, and I {1} years old", name, age);
            Console.WriteLine($"Name is {name} and i {age} years old");
        }

    }
}
