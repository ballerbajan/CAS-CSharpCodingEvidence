using System;

namespace ps
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("good morning today is? enter 0- 6 from days sunday to saturday");
            Console.WriteLine(getday(Convert.ToInt32(Console.ReadLine())));
            

            Console.Write("give me a number");
            double numb1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("operator plox");
            string op = Console.ReadLine();

            Console.Write("enter another number");
            double numb2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(numb1+numb2);
            }else if(op == "-")
            {
                Console.WriteLine(numb1-numb2);
            }
            else if(op == "*")
            {
                Console.WriteLine(numb1*numb2);
            }
            else if (op == "/")
            {
                Console.WriteLine(numb1/numb2);
            }
            Convert.ToInt32(numb1);
            Convert.ToInt32(numb2);

            Console.WriteLine("this is the biggest number you entered");

            Console.WriteLine(GetMax(Convert.ToInt32(numb1), Convert.ToInt32(numb2),0));

            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
                
            }
            Console.WriteLine("wanna play a game? \n enter yes or no");
            string yesGame = Console.ReadLine();
            do
            {
                if (yesGame == "yes")
                {
                    Console.WriteLine(game("play"));
                }
                else if (yesGame == "no")
                {
                    Console.WriteLine("ok then :(");
                    break;
                }
                else
                {
                    Console.WriteLine("incorrect response");
                    break;
                }

            } while (yesGame != "yes");
            Console.ReadLine();
        }


        static int GetMax(int numb1, int numb2, int numb3)
        {
            int result;
            if (numb1 >= numb2 && numb1 >= numb3)
            {
                result = numb1;

            }
            else if(numb2 >= numb1 && numb2 >= numb3)
            {
                result = numb2;
            }
            else
            {
                result = numb3;
            }


            return result;
        }
        static string getday(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "sunday";
                    break;
                case 1:
                    dayName = "monday";
                    break;
                case 2:
                    dayName = "tuesday";
                    break;
                case 3:
                    dayName = "wednesday";
                    break;
                case 4:
                    dayName = "thursday";
                    break;
                case 5:
                    dayName = "friday";
                    break;
                case 6:
                    dayName = "saturday";
                    break;
                default:
                    dayName = "invalid try again";
                    break;
            }
            return dayName;
                   
        }

        static string game(string play)
        {
            string secretword = "jump";
            string guess = "";
            string done;


            while (guess != secretword)
            {
                Console.WriteLine("enter a guess. hint jump");
                guess = Console.ReadLine();
            }
            Console.Write("you win!");
            done = "\n how fun!";
            return done;
        }




        }
        }



            