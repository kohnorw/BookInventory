using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


// Chapters Book Store Inventory
// By Kohnor Wrzosek & Lucas Charette

namespace BookStoreInventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int Number = 0;

            int size = 0;

            List<string> authors = new List<string>(100);
            List<string> booktitle = new List<string>(100);

            do {

                do
                {

                    Console.WriteLine("Chapters Book Store Inventory:");

                    Console.WriteLine("");

                    Console.WriteLine("1. Add Book");

                    Console.WriteLine("");

                    Console.WriteLine("2. View Books");

                    Console.WriteLine("");

                    Console.WriteLine("3. Delete Book");

                    Console.WriteLine("");

                    Console.WriteLine("4. Exit");

                    Console.WriteLine("");

                    Console.Write("Please Enter a Number from 1-4: ");

                    // Main Menu

                    try
                    {
                        Number = Convert.ToInt32(Console.ReadLine());
                        // Used Convert.ToInt32 because it's a int number


                        if (Number > 4 || Number == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            // Adds Color Red and White to text

                            Console.WriteLine("");
                            Console.WriteLine("Invalid Input! Please Enter a Number from 1-4");
                            Console.WriteLine("");
                            Console.ResetColor();
                        }

                        // If statement makes sure that the user enters a number from 1-4.


                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        // Adds Color Red and White to text

                        Console.WriteLine("");
                        Console.WriteLine("Invalid Input! Please Enter a Number Only");
                        Console.WriteLine("");
                        Console.ResetColor();
                    }


                    // Try Catch watches for a letter input and displays an error and for the user to input a number only.

                    


                } while (Number > 4 || Number == 0);


             
                switch (Number)
                {

                    case 1:

                        string bookTitle = null;
                        string author = null;
                        bool pass = false;



                            Console.WriteLine(""); ;
                            Console.Write("Please Input an Book Title: ");
                            bookTitle = Console.ReadLine();


                            booktitle.Add(bookTitle);
                            size++; // Creates the list count and adds +1 each time.


                        // Book Title




                        do {
                            Console.WriteLine("");;
                            Console.Write("Please Input an Author: ");
                            author = Console.ReadLine();


                            if (Regex.IsMatch(author, @"^[\s*\p{L}]+$"))
                                // Makes sure the input is letter only for the author
                            {
                                authors.Add(author);
                                pass = true;
                                // if pass = true, that means the author input was all letters
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                // Adds Color Red and White to text
                                Console.WriteLine("");
                                Console.Write("Invalid Input! Please type an author name only.");
                                Console.ResetColor();
                            }
                            Console.WriteLine("");

                        } while (pass == false);

                        // Author

                        break;

                    case 2:
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        
                        Console.WriteLine("Book Inventory");

                        Console.WriteLine("");
                        

                        string table = String.Format("{0,-15}{1,-20}{2}","Number:","Book Title:", "Author:");

                        Console.WriteLine(table);

                        for (int index = 0; index < size; index++)
                        {
                            Console.WriteLine("{0,-15}{1,-20}{2}", index+1+". ",booktitle[index], authors[index]);
                        }

                        // For loop writes the list - Found by Lucas.

                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.ResetColor();

                        break;


                    case 3:

                        int bookNum = 0;
                        bool exit = false;
                        

                        do
                        {
                           

                            if (size == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("");
                                Console.WriteLine("No books to delete.");
                                exit = true;
                                Console.WriteLine("");
                                Console.ResetColor();
                            }
                            else
                            {
                                do
                                {

                                    try
                                    {
                                        Console.WriteLine("");
                                        Console.Write("Please Input the book number to delete: ");
                                        bookNum = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("");

                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("");
                                        Console.Write("Invalid Input! Please Input a valid number.");
                                        Console.WriteLine("");
                                    }

                                } while (bookNum == 0 || bookNum > size);

                                // Do-while and Try-Catch makes sure the input is valid and not 0 or over the size of the list.



                                if (bookNum < size || bookNum == size || bookNum != 0)
                                {
                                    bookNum--;
                                    // -1 from bookNum

                                    booktitle.RemoveAt(bookNum);
                                    authors.RemoveAt(bookNum);
                                    size--;
                                    // Removes the book entry and -1 from size.

                                    exit = true;
                                    // exits the do-while because exit is true.
                                }

                            }


                        } while (exit == false);



                        break;
                }

                // Switch Statement for Program. Where all the magic happens

            }


            while (Number != 4);

            // Main do while for exiting the program

            Console.WriteLine("");
            Console.WriteLine("Have a great day!");


        }
    }
}
