using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donations are ones, fives, tens, twenties, fifties, hundreds bills
            //Need to ask user how many of each denomination are being donated and print receipt
            //Also need to ask donor name, Donor Address, Donor email, Fiscal Year, Donation amount

            //defining the variables needed
            int numberOfOnes;
            int numberOfFives;
            int numberOfTens;
            int numberOfTwenties;
            int numberOfFifties;
            int numberOfHundreds;
            int numberOfQtrs;

            string donorName;
            string donorAddress;
            string donorEmail;
            //string fiscalYear;
            double donationTotal;

            //collecting donation information from donor
            Console.WriteLine("Thank you for your donation! Please enter the number of ones:");
            numberOfOnes = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of fives:");
            numberOfFives = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of tens:");
            numberOfTens = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of twenties:");
            numberOfTwenties = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of fifties:");
            numberOfFifties = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of hundreds:");
            numberOfHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of quarters:");
            numberOfQtrs = int.Parse(Console.ReadLine());

            //collecting the donor personal information
            Console.WriteLine("Please enter your name:");
            donorName = Console.ReadLine();
            Console.WriteLine("Please enter your address:");
            donorAddress = Console.ReadLine();
            Console.WriteLine("Please enter your e-mail address:");
            donorEmail = Console.ReadLine();

            //calculating the total
            donationTotal = (numberOfQtrs * .25 + numberOfOnes * 1 + numberOfFives * 5 + numberOfTens * 10 + numberOfTwenties * 20 + numberOfFifties * 50 + numberOfHundreds * 100);

            //printing out the receipt
            Console.WriteLine("\nThank you for your donation! Please see your receipt below:");
            
            Console.WriteLine("\nDonor Name:  "+ donorName);
            Console.WriteLine("Donor Address:  " + donorAddress);
            Console.WriteLine("Donor E-mail:  " + donorEmail);
            Console.WriteLine("Donation Year 2017");
            Console.WriteLine("Donation Total:  "+ donationTotal);
            

        
        }
    }
}
