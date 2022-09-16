using System;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string choice;
            Console.WriteLine("Which menu would you like to see first");
            Console.WriteLine("A Store information");
            Console.WriteLine("B Co-founder");
            Console.WriteLine("C Staff");
            Console.WriteLine("D Income and expenses");
            Console.Write("Choice : ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "A":
                    {
                        Console.WriteLine("Capital : 1,000,000");
                        Console.WriteLine("Branch : KFC Bang Khun Thian, Seaside");
                        Console.WriteLine("Address: Bang Khun Thian");

                        break;
                    }

                case "B":
                    {
                        Console.WriteLine("Name : Mr. Tawee ");
                        Console.WriteLine("Surname : Jaidee");
                        Console.WriteLine("ID: 153-698-4561237");

                        Console.WriteLine("Name : Mr. Yuttadee");
                        Console.WriteLine("Surname : Tangchai Rian");
                        Console.WriteLine("ID: 742-112-5687412");

                        Console.WriteLine("Name : Mr. James ");
                        Console.WriteLine("Surname : Love school ");
                        Console.WriteLine("ID: 541-772-3215689");
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("Position: Store staff");
                        Console.WriteLine("Name :  Mr. Chaidee");
                        Console.WriteLine("Surname : Rakdee");
                        Console.WriteLine("Age :  20");
                        Console.WriteLine("Income : 15,000");

                        Console.WriteLine("Position: Store staff");
                        Console.WriteLine("Name :  Mr. Non Dee");
                        Console.WriteLine("Surname : Jaidee ");
                        Console.WriteLine("Age :  18 ");
                        Console.WriteLine("Income : 15,000");

                        Console.WriteLine("Position: Store staff");
                        Console.WriteLine("Name :  Aphaidee");
                        Console.WriteLine("Surname : Riandee");
                        Console.WriteLine("Age :  22 ");
                        Console.WriteLine("Income : 15,000");

                        Console.WriteLine("Position: Delivery");
                        Console.WriteLine("Name :  ThamDee");
                        Console.WriteLine("Surname : Ngandee");
                        Console.WriteLine("Age :  25 ");
                        Console.WriteLine("Income : 12,500 ");


                        Console.WriteLine("Position: Delivery");
                        Console.WriteLine("Name :  Norndee");
                        Console.WriteLine("Surname : Riandee");
                        Console.WriteLine("Age :  23 ");
                        Console.WriteLine("Income : 12,500 ");
                        break;
                    }
                case "D":
                    {
                        int c = 236154;
                        int b = 70000;
                        int a = c - b;
                        Console.WriteLine("Total monthly income : {0} Bath", c);
                        Console.WriteLine("All employee payroll : {0} Bath", b);
                        Console.WriteLine("Balance : {0} Bath", a);
                        break;
                    }

                default: break;
            }


        }
    }
}