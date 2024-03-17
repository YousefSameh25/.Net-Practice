using System.Text.RegularExpressions; // Must be called
namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Yousef";
            s = Regex.Replace(s, "[aeiouAEIOU]", "#");

            // Add '\' before '#' and other chars.
            s = Regex.Escape(s);
            Console.WriteLine(s);


            var Q = Regex.Split("X,X,X,X,X,X", ",");

            Console.WriteLine(Regex.IsMatch("Yousef", "use"));

        }
    }
}
