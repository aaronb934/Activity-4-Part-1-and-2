/*
 * Aaron Belschner
 * CST-150
 * Activity 4 Part 2
 * 9/12/25
 * This is my own work
 */

namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event handler to execute the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            // This will be considered our Main Method and our
            // goal is to keep this method clean ( no logic just calling
            // methods).
            Random rand = new Random();

            int num1 = rand.Next(1, 51), num2 = rand.Next(1, 51), num3 = rand.Next(1, 51); //sum = 0;
            double double1 = rand.NextDouble(), double2 = rand.NextDouble(), double3 = rand.NextDouble(), double4 = rand.NextDouble(), double5 = rand.NextDouble();
            string firstString = "This is test number 82.";
            string secondString = "The sky is blue today";
            // Randomizing doubles array
            double[] doubles = new double[6];
            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = rand.NextDouble();
            }
            // Randomizing boolean values
            bool bool1 = rand.Next(2) == 1;
            bool bool2 = rand.Next(2) == 1;

            // First Method Example
            SumInts(num1, num2);
            // Second Method
            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5).ToString("F2"), false);
            // Third Method
            // Already Randomized
            DisplayResults("Method 3: Sum of random ints: " + RandomInt(), false);
            // Fourth Method
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);
            // Fifth Method
            FewestChars(firstString, secondString);
            // Sixth Method
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString("F2")), false);
            // Seventh Method
            IntegerArray();
            // Eigth Method
            DisplayResults("Method 8: The two booleans are the same: " + IsBooleanEqual(bool1, bool2), false);
            // Ninth Method
            DisplayResults("Method 9: The product of the two values is: " + CalculateProduct(num1, double1).ToString("F2"), false);
        }

        /// <summary>
        /// Write a method that takes two integers and displays their sum with descriptive text.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            // Using Random to generate two ints for comparison
            // Find the sum
            int sum = num1 + num2;
            // Display needs to it's own method
            DisplayResults("Method 1: The sum of " + num1 + " and " + num2 + " = " + sum, true);
        }

        /// <summary>
        /// Find the average of the 5 doubles and then return the average
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns></returns>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            // Find the average of the 5 doubles
            // Declare and Initialize
            const double AvgDenominator = 5.0D;
            // Find and return the average of the 5 doubles
            return ((num1 + num2 + num3 + num4 + num5) / AvgDenominator);
        }

        /// <summary>
        /// Displays the string that is sent to the method
        /// Requires Descriptive text and result both in one string
        /// Third parameter is to clear the label before writing to it
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="clearLabel"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            // Only clear the label if the parameter is true
            if(clearLabel)
            {
                lblResults.Text = "";
            }
            // Display the results in the new label.
            lblResults.Text += string.Format("{0}\n", descText);
        }

        /// <summary>
        /// Returns a randomly generate int
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            // Declare and Initialize
            int num1 = 0, num2 = 0, sum = 0;
            // Get the random numbers
            // C# provides a Random class to generate random numbers
            // Instantiate random number generator create and object called rand
            // Syntax --> ClassName object/variable name = new ClassName();
            Random rand = new Random();
            // Within the Random class there are several methods that have access modifier set to Public that we can use
            // One of those methods is Next(int min, int max) that returns random number >= 1 and < 101
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            // Generate the sum and return it
            // Break this out to multiple lines so it is easier to understand
            sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Return bool true or false if the sum of the ints are divisible by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            // Find the sum
            int sum = num1 + num2 + num3;
            // is the sum divisible by 2
            if(sum % 2 == 0)
            {
                return true;
            }
            // if the sum is not divisible by 2
            // return false
            return false;
        }

        /// <summary>
        /// Write a method that takes two strings and displays the
        /// string that has the fewer letters with descriptive text
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            // Declare and Initialize
            int countChar1 = 0, countChar2 = 0, pointer = 0;
            // Itereate through the strings using a do while loop
            // exit loop when both strings have been fuly iterated through
            do
            {
                // string1 -> Try and test if the char being pointed to is a letter
                try
                {
                    // Test if char is a letter
                    if (char.IsLetter(string1[pointer]))
                    {
                        // Now we know this index contains a letter and not a number
                        countChar1++;
                    }
                }
                catch (Exception e)
                {
                    // If we are here then we know string1 is at the end of the length
                    // We do not want to do anything
                }
                // string2 -> Try and test if the char being pointed to is a letter
                try
                {
                    // Test if char is a letter
                    if (char.IsLetter(string2[pointer]))
                    {
                        // Now we know this index contains a letter and not a number
                        countChar2++;
                    }
                }
                catch (Exception e)
                {
                    // If we are here then we know string2 is at the end of the length
                    // We do not want to do anything
                }
                // Inc the pointer to point to next char
                pointer++;
            }
            while ((pointer < string1.Length) || (pointer < string2.Length));

            //Now we have the count of chars for each string
            if(countChar1 < countChar2)
            {
                DisplayResults("Method 5: string1 has fewer letters", false);
            }
            else if(countChar2 < countChar1)
            {
                DisplayResults("Method 5: string2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: Both strings have the same number of letters", false);
            }
        }


        private double LargestDouble(double[] arrDoubles)
        {
            // Declare and Initialize
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;
            // Iterate through array using while loop
            while(arrPointer < arrDoubles.Length)
            {
                // Read double from array at index of pointer
                valueAtIndex = arrDoubles[arrPointer];
                // Now test the double against biggestDouble
                // if the value we just read is larger than value
                // int biggestDouble - replace with valueAtIndex
                if(valueAtIndex > biggestDouble)
                {
                    // We just found a larger double
                    biggestDouble = valueAtIndex;
                }
                // Inc the pointer so it points to the next index
                arrPointer++;
                // Show how arrDoubles[arrPointer++] would do same
            }

            // All done so return the biggest double
            return biggestDouble;
        }

        /// <summary>
        /// Method to generate and print array of 10 integers with descriptive text
        /// </summary>
        private void IntegerArray()
        {
            // int array is created with 10 values
            int[] ints = new int[10];
            Random rand = new Random();

            // for loop to generate and print DisplayResults method to the form.
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(1, 51);
                DisplayResults("Method 7: Array value: " + ints[i], false);
            }
        }

        /// <summary>
        /// Method to take two boolean values and return true or false based on comparison
        /// </summary>
        /// <param name="bool1"></param>
        /// <param name="bool2"></param>
        /// <returns></returns>
        private bool IsBooleanEqual(bool bool1, bool bool2)
        {
            // two boolean values are passed into the method and compared. boolean returned
            return bool1 == bool2;
        }

        /// <summary>
        /// Method to multiply an int with double and return double result
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        private double CalculateProduct(int val1, double val2)
        {
            // int and double values are passed into method, mulitplied and returned as double
            return val1 * val2;
        }
    }
}
