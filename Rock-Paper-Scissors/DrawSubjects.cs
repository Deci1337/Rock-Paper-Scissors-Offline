using static System.Net.Mime.MediaTypeNames;

namespace rock_paper_scissors
{
    internal class DrawSubjects
    {
        private void drawer(string text, int x)
        {
            string[] image = text.Split('\n');
            for (int i = 0; i < image.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(image[i]);
            }
        }
        internal DrawSubjects(string Name, string random)
        {
            string item;
            string randomItem;
            switch (Name)
            {
                case "Scissors":
                    item = scissors(); break;
                case "Paper":
                    item = paper(); break;
                case "Rock":
                    item = rock(); break;
                default:
                    item = "Error"; break;
            }
            switch (random)
            {
                case "Scissors":
                    randomItem = scissors(); break;
                case "Paper":
                    randomItem = paper(); break;
                case "Rock":
                    randomItem = rock(); break;
                default:
                    randomItem = "Error"; break;
            }
            Console.CursorVisible = false;
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                drawer(item + "\nPress any button\n", 10);
                drawer(randomItem, Console.WindowWidth - 30);
                Thread.Sleep(400);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                drawer(item + "\nPress any button\n", 10);
                drawer(randomItem, Console.WindowWidth - 30);
                Thread.Sleep(400);
            }
        }
        private string scissors()
        {
             return (@"
   ████          ████  
 ▓▓░░░░▓▓      ▓▓░░░░▓▓
 ██░░░░██      ██░░░░██
  ██░░░░██    ██░░░░██
  ██░░░░██  ░░░░░░░░██
  ██░░░░██  ██░░░░▓▓  
  ▓▓██▓▓░░░░▓▓██░░░░██  
  ██████░░░░██░░░░██░░░░██    
██░░░░██░░░░██░░░░██░░░░██    
██░░░░██░░░░██░░░░░░░░░░██    
██░░░░██░░░░██░░░░░░░░░░██    
██░░░░██░░░░████████████▓▓    
▓▓░░░░██░░░░██░░░░░░░░░░░░██  
██▓▓▓▓▒▒▓▓▓▓██░░░░░░░░░░░░██  
▓▓░░▒▒░░░░░░░░▓▓▓▓▒▒▒▒░░░░██  
▓▓░░░░░░░░░░░░░░░░░░░░░░░░██  
██░░░░░░░░░░░░░░░░░░░░░░░░██  
██░░░░░░░░░░░░░░░░░░░░░░██    
██░░░░░░░░░░░░░░░░░░░░██    
██░░░░░░░░░░░░░░░░░░██      
██░░░░░░░░░░░░░░██        
██░░░░░░░░░░░░░░██        
██░░░░░░░░░░░░░░██  
");
        }
        private string paper()
        {
            return (@"
            ██▒▒                      
      ██▓▓▓▓░░░░▓▓▓▓██                
    ██░░░░██░░░░██░░░░██                
  ▓▓▓▓██░░░░██░░░░██░░░░██                
▓▓░░░░██░░░░██░░░░██░░░░██                
██░░░░██░░░░██░░░░██░░░░██                
██░░░░██░░░░██░░░░██░░░░██                
██░░░░██░░░░██░░░░██░░░░██                
██░░░░░░░░░░░░░░░░░░░░░░██                
▓▓░░░░░░░░░░██████████████                
▓▓░░░░░░░░░░██░░░░░░░░░░░░██                
██░░░░░░░░░░██░░░░░░░░░░░░██                
██░░░░░░░░░░░░▓▓▒▒▓▓▓▓░░░░▓▓                
██░░░░░░░░░░░░░░░░░░░░░░░░▓▓                
██░░░░░░░░░░░░░░░░░░░░░░░░██                
██░░░░░░░░░░░░░░░░░░░░░░██                  
 ██░░░░░░░░░░░░░░░░░░░░██                  
 ██░░░░░░░░░░░░░░░░░░██                    
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
  ██░░░░░░░░░░░░░░██                      
");

        }
        private string rock()
        {
            return (@"
        ▓▓▓▓  ▓▓▓▓  ██▒▒
  ██████░░░░██░░░░██░░░░██
▓▓░░░░██░░░░██░░░░██░░░░██
▓▓░░░░██░░░░██░░░░██░░░░██
▓▓░░░░██░░░░██░░░░██░░░░██
██░░░░██░░░░██████████████
▓▓░░░░██░░░░██░░░░░░░░░░░░██
▓▓▓▓▓▓▒▒▓▓▓▓██░░░░░░░░░░░░██
▓▓░░░░░░░░░░░░██▒▒▓▓▓▓░░░░██
░░░░░░░░░░░░░░░░▒▒░░░░░░░░██
░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓
░░░░░░░░░░░░░░░░░░░░░░░░██
  ██░░░░░░░░░░░░░░░░░░░░██
  ██░░░░░░░░░░░░░░░░░░██
    ██░░░░░░░░░░░░░░██
    ██░░░░░░░░░░░░░░██
    ██░░░░░░░░░░░░░░██
    ██░░░░░░░░░░░░░░██
    ██░░░░░░░░░░░░░░██      
    ██░░░░░░░░░░░░░░██     
    ██░░░░░░░░░░░░░░██      
    ██░░░░░░░░░░░░░░██     
");

        }
    }
}
