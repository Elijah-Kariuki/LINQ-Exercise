using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LINQ
{
    public class Program
    {
       

        
        
        

        static void Main(string[] args)
        {
            List<string> games = new List<string>()
        {
            "Resident Evil Village: Shadow of Rose", "NFL John Madden Football 2023",
            "The Legend of Zelda: Breath of the Wild","Red Dead Redemption 2"
        };
            IEnumerable<string> byLength = games.OrderByDescending(title => title.Length);
            foreach (string title in byLength)
            { Console.WriteLine(title); }

            
        }
    }
}
