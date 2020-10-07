using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            int [] array = new int[100];
            string response;
            Console.WriteLine("What Do You Want To Do \n 1.Addition\n 2.Substraction\n 3.Mulitplication\n 4.Division\n");

            response = Console.ReadLine();

            if (response == "1" || response =="Addition"  ){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ok, So you want to add some numbers \n Enter how much number you want to add ");
                int [] arr = new int[20];
                int count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the numbers you want to add");
                int sum = 0;
                for (int i = 0; i<count ; i++){
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum = arr[i] + sum;
                }

                Console.WriteLine("Your Output Is : " + sum);


            }

           else if(response == "2" || response =="Substraction" || response == "substraction" ){

               Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ok, So you want to substract some numbers \n Enter how much number you want to substract");
                int [] arr = new int[20];
                int count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the numbers you want to substract");
                int  subs = 0;
                for (int i = 0; i<count; i++){
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    subs = arr[i] - subs;
                }

                Console.WriteLine("Your Output Is : " + subs);
            }
           else if(response == "3" || response =="Multiplication" || response == "multiplication" ){
               Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ok, So you want to multiply some numbers \n Enter how numbers you want to multiply ");
                int count = Convert.ToInt32(Console.ReadLine());
                int [] arr = new int[20];

                Console.WriteLine("Enter the numbers you want to mulitply");
                int multiply = 1;
                for (int i = 0; i<count; i++){
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    multiply = multiply * arr[i];
                }

                Console.WriteLine("Your Output is : " + multiply);


            }
           else if(response == "4" || response =="Division" || response == "division" ){
               Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ok, So you want to divide some numbers \n Enter two numbers to divide ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int divide = a/b;

                Console.WriteLine("Your Output is : " +divide );
            }

            //closing after anykey enters
            Console.WriteLine("---------------------------------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("close program by Entering any key");
            Console.ReadKey();

        }

    }
}
