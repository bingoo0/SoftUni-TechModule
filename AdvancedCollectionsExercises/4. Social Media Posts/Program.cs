﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Social_Media_Posts
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var likeDictionary = new Dictionary<string, int>();
            var dislikeDictionary = new Dictionary<string, int>();
            var commentDictionary = new Dictionary<string, List<string>>();

            while (input != "drop the media")
            {
                var commandList = input.Split(' ').ToList();
                var command = commandList[0];

                if (command == "post")
                {
                    likeDictionary[commandList[1]] = 0;
                    dislikeDictionary[commandList[1]] = 0;
                    commentDictionary[commandList[1]] = new List<string>();
                }

                if (command.Equals("like"))
                {
                    likeDictionary[commandList[1]] ++;
                }

                if (command == "dislike")
                {
                    dislikeDictionary[commandList[1]]++;
                }

                if (command.Equals("comment"))
                {
                    commentDictionary[commandList[1]].Add($"*  {commandList[2]}: {input.Substring(commandList[1].Length + commandList[2].Length + 10)}");
                }
                input = Console.ReadLine();
            } // end while

            foreach (var kvp in likeDictionary)
            {
                Console.WriteLine($"Post: {kvp.Key} | Likes: {kvp.Value} | Dislikes: {dislikeDictionary[kvp.Key]}");
                Console.WriteLine("Comments:");

                if (commentDictionary[kvp.Key].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in commentDictionary[kvp.Key])
                    {
                        Console.WriteLine(comment);
                    }
                }
            }
        }
    }
}
