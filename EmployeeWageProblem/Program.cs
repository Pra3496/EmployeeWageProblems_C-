using System.ComponentModel.Design;
using System.Transactions;

namespace EmployeeWageProblem
{
    internal class Program throws Ex
    {
      
        static void Main(string[] args)
        {
            char cnt = '\0';
            
            while(true)
            {
                Menu:
                        Console.WriteLine("\n******************************************************************");
                        Console.WriteLine("***********|  WEL-COME TO EMPLOYEE WAGE  Application  |***********");
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("*********************  OPTIONS ARE FOLLOWING  ********************\n");
                        Console.WriteLine("Enter 1 for Employee Attendance\nEnter 2 for Calculating Employee Wage\nEnter 3 for Calculating Employee Wage with Part-Time\nEnter 4 for Calculating Employee Wage Using Switch Case\nEnter 5 for Calculating Employee Wage for Month\nEnter 6 for Calculating Employee Wage for Month Max Days");
                        Console.WriteLine("\n***********************|  END OF OPTIONS  |*********************");
                        Console.Write("Enter the Option : ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (option)
                            {
                     
                                case 1:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random = new Random();
                                    int empCheck = random.Next(0, 2);
                                    EmployWageUC1 employWageUC1 = new EmployWageUC1(empCheck);
                                    employWageUC1.EmployeeUC1();
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                case 2:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random1 = new Random();
                                    int empCheck2 = random1.Next(0, 2);
                                    EmployWageUC2 employWageUC2 = new EmployWageUC2(empCheck2);
                                    employWageUC2.EmployeeUC2();
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                case 3:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random2 = new Random();
                                    int empCheck3 = random2.Next(0, 3);
                                    EmployWageUC3 employWageUC3 = new EmployWageUC3(empCheck3);
                                    employWageUC3.EmployeeUC3();
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                case 4:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random3 = new Random();
                                    int empCheck4 = random3.Next(0, 3);
                                    EmployWageUC4 employWageUC4 = new EmployWageUC4();
                                    employWageUC4.EmployeeUC4(empCheck4);
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                case 5:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random4 = new Random();
                                    int empCheck5 = random4.Next(0, 3);
                                    EmployWageUC5 employWageUC5 = new EmployWageUC5();
                                    employWageUC5.EmployeeUC5(empCheck5);
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                case 6:
                                    Console.WriteLine("\n*******************> Result <*********************\n");
                                    Random random5 = new Random();
                                    int empCheck6 = random5.Next(0, 3);
                                    EmployWageUC6 employWageUC6 = new EmployWageUC6();
                                    employWageUC6.EmployeeUC6(empCheck6);
                                    Console.WriteLine("\n****************> End of Result <******************\n");
                                    break;
                                default:
                                    Console.WriteLine("Please enter right option !!!!!!!!!!!!!");
                                    goto Menu;
                            }
                ExitMenu:
                                
                                Console.WriteLine("\nEnter Y to Continue OR N to Exit the Application\n");
                                Console.Write("(Y/N)=>\t");
                                cnt = Console.ReadLine()[0];
                                Console.WriteLine("\n");
                                if(('Y'.Equals(cnt)) || ('y'.Equals(cnt)))
                                {
                                    continue;
                                }
                                else if(('n'.Equals(cnt)) || ('N'.Equals(cnt)))
                                {
                                    Console.WriteLine("************>| THANK YOU for using this application |<**********");
                                    break;
                                }
                                else
                                {
                                      Console.WriteLine("\nEnter the Proper Option !!!!!!!!!!!!!!!!!!!!!");
                                      goto ExitMenu;
                                }
               
            }
        }
            
    }
}