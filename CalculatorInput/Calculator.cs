using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OwnMathLib;

/* The possibility of nesting through the use of parentheses first requires a splitter 
 * that splits the line expression of the task into multiple parts.
 * Then, a parser can parse through the split parts to find valid arguments and perform
 * the known arithmetic operations with them. 
 * It can only find a number, an operator symbol, or an opening/closing parenthesis.
 * If it encounters the equal sign operator, it starts the calculation and returns 
 * the result through the corresponding variable.
 * Unfortunately, my programming skills are not sufficient to solve this task completely.  
 * 
 * The combination of arithmetic operations should implement. 
 */

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
    /// <summary>
    /// the public class Calculator includes all used Operations to solve any Calculation.
    /// </summary>
    public class Calculator
    {
        public static void Main(string[] args)



        {
            /// the List of operations was casted to the number
            
            List<Operations> operations = Enum.GetValues(typeof(Operations)).Cast<Operations>().ToList();

            /// for loop runs throw the Enum and look for all numbers greater than 9

            string consoleOutput = string.Empty;

            for (int i = 1; i <= operations.Count; i++) 
            {                             
                if (i > 9)
                {
                    /// if the number is greater than 9, then write the  number without "0"
                    
                    consoleOutput += "[" + i + "] ";
                }
                else 
                {   ///  if the number is less then 9, then prepend the number "0" on 

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
                    /// to instance the operations in the OwnMathLib
                    
                    AritmethicOperations aritmethicOperations = new AritmethicOperations(); 
                    CircularOperations circularOperations = new CircularOperations();   
                    ScientificOperations scientificOperations = new ScientificOperations(); 

                    
                    
                    Operations op = operations[operationChoice];

                    Console.WriteLine(op.ToString());

                    double x, y;

                    switch (op)
                    {
                        case Operations.Add :
                            
                           

                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                 x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                 y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception e) 
                            {
                                x = 0; y = 0;
                            }

                                                       
                            aritmethicOperations.x = x;
                            aritmethicOperations.y = y;
                                                     
                            Console.WriteLine("Ergebnis: " + RoundResult(aritmethicOperations.Add()));

                            break;
                        case Operations.Sub:

                            try
                            {   

                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                               
                                x = 0; y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            aritmethicOperations.x = x;
                            aritmethicOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(aritmethicOperations.Sub()));

                            break;

                        case Operations.Mul:

                            try
                            {   

                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                 x = 0; y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            aritmethicOperations.x = x;
                            aritmethicOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(aritmethicOperations.Mul()));

                            break;

                        case Operations.Div:

                            try
                            {  

                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                x = 0; y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            aritmethicOperations.x = x;
                            aritmethicOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(aritmethicOperations.Div()));
                            
                            break;

                        case Operations.Sin:

                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                                              
                            }
                            catch (Exception e)
                            {                                
                                x = 0; 

                                Console.Write("Falsche Eingabe: ");
                            }

                            circularOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(circularOperations.SinY()));

                            break;  

                        case Operations.Cos:
                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            circularOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(circularOperations.CosY()));

                            break;

                        case Operations.Tan:
                            
                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                
                            }
                            catch (Exception e)
                            {
                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            circularOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(circularOperations.TanY()));

                            break;

                        case Operations.Exp:

                            try
                            {   
                                Console.Write("Eingabe Exponent: ");
                                x = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {
                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.EPowX()));

                            break;

                        /// the Operation multiply the Product with themselve
                        
                        case Operations.Quad:

                            try
                            {   
                                Console.Write("Eingabe Exponent: ");
                                x = Convert.ToDouble(Console.ReadLine());


                            }
                            catch (Exception e)
                            {
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.Square()));

                            break;

                            /// Pow = x^y
                        
                        case Operations.Pow:

                            try
                            {   

                                Console.Write("Eingabe Basis_x: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe Exponent: ");
                                y = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {
                                x = 0;y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;
                            scientificOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.xPOWy()));

                            break;

                        case Operations.Sqrt:

                            try
                            {   

                                Console.Write("Eingabe Radikand: ");
                                x = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.SquareRoot()));

                            break;

                        case Operations.Root:

                            try
                            {   

                                Console.Write("Eingabe Radikation: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe Radikand: ");
                                y = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                                
                                x = 0; y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;
                            scientificOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.SquareRoot()));

                            break;

                            /// Fac = Fakultät
                            
                        case Operations.Fac:

                            try
                            {   
                                Console.Write("Eingabe Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + scientificOperations.NFaculty());


                            break;

                            /// Base10 = 10^x

                        case Operations.Base10:

                            try
                            {   
                                Console.Write("Eingabe Exponent: ");
                                x = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                                
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + scientificOperations.TenBasex());

                            break;

                        case Operations.Log:

                            try
                            {   

                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());


                            }
                            catch (Exception e)
                            {
                                x = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + scientificOperations.LNx());

                            break;

                            ///LogBaseY = Log10(2)

                        case Operations.LogBaseY:

                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Eingabe zweite Zahl: ");
                                y = Convert.ToDouble(Console.ReadLine());

                            }
                            catch (Exception e)
                            {                               
                                x = 0;y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;
                            scientificOperations.y = y;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.LogBaseY()));

                            break;

                            /// Ln = Logarithmus Naturalis

                        case Operations.Ln:
                            
                            try
                            {   
                                Console.Write("Eingabe erste Zahl: ");
                                x = Convert.ToDouble(Console.ReadLine());
                                                                                         
                            }
                            catch (Exception e)
                            {   
                                 x = 0; y = 0;

                                Console.Write("Falsche Eingabe: ");
                            }

                            scientificOperations.x = x;

                            Console.WriteLine("Ergebnis: " + RoundResult(scientificOperations.Log()));

                            break;
                 
                        case Operations.Exit:
                             return;
                    }
                }
                
                
            };

        }


        /// the method cutoff the numbers after 8 digits after comma   
        public static double RoundResult(double answer)
        {
            
            double offset = Math.Pow(10, 8);
            double cutOff = answer * offset;
            int rounded = (int)cutOff;
            return rounded / offset;

            
        }
       
    }
}

