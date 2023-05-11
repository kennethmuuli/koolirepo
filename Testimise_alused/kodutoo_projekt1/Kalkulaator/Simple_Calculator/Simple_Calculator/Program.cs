using System.Text;

/* Leitud vead */
//  1. Tehted üksteise otsas ühel real.
//  2. Juhise teine rida vigane.
// „Type in the numbers to be calculated and use +, -, *, / operators in between to specify the operation you want to complete.“
//  3. Tulemust on näiliselt võimalik muuta otse (juurde kirjutades)
//  4. “,” (koma) sisend ei tööta??
//  5. Helpi avamine kaotab ära konsoolist viimase avaldise

class Calculator
{
    public static double? a;
    public static double? b;
    public static string? _operator;
    public static double? value;
    public static StringBuilder? stringBuilder;
    public static bool justReset;
    public static bool checkedHelp;

    public static void Main()
    {
        var helpDisplayInstance = new Calculator();
        helpDisplayInstance.DisplayHelp();

        ConsoleKeyInfo keyInfo;
        stringBuilder = new StringBuilder();
        var controllerInstance = new Calculator();

        do
        {
            keyInfo = Console.ReadKey(true);
            controllerInstance.Contoller(keyInfo);

        }
        while (keyInfo.Key != ConsoleKey.Escape);
    }

    public void Contoller(ConsoleKeyInfo pressedKey)
    {
        var calculation = new Calculator();

        if (justReset == true)
        {
            Console.Clear();
            justReset = false;
        }
        else if (checkedHelp == true)
        {
            Console.Clear();
            checkedHelp = false;
            DisplayCurrentExpression();
        }

        
        switch (pressedKey.Key)
        {   
            case ConsoleKey.D1:
            case ConsoleKey.D2:
            case ConsoleKey.D3:
            case ConsoleKey.D4:
            case ConsoleKey.D5:
            case ConsoleKey.D6:
            case ConsoleKey.D7:
            case ConsoleKey.D8:
            case ConsoleKey.D9:
            case ConsoleKey.D0:
            case ConsoleKey.NumPad1:
            case ConsoleKey.NumPad2:
            case ConsoleKey.NumPad3:
            case ConsoleKey.NumPad4:
            case ConsoleKey.NumPad5:
            case ConsoleKey.NumPad6:
            case ConsoleKey.NumPad7:
            case ConsoleKey.NumPad8:
            case ConsoleKey.NumPad9:
            case ConsoleKey.NumPad0:
                {
                    if (a == null || _operator != null && b == null)
                    {
                        Console.Write(pressedKey.KeyChar);
                        stringBuilder.Append(pressedKey.KeyChar);
                    }
                    break;
                }
            case ConsoleKey.Decimal:
                {  
                    if (a == null || _operator != null && b== null)
                    {
                        //Asendame, numpadi "decimal" klahvi sisendi punktiga, et vältida klaviatuuri keele spetsiifiliseid erisusi, mis võivad sinna tegelikult vastasel juhul koma ette tuua.
                        Console.Write(".");
                        stringBuilder.Append(".");
                    }
                    break;
                }
            //matemaatiliste operaatori klahvide vajutamise loogika blokk
            case ConsoleKey.Divide:
            case ConsoleKey.Multiply:
            case ConsoleKey.Subtract:
            case ConsoleKey.Add:
                {
                    if (a == null && stringBuilder.Length > 0)
                    {
                        a = Convert.ToDouble(Convert.ToString(stringBuilder));
                        stringBuilder.Clear();

                        AppendAndWrite(pressedKey);
                    }
                    else if (_operator == null)
                    {
                        AppendAndWrite(pressedKey);
                    }
                    else if (b == null && stringBuilder.Length > 0)
                    {
                        b = Convert.ToDouble(Convert.ToString(stringBuilder));
                        stringBuilder.Clear();

                        if (a != null & b != null & _operator != null)
                        {
                            calculation.Calculate(Convert.ToDouble(a), Convert.ToDouble(b), _operator);
                            AppendAndWrite(pressedKey);
                        }
                        else
                        {
                            AppendAndWrite(pressedKey);
                        }
                    }
                    break;
                }
            case ConsoleKey.Enter:
                {
                    if (a == null)
                    {
                        if (stringBuilder.Length > 0)
                        {
                            a = Convert.ToDouble(Convert.ToString(stringBuilder));
                            stringBuilder.Clear();
                        }
                        else break;
                    }
                    else if (b == null)
                    {
                        if (stringBuilder.Length > 0)
                        {
                            b = Convert.ToDouble(Convert.ToString(stringBuilder));
                            stringBuilder.Clear();
                        }
                        else break;
                    }

                    //Testimise tarbeks, kirjutab välja salvestatud väärtuste hetke seisu
                    //Console.WriteLine(" 'Values check: A = " + a + " | B = " + b + " | Operator = " + _operator + "'");

                    calculation.Calculate(Convert.ToDouble(a), Convert.ToDouble(b), _operator);

                    break;
                }
            case ConsoleKey.R:
                {
                    Reset();
                    break;
                }
            case ConsoleKey.H:
                {
                    DisplayHelp();
                    break;
                }

            default: break;
        }
        

    }

    public void Calculate(double value1, double value2, string function)
    {
        switch (function)
        {
            case "+":
                {
                    value = a + b;
                    Console.Write(" = " + value + "\n" + value);
                    a = value; b = null; _operator = null;
                    break;
                }
            case "-":
                value = a - b;
                Console.Write(" = " + value + "\n" + value);
                a = value; b = null; _operator = null;
                break;
            case "*":
                {
                    value = a * b;
                    Console.Write(" = " + value + "\n" + value);
                    a = value; b = null; _operator = null;
                    break;
                }
            case "/":
                {
                    value = a / b;
                    Console.Write(" = " + value + "\n" + value);
                    a = value; b = null; _operator = null;
                    break;
                }
            default: break;
        }
    }

    public static void AppendAndWrite(ConsoleKeyInfo pressedKey)
    {
        stringBuilder.Append(pressedKey.KeyChar);
        _operator = Convert.ToString(stringBuilder);
        Console.Write(" " + pressedKey.KeyChar + " ");
        stringBuilder.Clear();
    }

    //kuva viimast avaldist hetke seisus, s.t. nii palju kui kasutaja on seni sisestanud
    public static void DisplayCurrentExpression()
    {

        //kontroll, et stringBuilder poleks parasjagu null väärtusega, vältimaks null ref excep.
        if(stringBuilder != null) 
        {

            //kui esimene avaldise väärtus on kirjutatud, kuid pole veel a avalise väärtusena salvestatud siis salvesta see, et seda saaks üksinda välja kuvada
            if (a == null && stringBuilder.Length > 0)
            {
                a = Convert.ToDouble(Convert.ToString(stringBuilder));
                stringBuilder.Clear();
            }
        }

        if (a != null)
        {
            Console.Write(a);

            if (_operator != null)
            {
                Console.Write(" " + _operator + " ");

                if (b != null)
                {
                    Console.Write(" " + b);
                }
            }
        }
    }

    public void Reset()
    {
        Console.Clear();
        stringBuilder.Clear();
        Console.Write("Calculator reset.");
        a = null;
        b = null;
        _operator = null;
        value = null;
        justReset = true;
    }

    public void DisplayHelp()
    {
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("This is a simple calculator able to do adding, subtraction, multiplying and dividing operations. It is designed to be used on the numpad of the keyboard.");
        Console.WriteLine("Type in the numbers to be calculated and use +, -, *, / operators in between to specify the operation you want to complete.");
        Console.WriteLine("Press ENTER to calculate the value of your expression or just keep on writing your calculations (the calculations will be displayed automatically if you have two variables and an operator entered).");
        Console.WriteLine("Press R to reset the calculator, ESCAPE to close the program or H to display this message again.");

        DisplayCurrentExpression();

        checkedHelp = true;
    }
}