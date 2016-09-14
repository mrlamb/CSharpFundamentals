using System;
using static Utils.Utils;
/***********************************
 * Mario-3
 * In the original Super Mario Brothers game at the end of nearly every level
 * Mario would scale a pyramid and jump from the top to reach a flagpole.
 *
 * This project builds on the previous example but instead of doing all the work to build
 * the pyramid in the Main method of the Program class, we are going to do some encapsulation
 * and move the bulk of the work to the Draw() method of the Pyramid class.
 * 
 * Your job is to fill in the TODO's. First you will need to get input from the user for how tall
 * the pyramid will be. You may still use the GetInt() function to do so. Note that once we get 
 * the height from the user we then store it into our instanced Pyramid object for use in our
 * draw() function.
 *
 * The second TODO is to build the Draw() method itself. I would recommend using a StringBuilder 
 * to gather all of the lines of the pyramid into one string. To add a new line to a string you can
 * use a "\n" to trigger such. (In Java you must use '\n\r' but in C#, just '\n' suffices, it won't
 * hurt your code to add the '\r' and it's a decent habit to be in.
 * 
 * Finally this program will automatically print the return from the Draw method so we can see if 
 * you did it right!
 * 
 * GOOD LUCK!
 */
namespace Mario3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pyramid = new Pyramid();
            int height = 0;

            //TODO: Capture input from the user to determin height.

            // Set the instanced pyramid object's Height property.
            pyramid.Height = height;

            //Call the method to draw the pyramid
            string output = pyramid.Draw();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
