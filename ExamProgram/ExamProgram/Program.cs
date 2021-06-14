using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgram
{
    class Program
    {
        static void start()
        {
            int score = 0;
            string[] questions = new string[10]
            {
                "Nece okean var?","Stromboli vulkani hansi olkenin erazisindedir?","Futbol hansi olkede yaranmisdi?",
                "Albaniya paytaxti hansi seherdir?","Sahmatin veteni haradi?","BMT qerargahi harda yerlesir?",
                "Dunyanin en bol sulu cayi hansidi?","Cempionlar Liqa kubokunu 5 defe qaldiran klub hansidir?",
                "Qargalar orta hesabla nece il yasayir?","Hansi canlinin qani beyazdi"
            };
            string[] answerTrue = new string[10]
            {
                "4","Italiya","Ingiltere","Tirana","Hindistan","Nyu-York","Amazon","Liverpul","120","Ceyirtke"
            };
            string[] answer1 = new string[10]
            {
                "3","Yaponiya","Brazilya","Vyana","Cin","Vasinqton","Nil","Barselona","200","Kepenek"
            };
            string[] answer2 = new string[10]
            {
                "2","Filippin","Italiya","Praga","Ingiltere","Moskva","Volqa","M.Yunayted","100","Horumcek"
            };

            for (int i = 0; i < questions.Length; i++)
            {
                Random random = new Random();
                var temp1 = random.Next(1, 4);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n\n\n\n\t\t\t\t{i + 1}.{questions[i]}");

                //Random variant ucun algorithm hisse
                if (temp1 == 1)
                {
                    Console.WriteLine($"\t\t\t\tA){answerTrue[i]}");
                    var temp2 = random.Next(2, 4);
                    if (temp2 == 2)
                    {
                        Console.WriteLine($"\t\t\t\tB){answer1[i]}");
                        Console.WriteLine($"\t\t\t\tC){answer2[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t\tB){answer2[i]}");
                        Console.WriteLine($"\t\t\t\tC){answer1[i]}");
                    }
                    answerTrue[i] = answerTrue[i].Insert(0, "A");
                }
                else if (temp1 == 2)
                {
                    var temp2 = random.Next(1, 3);
                    if (temp2 == 1)
                    {
                        Console.WriteLine($"\t\t\t\tA){answer1[i]}");
                        Console.WriteLine($"\t\t\t\tB){answerTrue[i]}");
                        Console.WriteLine($"\t\t\t\tC){answer2[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t\tA){answer2[i]}");
                        Console.WriteLine($"\t\t\t\tB){answerTrue[i]}");
                        Console.WriteLine($"\t\t\t\tC){answer1[i]}");
                    }
                    answerTrue[i] = answerTrue[i].Insert(0, "B");
                }
                else if (temp1 == 3)
                {
                    var temp2 = random.Next(1, 3);
                    if (temp2 == 1)
                    {
                        Console.WriteLine($"\t\t\t\tA){answer1[i]}");
                        Console.WriteLine($"\t\t\t\tB){answer2[i]}");
                        Console.WriteLine($"\t\t\t\tC){answerTrue[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t\tA){answer2[i]}");
                        Console.WriteLine($"\t\t\t\tB){answer1[i]}");
                        Console.WriteLine($"\t\t\t\tC){answerTrue[i]}");
                    }
                    answerTrue[i] = answerTrue[i].Insert(0, "C");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n\t\t\t\tCavabi daxil edin:");
                char text = Convert.ToChar(Console.ReadLine());
                text = char.ToUpper(text);
                while (text != 'A' && text != 'B' && text != 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\t\t\t\tYeniden cavabi daxil edin:");
                    text = Convert.ToChar(Console.ReadLine());
                    text = char.ToUpper(text);
                }
                if (text == answerTrue[i].ElementAt(0))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    score += 10;
                    Console.WriteLine("\nCavab Dogrudu");
                    Console.WriteLine($"\nXal->{score}");
                }
                else
                {
                    if (score != 0)
                    {
                        score -= 10;
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nCavab Yanlisdi");
                    Console.WriteLine($"\nXal->{score}");
                }
                System.Threading.Thread.Sleep(1000);
                Console.ResetColor();
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n\n\n\n\t\t\t\tYekun Xal:{score}");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
