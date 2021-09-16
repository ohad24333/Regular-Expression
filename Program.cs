using System;
using System.Text.RegularExpressions;

namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {


            var starts_With_D_Regex = new Regex(@"^D");    //Question 1                  
            var starts_With_DFI_Regex = new Regex(@"^[DFI]\d{6}_[A-Z]{2}");  //Question 2,3  
             
            // Question 4  
            Console.WriteLine("Enter A Word:");
            string word = Console.ReadLine();
            Console.WriteLine(Regex.Replace(word, @"yyy|זזזז"," "));
        

            var starts_With_Capital_Regex = new Regex(@"[A-Z]");  //Question 5 
            var regexABCtWord = new Regex(@"ABC|abc"); //Question 6  
            var isFullValidNameRegEx = new Regex(@"\D{2,18} \D{2,18}"); //Question 7  
            var isDecimalNumberRegex = new Regex(@"\d*\.\d*"); //Question 8 
            var isThreeNumberAfterDotDecimalNumberRegex = new Regex(@"\d*\.\d{3} ");  //Question 9  

            var isValidEmail = new Regex(@"^[A-z]{3,7}\w{0,7}(\@gmail|\@yahoo)\.(net|com)",RegexOptions.IgnoreCase); //Question 10 

            var urlRx = new Regex(@"^(http|http(s)|www?://)?([\w-]+\.)+[\w-]+\.co\.il+(\[\?%&=]*)?" , RegexOptions.IgnoreCase);  //Question 11 


        }

        
    }
}
