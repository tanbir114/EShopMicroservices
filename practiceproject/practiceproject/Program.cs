namespace practiceproject
{
    internal class Program
    {
        double x, y, z;
        void Accept()
        {
            Console.WriteLine("Enter three numbers:");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
        }

        double CalculateAverage()
        {
            return (x + y + z) / 3;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Accept();
            Console.WriteLine("Average: " + obj.CalculateAverage());
        }
    }
}
