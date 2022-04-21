using SoftwareDesignPatterns.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Test patterns here
/// Find all patterns at: https://www.dofactory.com/net
/// </summary>

namespace SoftwareDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Composite
            //create root
            Directory root = new Directory("root");

            //create folders
            Directory folderMovies = new Directory("movies");
            Directory folderSeries = new Directory("series");

            //add folders to root
            root.Add(folderMovies);
            root.Add(folderSeries);

            //add movies to the movies-folder
            folderMovies.Add(new FileItem("Bat Man: The Dark Knight", 1200000));
            folderMovies.Add(new FileItem("American Psycho", 2400000));

            //add series to the series-folder
            folderSeries.Add(new FileItem("How i met your mother", 400000));
            folderSeries.Add(new FileItem("The Big Bang Theory", 400000));

            //add subdirectory
            Directory folderHorrorMovies = new Directory("horror movies");
            folderHorrorMovies.Add(new FileItem("Shining", 180000));
            folderHorrorMovies.Add(new FileItem("The Conjuring", 180000));

            //add subdirectory(horror movies) to major directory(folderMovies)
            folderMovies.Add(folderHorrorMovies);

            

            #endregion



            Console.ReadLine();
        }
    }
}
