using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OwnMathLib;

namespace CalculatorInput
{
    enum Operations
    {
        Add,
        Sub,
        Mul,
        Div,
        Sin,
        Cos,
        Tan,
        Exp,
        Quad,
        Pow,
        Sqrt,
        Root,
        Fac,
        Base10,
        Log,
        LogBaseY,
        Ln,
        Exit
        
    }
    public class Calculator
    {
        public static void Main(string[] args)



        {
            /// geht den gesmaten Enum durch und prüft was für Variablen darin stehen und erstellt davon eine Liste
            
            List<Operations> operations = Enum.GetValues(typeof(Operations)).Cast<Operations>().ToList();

            string consoleOutput = string.Empty;

            for (int i = 1; i <= operations.Count; i++) 
            {
                if (i > 9)
                {
                    consoleOutput += "[" + i + "] ";
                }
                else 
                {
                    consoleOutput += "[0" + i + "] ";
                }
                                
                consoleOutput += operations[i-1].ToString() + " \n";

            }

            Console.WriteLine(consoleOutput);
            Console.Write("Waehlen Sie eine Rechenoperation: ");
            

            while (true)
            {
                int operationChoice = -1;
                try
                {
                     operationChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                catch(Exception e) {}

                if (operationChoice == -1 || operationChoice > operations.Count)
                {
                    Console.WriteLine("Ungueltige Eingabe!");
                    Console.Write("Waehlen Sie eine Rechenoperation: ");
                    
                }
                else
                {
                    AritmethicOperations aritmethicOperations = new AritmethicOperations(); 
                    CircularOperations circularOperations = new CircularOperations();   
                    ScientificOperations scientificOperations = new ScientificOperations(); 

                    
                    
                    Operations op = operations[operationChoice];

                    Console.WriteLine(op.ToString());

                    switch (op)
                    {
                        case Operations.Add :
                            /// Variablen müssen bekannt gemacht werden
                            double x,y;

                            try
                            {   /// datentyp kann entfernt werden da oben bekannt gemacht
                                Console.Write("Eingabe erste Zahl: ");
                                 x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                 y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception e) 
                            {
                                /// im Fehlerfall Variablen notfalls auf 0 deklarieren
                                /// TODO: Message für Fehler schreiben
                                x = 0; y = 0;
                            }

                            


                            /// für den jeweiligen Case zuweisen der Variablen
                            aritmethicOperations.x = x;
                            aritmethicOperations.y = y;

                            
                         
                            Console.WriteLine("Ergebnis: " + RoundResult(aritmethicOperations.Add()));

                            break;
                        case Operations.Sub:
                            break;
                        case Operations.Mul:
                            break;

                            /// TODO: alle anderen Operationen noch einfügen---
                            /// 






                        case Operations.Exit:
                             return;
                    }
                }
                
                
            };

        }

        public static double RoundResult(double answer)
        {
            
            double offset = Math.Pow(10, 8);
            double cutOff = answer * offset;
            int rounded = (int)cutOff;
            return rounded / offset;

            
        }
       
    }
}

