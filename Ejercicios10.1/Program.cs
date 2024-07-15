while(true)
{

    try
    {
        Console.Clear();
        Console.WriteLine("---------------------------");
        Console.WriteLine("        CALCULATOR");
        Console.WriteLine("---------------------------\n");
        int option;
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Sub");
        Console.WriteLine("3. Multiplicate");
        Console.WriteLine("4. Divide");
        Console.Write("Choose a option: ");
        option = Convert.ToInt32(Console.ReadLine());
       
        switch(option)
        {

            case 1: {
                    while (true)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("             ADD");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("---------------------------\n");
                            int resultAdd;
                            int number;
                            int number1;
                            Console.Write("Write a number: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Write a number: ");
                            number1 = Convert.ToInt32(Console.ReadLine());
                            resultAdd = number + number1;

                            Console.WriteLine("   " + number);
                            Console.WriteLine("+  " + number1);
                            Console.WriteLine("----------------");
                            Console.WriteLine("   " + resultAdd);


                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nFormat in valid");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        catch (OverflowException CatchMessage1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(CatchMessage1.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadKey();
                    }
                   
                
                
                }break;
            case 2: {
                    while (true)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("             SUB");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("---------------------------\n");
                            int resultSub;
                            int number;
                            int number1;
                            Console.Write("Write a number: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Write a number: ");
                            number1 = Convert.ToInt32(Console.ReadLine());

                            resultSub = number - number1;
                            Console.WriteLine("   " + number);
                            Console.WriteLine("-  "+number1);
                            Console.WriteLine("----------------");
                            Console.WriteLine("   " + resultSub);




                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nFormat in valid");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        catch (OverflowException CatchMessage1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(CatchMessage1.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadKey();
                    }



                }
                break;
            case 3: {
                    while (true)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("       MULTIPLICATE");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("---------------------------\n");
                            int resultMultiplicate ;
                            int number;
                            int number1;
                            Console.Write("Write a number: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Write a number: ");
                            number1 = Convert.ToInt32(Console.ReadLine());
                            resultMultiplicate = number * number1;

                            Console.WriteLine("\n   " + number);
                            Console.WriteLine("*  " + number1);
                            Console.WriteLine("----------------");
                            Console.WriteLine("   " + resultMultiplicate);



                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nFormat invalid");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        catch (OverflowException CatchMessage1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n" + CatchMessage1.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadKey();
                    }



                }
                break;
                case 4: {
                    while (true)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("           DIVIDE");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("---------------------------\n");
                            int resultDivide;
                            int number;
                            int number1;
                            Console.Write("Write a number: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Write a number: ");
                            number1 = Convert.ToInt32(Console.ReadLine());

                            resultDivide = number / number1;
                            Console.WriteLine(number + " / " + number1);
                            Console.WriteLine("\nThe result: " + resultDivide);



                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nFormat in valid");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        catch (DivideByZeroException CatchMessage)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n"+CatchMessage.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch ( OverflowException CatchMessage1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n"+CatchMessage1.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadKey();
                    }



                }
                break;

        }    



    }
    catch(FormatException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n Format in valid");
        Console.ForegroundColor = ConsoleColor.White;

    }
    Console.ReadKey();

}