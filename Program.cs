using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalImages = 52;
            int picturesInARow = 3;
            int numberOfRows = totalImages / picturesInARow;
            int imagesStay = totalImages - picturesInARow * numberOfRows;

            Console.WriteLine("Картинок в ряду = " + numberOfRows.ToString());
            Console.WriteLine("Картинок осталось = " + imagesStay.ToString());
            Console.ReadLine();
        }
    }
}
