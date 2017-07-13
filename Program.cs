using System;
using static System.Console;
class Speed
{

    static void Main()
    {
        string numberString;
            int speed;

        Write("Enter wind speed ");
        numberString = ReadLine();
        speed = Convert.ToInt32(numberString);

        if (speed >= 157)
            WriteLine("CLass 5 Hurricane");
        else
            if
            (speed >= 130)
            WriteLine("Class 4 Hurricane");
        else
            if
            (speed >= 111)
            WriteLine("Class 3 Hurricane");
        else
            if
            (speed >= 96)
            WriteLine("Class 2 Hurricane");
        else
            if
            (speed >= 74)
            WriteLine("Class 1 Hurricane");
        else
            WriteLine("Not a Hurricane");
    }
}
