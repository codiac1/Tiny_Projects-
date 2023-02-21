using System.IO;
using System;

class AcronymGenerator
{
    static void Main()
    {
        try {
            Console.WriteLine("Enter a phase to generate Acronym : ");
            String input = Console.ReadLine();
            // replace every "and" with an empty charcter and split the words
            String exclude = input.Replace("and" , "");
            String[] inputArr = exclude.Split(' ');
            String acronym = "";

            for(int i = 0; i < inputArr.Length; i++) {
                if (inputArr[i] != "")
                    acronym += inputArr[i][0];
            }
            acronym = acronym.ToUpper();
            Console.WriteLine("Your acronym is : " + acronym);
        } catch(Exception e) {
            Console.WriteLine(e.ToString());
        }
    }
}