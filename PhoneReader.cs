using System;
using System.Collections;

namespace Practice_4._3
{
    class PhoneReader
    {
        static void Main(string[] args)
        {
            Hashtable lookupD = new Hashtable();
            Hashtable lookupDD = new Hashtable();
            Hashtable lookupDDD = new Hashtable();
            Hashtable lookup1D = new Hashtable();

            lookupD["1"] = "один";
            lookupD["2"] = "два";
            lookupD["3"] = "три";
            lookupD["4"] = "четыре";
            lookupD["5"] = "пять";
            lookupD["6"] = "шесть";
            lookupD["7"] = "семь";
            lookupD["8"] = "восемь";
            lookupD["9"] = "девять";

            lookupDD["2"] = "двадцать";
            lookupDD["3"] = "тридцать";
            lookupDD["4"] = "сорок";
            lookupDD["5"] = "пятьдесят";
            lookupDD["6"] = "шестьдесят";
            lookupDD["7"] = "семьдесят";
            lookupDD["8"] = "восемьдесят";
            lookupDD["9"] = "девяносто";

            lookupDDD["0"] = "ноль";
            lookupDDD["1"] = "сто";
            lookupDDD["2"] = "двести";
            lookupDDD["3"] = "триста";
            lookupDDD["4"] = "четыреста";
            lookupDDD["5"] = "пятьсот";
            lookupDDD["6"] = "шестьсот";
            lookupDDD["7"] = "семьсот";
            lookupDDD["8"] = "восемьсот";
            lookupDDD["9"] = "девятьсот";

            lookup1D["0"] = "десять";
            lookup1D["1"] = "одиннадцать";
            lookup1D["2"] = "двенадцать";
            lookup1D["3"] = "тринадцать";
            lookup1D["4"] = "четырнадцать";
            lookup1D["5"] = "пятнадцать";
            lookup1D["6"] = "шестнадцать";
            lookup1D["7"] = "семнадцать";
            lookup1D["8"] = "восемнадцать";
            lookup1D["9"] = "девятнадцать";

            string ourNumber;
            Console.Write("Введите номер телефона > ");
            ourNumber = Console.ReadLine();
            int pos = 0;
            int tmp = 0;

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (digit == "+")
                {
                    pos--;
                    Console.Write("плюс ");
                }
                if ((pos == 200) && (digit == "0"))
                {
                    Console.Write("ноль ");
                    continue;
                }
                else if (pos == 200)
                {
                    pos = tmp;
                }

                if ((pos == 300) && (digit == "0"))
                {
                    Console.Write("ноль ");
                    pos = 301;
                    continue;
                }
                else if (pos == 300) pos = tmp;

                if ((pos == 301) && (digit == "0"))
                {
                    Console.Write("ноль ");
                    pos = tmp + 2;
                    continue;
                }
                else if (pos == 301) pos = ++tmp;

                switch (pos++)
                {
                    case 1:
                    case 4:
                        if (lookupDDD.ContainsKey(digit))
                        {
                            Console.Write(lookupDDD[digit]);
                            Console.Write(" ");
                        }
                        if (digit == "0")
                        {
                            tmp = pos;
                            pos = 300;
                        }
                        break;
                    case 2:
                    case 5:
                        if (lookupDD.ContainsKey(digit))
                        {
                            Console.Write(lookupDD[digit]);
                            Console.Write(" ");
                        }
                        else
                        if (digit == "1")
                        {
                            tmp = pos;
                            pos = 100;
                        }
                        break;
                    case 7:
                    case 9:
                        if (lookupDD.ContainsKey(digit))
                        {
                            Console.Write(lookupDD[digit]);
                            Console.Write(" ");
                        }
                        else
                        if (digit == "0")
                        {
                            Console.Write("ноль ");
                            tmp = pos;
                            pos = 200;
                        }
                        else
                        if (digit == "1")
                        {
                            tmp = pos;
                            pos = 100;
                        }
                        break;
                    case 0:
                    case 3:
                    case 6:
                    case 8:
                    case 10:
                        if (lookupD.ContainsKey(digit))
                        {
                            Console.Write(lookupD[digit]);
                            Console.Write(" ");
                        }
                        break;
                    case 100:
                        if (lookup1D.ContainsKey(digit))
                        {
                            Console.Write(lookup1D[digit]);
                            Console.Write(" ");
                        }
                        pos = tmp + 1;
                        break;
                }

            }
        }
    }
}
