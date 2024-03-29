﻿namespace ConsoleAppProject.Common
{
    using System;

    /// <summary>
    /// Reader class is responsible for reading from the console and return it
    /// </summary>
    /// <author>
    /// Chris Edgley
    /// </author>
    public static class Reader
    {
        /// <summary>
        /// Read from the console a string and parse it to int
        /// </summary>
        public static int ReadInteger => int.Parse(Console.ReadLine());

        /// <summary>
        /// Read from the console a string and parse it to double
        /// </summary>
        public static double ReadDouble => double.Parse(Console.ReadLine());

    }
}
