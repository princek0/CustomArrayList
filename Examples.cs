using System;

namespace C_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declares an array list named 'sample'. 
            ArrayList sample = new ArrayList(new string[] {"1", "2", "3", "4"}); 
            
            // Outputs the array list.
            Console.WriteLine(sample.ToString()); 
            
            // Adds "5" to the end of the array list.
            sample.Append("5");
            Console.WriteLine(sample.ToString());
            
            // Returns True since the array list contains "1" at index 0. 
            Console.WriteLine(sample.Contains("1"));
            
            // Returns 1 since "2" is at index 1 in the array list. 
            Console.WriteLine(sample.IndexOf("2"));
            
            // Inserts "1.5" at index 1 in the array list (between items "1" and "2").
            sample.Insert("1.5", 1); 
            Console.WriteLine(sample.ToString());
            
            // Removes "1.5" from the array list which was at index 1.
            sample.RemoveAt(1); 
            Console.WriteLine(sample.ToString());
            
            // Removes "5" from the array list.
            sample.Remove("5");
            Console.WriteLine(sample.ToString());
            
            // Returns the number of items in the array list which is 4.
            Console.WriteLine(sample.Size()); 
        }
    }
}
