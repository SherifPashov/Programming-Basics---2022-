using System;

namespace _02._Letters_Combinations
 {
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();

            int wordNumber1 = 0;
            int wordNumber2 = 0;
            int wordNumber3 = 0;

            string firstWord = "";
            string secondWord = "";
            string treeWord = "";


            switch (word1)
            {
                case "a":
                    wordNumber1 = 1;
                    break;
                case "b":
                    wordNumber1 = 2;
                    break;
                case "c":
                    wordNumber1 = 3;
                    break;
                case "d":
                    wordNumber1 = 4;
                    break;
                case "e":
                    wordNumber1 = 5;
                    break;
                case "f":
                    wordNumber1 = 6;
                    break;
                case "g":
                    wordNumber1 = 7;
                    break;
                case "h":
                    wordNumber1 = 8;
                    break;
                case "i":
                    wordNumber1 = 9;
                    break;
                case "j":
                    wordNumber1 = 10;
                    break;
                case "k":
                    wordNumber1 = 11;
                    break;
                case "l":
                    wordNumber1 = 12;
                    break;
                case "m":
                    wordNumber1 = 13;
                    break;
                case "n":
                    wordNumber1 = 14;
                    break;
                case "o":
                    wordNumber1 = 15;
                    break;
                case "p":
                    wordNumber1 = 16;
                    break;
                case "q":
                    wordNumber1 = 17;
                    break;
                case "r":
                    wordNumber1 = 18;
                    break;
                case "s":
                    wordNumber1 = 19;
                    break;
                case "u":
                    wordNumber1 = 20;
                    break;
                case "t":
                    wordNumber1 = 21;
                    break;
                case "v":
                    wordNumber1 = 22;
                    break;
                case "w":
                    wordNumber1 = 23;
                    break;
                case "x":
                    wordNumber1 = 24;
                    break;
                case "y":
                    wordNumber1 = 25;
                    break;
                case "z":
                    wordNumber1 = 26;
                    break;

            }
            switch (word2)
            {
                case "a":
                    wordNumber2 = 1;
                    break;
                case "b":
                    wordNumber2 = 2;
                    break;
                case "c":
                    wordNumber2 = 3;
                    break;
                case "d":
                    wordNumber2 = 4;
                    break;
                case "e":
                    wordNumber2 = 5;
                    break;
                case "f":
                    wordNumber2 = 6;
                    break;
                case "g":
                    wordNumber2 = 7;
                    break;
                case "h":
                    wordNumber2 = 8;
                    break;
                case "i":
                    wordNumber2 = 9;
                    break;
                case "j":
                    wordNumber2 = 10;
                    break;
                case "k":
                    wordNumber2 = 11;
                    break;
                case "l":
                    wordNumber2 = 12;
                    break;
                case "m":
                    wordNumber2 = 13;
                    break;
                case "n":
                    wordNumber2 = 14;
                    break;
                case "o":
                    wordNumber2 = 15;
                    break;
                case "p":
                    wordNumber2 = 16;
                    break;
                case "q":
                    wordNumber2 = 17;
                    break;
                case "r":
                    wordNumber2 = 18;
                    break;
                case "s":
                    wordNumber2 = 19;
                    break;
                case "u":
                    wordNumber2 = 20;
                    break;
                case "t":
                    wordNumber2 = 21;
                    break;
                case "v":
                    wordNumber2 = 22;
                    break;
                case "w":
                    wordNumber2 = 23;
                    break;
                case "x":
                    wordNumber2 = 24;
                    break;
                case "y":
                    wordNumber2 = 25;
                    break;
                case "z":
                    wordNumber2 = 26;
                    break;
                    
            }
            switch (word3)
            {
                case "a":
                    wordNumber3 = 1;
                    break;
                case "b":
                    wordNumber3 = 2;
                    break;
                case "c":
                    wordNumber3 = 3;
                    break;
                case "d":
                    wordNumber3 = 4;
                    break;
                case "e":
                    wordNumber3 = 5;
                    break;
                case "f":
                    wordNumber3 = 6;
                    break;
                case "g":
                    wordNumber3 = 7;
                    break;
                case "h":
                    wordNumber3 = 8;
                    break;
                case "i":
                    wordNumber3 = 9;
                    break;
                case "j":
                    wordNumber3 = 10;
                    break;
                case "k":
                    wordNumber3 = 11;
                    break;
                case "l":
                    wordNumber3 = 12;
                    break;
                case "m":
                    wordNumber3 = 13;
                    break;
                case "n":
                    wordNumber3 = 14;
                    break;
                case "o":
                    wordNumber3 = 15;
                    break;
                case "p":
                    wordNumber3 = 16;
                    break;
                case "q":
                    wordNumber3 = 17;
                    break;
                case "r":
                    wordNumber3 = 18;
                    break;
                case "s":
                    wordNumber3 = 19;
                    break;
                case "u":
                    wordNumber3 = 20;
                    break;
                case "t":
                    wordNumber3 = 21;
                    break;
                case "v":
                    wordNumber3 = 22;
                    break;
                case "w":
                    wordNumber3 = 23;
                    break;
                case "x":
                    wordNumber3 = 24;
                    break;
                case "y":
                    wordNumber3 = 25;
                    break;
                case "z":
                    wordNumber3 = 26;
                    break;
                   
                      
            }

            for (int first = wordNumber1; first <= wordNumber2; first++)
            {
                if (first == wordNumber3)
                {
                    continue;
                }
                switch (first)
                {
                    case 1:
                        firstWord = "a";
                        break;
                    case 2:
                        firstWord = "b";
                        break;
                    case 3:
                        firstWord = "c";
                        break;
                    case 4:
                        firstWord = "d";
                        break;
                    case 5:
                        firstWord = "e";
                        break;
                    case 6:
                        firstWord = "f";
                        break;
                    case 7:
                        firstWord = "g";
                        break;
                    case 8:
                        firstWord = "h";
                        break;
                    case 9:
                        firstWord = "i";
                        break;
                    case 10:
                        firstWord = "j";
                        break;
                    case 11:
                        firstWord = "k";
                        break;
                    case 12:
                        firstWord = "l";
                        break;
                    case 13:
                        firstWord = "m";
                        break;
                    case 14:
                        firstWord = "n";
                        break;
                    case 15:
                        firstWord = "o";
                        break;
                    case 16:
                        firstWord = "p";
                        break;
                    case 17:
                        firstWord = "q";
                        break;
                    case 18:
                        firstWord = "r";
                        break;
                    case 19:
                        firstWord = "s";
                        break;
                    case 20:
                        firstWord = "t";
                        break;
                    case 21:
                        firstWord = "u";
                        break;
                    case 22:
                        firstWord = "v";
                        break;
                    case 23:
                        firstWord = "w";
                        break;
                    case 24:
                        firstWord = "x";
                        break;
                    case 25:
                        firstWord = "y";
                        break;
                    case 26:
                        firstWord = "z";
                        break;
                        


                           

                }
                for (int second = wordNumber1; second <= wordNumber2; second++)
                {
                    if (first == wordNumber3)
                    {
                        continue;
                    }

                    
                        switch(second)
                        { 
                            case 1:
                                secondWord = "a";
                                break;
                            case 2:
                                secondWord = "b";
                                break;
                            case 3:
                                secondWord = "c";
                                break;
                            case 4:
                                secondWord = "d";
                                break;
                            case 5:
                                secondWord = "e";
                                break;
                            case 6:
                                secondWord = "f";
                                break;
                            case 7:
                                secondWord = "g";
                                break;
                            case 8:
                                secondWord = "h";
                                break;
                            case 9:
                                secondWord = "i";
                                break;
                            case 10:
                                secondWord = "j";
                                break;
                            case 11:
                                secondWord = "k";
                                break;
                            case 12:
                                secondWord = "l";
                                break;
                            case 13:
                                secondWord = "m";
                                break;
                            case 14:
                                secondWord = "n";
                                break;
                            case 15:
                                secondWord = "o";
                                break;
                            case 16:
                                secondWord = "p";
                                break;
                            case 17:
                                secondWord = "q";
                                break;
                            case 18:
                                secondWord = "r";
                                break;
                            case 19:
                                secondWord = "s";
                                break;
                            case 20:
                                secondWord = "t";
                                break;
                            case 21:
                                secondWord = "u";
                                break;
                            case 22:
                                secondWord = "v";
                                break;
                            case 23:
                                secondWord = "w";
                                break;
                            case 24:
                                secondWord = "x";
                                break;
                            case 25:
                                secondWord = "y";
                                break;
                            case 26:
                                secondWord = "z";
                                break;
                        }

                        for (int tree = wordNumber1; tree <= wordNumber2; tree++)
                        {
                            if (first == wordNumber3)
                            {
                                continue;
                            }
                            switch (tree)
                            {
                                case 1:
                                    treeWord = "a";
                                    break;
                                case 2:
                                    treeWord = "b";
                                    break;
                                case 3:
                                    treeWord = "c";
                                    break;
                                case 4:
                                    treeWord = "d";
                                    break;
                                case 5:
                                    treeWord = "e";
                                    break;
                                case 6:
                                    treeWord = "f";
                                    break;
                                case 7:
                                    treeWord = "g";
                                    break;
                                case 8:
                                    treeWord = "h";
                                    break;
                                case 9:
                                    treeWord = "i";
                                    break;
                                case 10:
                                    treeWord = "j";
                                    break;
                                case 11:
                                    treeWord = "k";
                                    break;
                                case 12:
                                    treeWord = "l";
                                    break;
                                case 13:
                                    treeWord = "m";
                                    break;
                                case 14:
                                    treeWord = "n";
                                    break;
                                case 15:
                                    treeWord = "o";
                                    break;
                                case 16:
                                    treeWord = "p";
                                    break;
                                case 17:
                                    treeWord = "q";
                                    break;
                                case 18:
                                    treeWord = "r";
                                    break;
                                case 19:
                                    treeWord = "s";
                                    break;
                                case 20:
                                    treeWord = "t";
                                    break;
                                case 21:
                                    treeWord = "u";
                                    break;
                                case 22:
                                    treeWord = "v";
                                    break;
                                case 23:
                                    treeWord = "w";
                                    break;
                                case 24:
                                    treeWord = "x";
                                    break;
                                case 25:
                                    treeWord = "y";
                                    break;
                                case 26:
                                    treeWord = "z";
                                    break;

                            }
                            Console.WriteLine($"{wordNumber1}{wordNumber2}{wordNumber3}");
                        }
                }

            } 
        }

    }
 }
