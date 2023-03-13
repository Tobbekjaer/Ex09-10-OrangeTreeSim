namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testing Age property
            OrangeTree orangeTree1 = new OrangeTree();
            orangeTree1.Age = -345;
            Console.WriteLine(orangeTree1.Age);

            // Testing Height property
            orangeTree1.Height = 10;
            Console.WriteLine(orangeTree1.Height);

            // Testing TreeAlive property
            orangeTree1.TreeAlive = true;
            Console.WriteLine(orangeTree1.TreeAlive);

            // Testing NumOranges property
            //orangeTree1.NumOranges = 5;
            //Console.WriteLine(orangeTree1.NumOranges);

            //// Testing OrangesEaten property
            //orangeTree1.OrangesEaten = 5;
            //Console.WriteLine(orangeTree1.OrangesEaten);

            Console.ReadLine();

        }
    }
}