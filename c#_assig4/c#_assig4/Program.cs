using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c__assig4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Question One

            // 1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).

            //double[] prices = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(prices[1]);

            #endregion


            #region Question Two

            // 2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            // shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.

            //int[,] shelfCopies =
            //{ { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion


            #region Question Three

            // 3-Write a method called PrintWelcomeMessage that takes no parameters and prints
            // "Welcome to the Library!". Call it from Main.

            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}



            //    PrintWelcomeMessage();


            #endregion


            #region Question Four

            // 4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            // "Clean Code".

            //static void PrintBookTitle(string title)
            //{
            //   Console.WriteLine("Book title: " + title);
            //}



            //  PrintBookTitle("Clean Code");


            #endregion


            #region Question 5

            //  Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
            // see, and why?

            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine(prices[0]); // Output: 20.5

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] = prices[0] - 5;
            //}

            #endregion


            #region Question 6

            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            // int pages = 400; and print pages afterward. What do you expect to see, and why?

            //int pages = 400;

            //AddBonusPages(pages);

            //Console.WriteLine(pages);

            //static void AddBonusPages(int pages)
            //{
            //    pages = pages + 50;
            //}

            #endregion


            #region Question Seven

            // 7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            // Call it and print pages afterward. How is the result different from question 5?

            //int pages = 400;

            //AddBonusPagesByRef(ref pages);

            //Console.WriteLine(pages);

            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages = pages + 50;
            //}

            #endregion



            #region Question 8

            // 1-Write a method bool TryGetPrice(string title, out double price) that returns
            // true and sets price to 25.5 if title is "Clean Code", otherwise returns false and
            // sets price to 0. Call it and print the price if found.

            string title = "Clean Code";

            if (TryGetPrice(title, out double price))
            {
                Console.WriteLine(price);
            }

            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                else
                {
                    price = 0;
                    return false;
                }
            }

            #endregion







        }
    }



    
    
       
        
    
   





















}


