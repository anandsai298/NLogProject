// See https://aka.ms/new-console-template for more information
using NLogProject;
using System;
namespace LineComputation
{
    class program
    {
        static void Main(String[] args)
        {
            Addition addition = new Addition();
            addition.sum(0, 10);
        }
    }
}
