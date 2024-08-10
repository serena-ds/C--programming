using System;
using static System.Console;
namespace Assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Task 1
            WriteLine("*************************");
            WriteLine("*Last name: Nguyen      *");
            WriteLine("*First name: Le Thao Nhi*");
            WriteLine("*Student ID: 11527293   *");
            WriteLine("*************************");


            // Task 2
            int aNumber;
            int cNumber; 
            int sNumber; 
            do
            {
                Write("Enter number of adult tickets: ");
                aNumber = int.Parse(ReadLine());
            }
            while (aNumber < 0);
            do
            {
                Write("Enter number of children tickets: ");
                cNumber = int.Parse(ReadLine());
            }
            while (cNumber < 0);
            do
            {
                Write("Enter number of senior tickets: ");
                sNumber = int.Parse(ReadLine());
            }
            while (sNumber < 0);


            // Task 3
            WriteLine("The number of tickets of adult is {0}, of children is {1} and of senior is {2}", aNumber, cNumber, sNumber);
            const double aTicket = 20;                  
            const double cTicket = aTicket * 0.5;       
            const double sTicket = aTicket * 75 / 100;  
            double aRevenue = aTicket * aNumber;        
            double cRevenue = cTicket * cNumber;        
            double sRevenue = sTicket * sNumber;        
            double total = aRevenue + cRevenue + sRevenue;
            WriteLine("The total revenue is {0}", total.ToString("C"));


            // Task 4
            if (aNumber <= cNumber + sNumber)
                WriteLine("The event is becoming a festival for everyone!");
            if (cNumber >= sNumber)
                WriteLine("The event is attracting more young people!");
            else WriteLine("The event should have more space for kids!");


            // Task 5
            Write("Enter the number of participants in this year's event: ");
            int pNumber = int.Parse(ReadLine());
            while (pNumber < 0 || pNumber > 40)
            {
                Write("Invalid value. Enter another value: ");
                pNumber = int.Parse(ReadLine());
            }


            // Task 6
            string[] pName = new string[pNumber];
            char[] pCode = new char[pNumber];
            int sCount = 0;
            int bCount = 0;
            int fCount = 0;
            int vCount = 0;
            const int sValue = 0;
            WriteLine("For each participant, enter the names and sporting codes.");
            for (int x = 0; x < pNumber; ++x)
            {
                Write("Please enter name for participant {0}: ", (x + 1));
                pName[x] = ReadLine();
                do
                {
                    Write("Please sporting code for participant {0} (S, B, F, V): ", (x + 1));
                    pCode[x] = char.Parse(ReadLine());
                }
                while (pCode[x] != 'S' && pCode[x] != 'B' && pCode[x] != 'F' && pCode[x] != 'V');
                if (pCode[x] == 'S')
                    sCount++;
                if (pCode[x] == 'B')
                    bCount++;
                if (pCode[x] == 'F')
                    fCount++;
                if (pCode[x] == 'V')
                    vCount++;
            }
            WriteLine("Count of each type of sport, ");
            WriteLine("Skating: {0}", sCount);
            WriteLine("Boxing: {0}", bCount);
            WriteLine("Football: {0}", fCount);
            WriteLine("Volleyball: {0}", vCount);

            char codeInput;
            Write("Please enter a sporting code (S, B, F, V): ");
            codeInput = char.Parse(ReadLine());
            while (codeInput != '0')
            {
                if (codeInput == 'S' || codeInput == 'B' || codeInput == 'F' || codeInput == 'V')
                {
                    if ((codeInput == 'S' && sCount == 0) || (codeInput == 'B' && bCount == 0) || (codeInput == 'F' && fCount == 0) || (codeInput == 'V' && vCount == 0))
                        WriteLine("There's no participant in {0}", codeInput);
                    else
                    {
                        for (int x = 0; x < pNumber; ++x)
                        {
                            if (pCode[x] == codeInput)
                                WriteLine("Participant: {0}", pName[x]);
                        }
                    }
                    Write("Please enter another sporting code (S, B, F, V) or 0 to stop: ");
                    codeInput = char.Parse(ReadLine());
                }
                else
                {
                    Write("The code is not valid, please enter a valid code (S, B, F, V): ");
                    codeInput = char.Parse(ReadLine());
                }
            }
        }
    }
}