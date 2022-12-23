using System.Transactions;

namespace EmployeeWageProblem
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            char cnt = '\0';
            
            while(true)
            {
                Console.WriteLine("\n******************************************************************");
                Console.WriteLine("***********|  WEL-COME TO EMPLOYEE WAGE  Application  |***********");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("*********************  OPTIONS ARE FOLLOWING  ********************y\n");
                Console.WriteLine("Enter 1 for UC1\nEnter 2 for UC2\nEnter 3 for UC3\nEnter 4 for UC4\nEnter 5 for UC5\nEnter 6 for UC6");
                Console.WriteLine("\n*************************|  END OF OPTIONS  |************************");
                Console.Write("Enter the Option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                    {

                        case 1:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random = new Random();
                            int empCheck = random.Next(0, 2);
                            EmployWageUC1 employWageUC1 = new EmployWageUC1();
                            employWageUC1.EmployeeUC1(empCheck);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 2:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random1 = new Random();
                            int empCheck1 = random1.Next(0, 2);
                            EmployWageUC2 employWageUC2 = new EmployWageUC2();
                            employWageUC2.EmployeeUC2(empCheck1);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 3:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random2 = new Random();
                            int empCheck2 = random2.Next(0, 3);
                            EmployWageUC3 employWageUC3 = new EmployWageUC3();
                            employWageUC3.EmployeeUC3(empCheck2);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 4:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random3 = new Random();
                            int empCheck3 = random3.Next(0, 3);
                            EmployWageUC4 employWageUC4 = new EmployWageUC4();
                            employWageUC4.EmployeeUC4(empCheck3);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 5:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random4 = new Random();
                            int empCheck4 = random4.Next(0, 3);
                            EmployWageUC5 employWageUC5 = new EmployWageUC5();
                            employWageUC5.EmployeeUC5(empCheck4);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 6:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Random random5 = new Random();
                            int empCheck5 = random5.Next(0, 3);
                            EmployWageUC6 employWageUC6 = new EmployWageUC6();
                            employWageUC6.EmployeeUC6(empCheck5);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        default:
                            Console.WriteLine("Please enter right option !!!!!!!!!!!!!");
                            break;
                    }
                Console.WriteLine("\nEnter Y to Continue OR N to Exit the Application\n");
                Console.Write("(Y/N)=>\t");
                cnt = Console.ReadLine()[0];
                if('y'.Equals(cnt))
                {
                    continue;
                }
                else if('n'.Equals(cnt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEnter the Proper Option");
                }
               
            }
        }
            
    }
}