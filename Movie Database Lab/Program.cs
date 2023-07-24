using Circle_Objects;
using Movie_Database_Lab;
using System.Numerics;

Console.WriteLine("Welcome to the Movie Database.");

bool runProgram = true;
while (runProgram)
{
    List<Movie> newMovie = new List<Movie>()
{
    new Movie("Faster", "Action"),
    new Movie("SpaceBalls", "Comedy"),
    new Movie("Insidious", "Horror"),
    new Movie("The Fugitive", "Action"),
    new Movie("Law Abiding Citzen", "Drama"),
    new Movie("Taken", "Action"),
    new Movie("Star Wars", "Scifi"),
    new Movie("The Notebook", "Romance"),
    new Movie("DodgeBall", "Comedy"),
    new Movie("Sound of Freedom", "Drama") 
};
    
    
    
    
        Console.WriteLine("Please choose a category.");
         string input = Console.ReadLine().ToLower().Trim();

       

    
    List<Movie> group = newMovie.Where(m => m.Category.ToLower() == input).ToList();
   foreach(Movie m  in group)
    { 
        Console.WriteLine(m.Title);
    }
    
    
    

    Console.WriteLine();    
    runProgram = Validator.GetContinue("Would you like to continue?");







 



}