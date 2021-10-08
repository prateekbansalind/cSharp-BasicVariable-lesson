using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "\"Prateek\"";
            // use of escape character "\" (backward slash) : it's used in case if you want to print a string value along with inverted comma's.
            //the character which you want to escape, just put the backward slash before it.

            Console.WriteLine(firstName);

            string testVariable = "";
            testVariable = "\testing@123";

            Console.WriteLine(testVariable);

            //here, in the above line after the compilation when you run the program you would see "       esting@123" without the inverted commas. So be careful when use backslash especially with some of the character combination like here in this one "\t" basically prints out the tab. 


            string filePath = "C:\\users\\Temp\\T.txt";  //ugly way of doing it. as if we place backslash beside another one we bascially get rid of the escape.
            string filePath2 = @"C:\users\Temp\T.txt";
            //@ is called string literals which allows you to have \ in the string without escaping anything.
            //if we want to print out the string which has a special character and prevent the action of those being initiated we can use "@" before the string outside the inverted comma's as shown above. 
            Console.WriteLine(filePath);
            Console.WriteLine(filePath2);


            //string interpolation

            string fName = "Prateek";
            string lName = "Bansal";
            string fuName1 = "";
            string fuName2 = "";

            fuName1 = fName + " " + lName; // this is the inefficient way as it creates/takes/captures a lot of space in the memory.
            Console.WriteLine(fuName1);

            fuName2 = $"{fName} {lName}"; // correct way of doing it. - string interpolation
            Console.WriteLine(fuName2);

            //integer variable

            int a = 0;
            //int represents whole number
            //int doesn't need to be initialize as int a = 0 as if we leave int a, as default the value of a is 0 but its better to give the value to avoid confusion as like in case of string variable above we have purposely initialize the variable as string firstName = ""; in reality it just a string.empty. 

            // unsigned variable sometimes cannot take negative value which means they can only take +ve values.

            a = -100;



            // variable naming convention
            // 1. It should be in camelcase way like string fullName instead of FullName.
            //2. It wont hurt if you use the other way around but its better to use when its really required.

            // double and decimal variable type 


            double wordsTypedPerMinute = 24.42;
            decimal pricerPerContainer = 45.84M;

            // both double and decimal accepts the value which are fractional.
            // in decimal, M is necessary to put behind the decimal value. 
            // if both of these variable type serves the same function then why do we need to have both.
            //the reason is who close to they are to the precision. Decimal are more precise as compared to double.
            // important - something which is not related to  money than we can save the value in double rather than decimal as decimal are more expensive and occupies more energy.


            // boolean type variable

            bool isAlive = true;
            Console.WriteLine(isAlive);

            //bool is very important variable type in programming which is essential for loops. It can only store true or false. 


            //pro tip
            // Always read the release notes to learn how to use the new feature.

            //Details are extremely important in C#. 

            //Plan out the type of data you need before creating a variable



            //.toString method 

            int zipCode = 123456;
            Console.WriteLine(zipCode);
            //here in the above line zipCode has a method within the above brackets which is called .toString method. this method in the background change the data type and prints it. 

            //Console.WriteLine(zipCode.toString);

            //Another case if you storing a data which has a leading zero in it and you want to print it out then you need to save it in string data type. example below:

            int zipCode1 = 001234;
            Console.WriteLine(zipCode1);

            string zipCode2 = "001234";
            Console.WriteLine(zipCode2);

            //the reason is that int type don't consider leading zero in it. 


            Console.ReadLine();
        }
    }
}