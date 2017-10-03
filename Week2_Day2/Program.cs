using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS
            // for loops use "for"
            // for loops are designed for counting from one number to another number
            // keep track of it
            // i for iterator, i is just common practice
            // i++ means going up by 1, it increases it by 1 every iteration

            //for(int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <=100; counter++) //+= 2 
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Big Raz";
            //string[] words = greeting.Split(); //Split makes a string into an array like this 
            ////Use split instead of making an entire array
            ////string[] words = { "My", "name", "is", "raz" };

            ////now we add in a loop

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //string days = "Monday Tuesday Wednesday";
            //string[] weekDays = days.Split();
            //for (int i = 0; i < weekDays.Length; i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}


            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] artists = { "Future", "Lil Uzi Vert", "Travis Scott", "The Weeknd", "Playboi Carti" };

            //foreach (string artist in artists)
            //{
            //    Console.WriteLine(artist);
            //}

            //string[] favFoods = { "pizza", "french fry", "burger", "stuffed cabbage" };
            //foreach(string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            int[] luckyNum = { 3, 7, 21, 13, 15 };
            foreach(int num in luckyNum)
            {
                Console.WriteLine("Your lucky number is " + num);
            }








        }
    }
}
