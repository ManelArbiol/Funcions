using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project
{
    public class Validate
    {
        public static void Main()
        {
            //ValidatorIfNumberIsNatural();

            //const string InputNumbers = "Indica quants valors vols introduir";
            //int quantity;
            //Console.WriteLine(InputNumbers);
            //quantity = Convert.ToInt32(Console.ReadLine());
            //InputCorrectNumberInRange(quantity);

            /*-------------------------------------------------*/

            //3. VALIDAR UN NUMERO ASBOLUT

            //const string MSG = "Introdueix un numero";
            //int num;
            //Console.WriteLine(MSG);
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Validate.AbsoluteNumberValidator(num));

            /*------------------------------------------------*/



            //4. TEXT MAYUSCULA O MINUSCULA

            //const string MSGBUpperOrLower = "Quieres pasarlo a mayusculas o a minusculas?";
            //const string MSG = "Introduce un texto";
            //Console.WriteLine(MSG);           
            //string txt = Console.ReadLine();
            //Console.WriteLine(UpperLower(txt, true));


            /*-----------------------------------------------*/

            //5. VALIDAR SI EL UN NUMERO ES PIOSITIU I MENOR QUE 100

            //const string Num = "Introdueix un número:";
            //Console.WriteLine(Num);            
            //int num = Convert.ToInt32(Console.ReadLine());
            //PositiveNumLessThan100(num);

            /*-----------------------------------------------*/

            //6. RETORN VALOR ABSOLUT D'UN NÚMERO

            //Console.WriteLine(NumAbsolute());

            /*--------------------------------------------------*/

            //7. RETORN DE LA POTENCIA D'UN NÚMERO

            //double numResult = NumPotencia();
            //Console.WriteLine($"{numResult:N0}");


            /*-----------------------------------------------*/
            //8. IMPIRIMIR NUMEROS ALEATORIS DINTRE D'UN RANG

            //const string RandomNumstxt = "Números aleatoris generats:";
            //Console.WriteLine(RandomNumstxt);
            //int[] randomNums = RandomNumberGenerator();
            //ToConsoleWrite(randomNums);

            /*-----------------------------------------------*/

            //9.
            //const string Numinput = "Introdueix el primer número:";
            //const string Numinput2 = "Introdueix el segón número:";
            //const string Numinput3 = "Introdueix el tercer número:";
            //Console.WriteLine(Numinput);
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Numinput2);
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Numinput3);
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //ValidateNumber(num1, num2, "El número es més petit", "El número no es més petit");
            //ValidateNumber(num1, num2, num3, "El número esta dins del rang", "El número esta fora del rang");
            /*-----------------------------------------------*/

            //10
            //const string FirstNumber = "Introdueix un número:";
            //const string InList = "El numero introduit esta dins de la llista";
            //const string OutList = "El numero introduit no esta la llista";

            //Console.WriteLine(FirstNumber);
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (NumberInsideList(num) == true)
            //{
            //    Console.WriteLine(InList);
            //}
            //else
            //{
            //    Console.WriteLine(OutList);
            //}
            /*-----------------------------------------------*/
            //11
            //const string InputNumber = "Introdueix un numero per saber el factorial:";

            //Console.WriteLine(InputNumber);
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FactorialNumber(num));

            //12
            //const string InputLitres = "Introdueix els litres consumits: ";
            //const string ResultInvoice = "La factura d'aigua és: ";

            //Console.WriteLine(InputLitres);
            //double inputLitres = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(ResultInvoice + Math.Round(WaterConsumation(inputLitres), 2));

            //13
            const string inputNums = "Introdueix 6 numeros:";
            const string outputNums = "Números en les posicions impars:";
            Console.WriteLine(inputNums);
            int[] numbersToArray = new int[6];

            for (int i = 0; i < numbersToArray.Length; i++)
            {
                numbersToArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] oddNumbers = OddPosition(numbersToArray);
            Console.WriteLine(outputNums);
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }


        }
        //13
        public static int[] OddPosition(int[] inputNumbers)
        {
            int newLength = Convert.ToInt32(inputNumbers.Length / 2);
            int[] newNumbers = new int[newLength];

            int j = 0;

            for (int i = 1; i < inputNumbers.Length; i += 2)
            {
                newNumbers[j] = inputNumbers[i];
                j++;
            }

            return newNumbers;          

        }

        public static void InputCorrectNumberInRange(int quantity)
        {
            const string InputValors = "introdueix un valor entre el 5 i el 150 (inclosos). Tens 3 intents com a màxim";
            const string InputError = "El valor introduït no és vàlid.";
            int input, errors = 0;

            int[] numbers = new int[quantity];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (errors < 3)
                {
                    Console.WriteLine(InputValors);
                    input = Convert.ToInt32(Console.ReadLine());
                    if (InRange(input))
                    {
                        numbers[i] = input;
                    }

                    else
                    {
                        Console.WriteLine(InputError);
                        errors++;
                        i--;
                    }

                }
            }
            ShowOutput(errors, numbers);

        }

        public static bool InRange(int input)
        {
            return (input >= 5) && (input <= 150);

        }

        public static void ShowOutput(int errors, int[] numbers)
        {
            const string Totaltrys = "Has superat el total d'intents.";
            int answer = numbers[0];

            if (errors == 3)
            {
                Console.WriteLine(Totaltrys);
            }
            else
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    answer *= numbers[i];
                }
                Console.WriteLine(answer);
            }
        }

        //12

        public static double WaterConsumation(double inputLitres)
        {
            int statically = 6;
            double resultInvoice = statically;


            if (inputLitres <= 50)
            {
                return resultInvoice;
            }
            else if (inputLitres > 50 && inputLitres < 200)
            {
                return resultInvoice += (inputLitres - 50) * 0.1f;
            }
            else
            {
                resultInvoice += (150 * 0.1f);
                return resultInvoice += ((inputLitres - 200) * 0.3f);
            }

        }


        //1. VALIDAR SI UN NÚMERO ÉS NATURAL
        public static void ValidatorIfNumberIsNatural()
        {
            const string InputFirstNum = "Introdueix el primer número natural: ";
            const string InputSecondNum = "Introdueix el segón número natural: ";
            const string IsNatural = "És natural.";
            const string IsNotNatural = "No és natural.";
            int num1, num2;
            Console.WriteLine(InputFirstNum);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(InputSecondNum);
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate.IsPositive(num1));
            Console.WriteLine(Validate.IsPositive(num2));

            if (Validate.IsPositive(num1))
            {
                Console.WriteLine(IsNatural);
            }
            else
            {
                Console.WriteLine(IsNotNatural);
            }

        }

        //1. VALIDAR SI UN NÚMERO ÉS NATURAL
        public static bool IsPositive(int num)
        {
            return num > 0;

        }


        //3. VALIDAR UN NÉMERO ASBOLUT
        public static int AbsoluteNumberValidator(int num)
        {

            if (!IsPositive(num))
            {
                return num *= -1;
            }

            return num;

        }

        //4. TEXT MAYUSCULA O MINUSCULA
        public static string UpperLower(string text, bool upper)
        {
            return upper ? text.ToUpper() : text.ToLower();
        }

        //5. VALIDAR SI EL UN NUMERO ES PIOSITIU I MENOR QUE 100
        public static void PositiveNumLessThan100(int num)
        {
            const string PositiveNum = "El numero es positu i menor que 100";
            const string NoPositiveNum = "El numero no és positu pero si que es menor que 100 al ser negatiu";
            const string PositiveNumAndHigerThan100 = "El numero és positu pero es mayor que 100";

            if (num >= 0 && num < 100)
            {
                Console.WriteLine(PositiveNum);
            }
            else if (num >= 0 && num > 100)
            {
                Console.WriteLine(PositiveNumAndHigerThan100);
            }
            else
            {
                Console.WriteLine(NoPositiveNum);
            }


        }

        //6. RETORN VALOR ABSOLUT D'UN NÚMERO
        public static int NumAbsolute()
        {
            const string Numinput = "Introdueix un número per saber el seu valor absolut:";
            Console.WriteLine(Numinput);
            int num = Convert.ToInt32(Console.ReadLine());
            return Math.Abs(num);
        }

        //7. RETORN DE LA POTENCIA D'UN NÚMERO

        public static double NumPotencia()
        {
            const string Numinput = "Introdueix un número per saber la seva potencia:";
            const string NumPow = "Introdueix la potencia desitjada:";
            Console.WriteLine(Numinput);
            double num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumPow);
            double numPow = Convert.ToInt32(Console.ReadLine());
            return Math.Pow(num, numPow);

        }

        //8. IMPIRIMIR NUMEROS ALEATORIS DINTRE D'UN RANG
        public static int[] RandomNumberGenerator()
        {
            int[] num = new int[10];
            Random randomNums = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = randomNums.Next(0, 257);
            }

            return num;
        }
        //8. IMPIRIMIR NUMEROS ALEATORIS DINTRE D'UN RANG
        public static void ToConsoleWrite(int[] randomNums)
        {
            for (int i = 0; i < randomNums.Length; i++)
            {
                Console.WriteLine(randomNums[i]);
            }
        }

        //9
        public static bool ValidateNumber(int num1, int num2, string text1, string text2)
        {

            if (num1 < num2)
            {
                Console.WriteLine(text1);
                return true;
            }
            Console.WriteLine(text2);
            return false;
        }

        public static bool ValidateNumber(int num1, int num2, int num3, string text1, string text2)
        {
            if ((num1 >= num2) && (num1 <= num3))
            {
                Console.WriteLine(text1);
                return true;
            }
            Console.WriteLine(text2);
            return false;
        }

        //10

        public static bool NumberInsideList(int num)
        {
            int[] NumsToRandoms = new int[10];
            Random randomNums = new Random();


            for (int i = 0; i < NumsToRandoms.Length; i++)
            {
                NumsToRandoms[i] = randomNums.Next(0, 201);
                if (num == NumsToRandoms[i])
                {
                    return true;
                }
            }
            //ToConsoleWrite(NumsToRandoms);

            return false;
        }

        //11
        public static int FactorialNumber(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * FactorialNumber(num - 1);
            }
            
        }

    }
}
