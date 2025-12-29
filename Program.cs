namespace LearningCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            YoungProfessional yp = new YoungProfessional();

            GeneralUses.GetRno();
            GeneralUses.GetRno();

            string sent = "I am Fine.";
            int count = sent.WordCount();
            Console.WriteLine(count);
        }
    }


}
