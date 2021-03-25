using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_9_Josiah_Sarles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//SeedData.cs provides the logic for populating the database initially, if needed. 

namespace Assignment_9_Josiah_Sarles.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            MoviesDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<MoviesDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(

                    //Contains all the movies from the google sheet collection
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Avengers, The",
                        year = 2012,
                        director = "Joss Whedon",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Batman",
                        year = 1989,
                        director = "Tim Burton",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Batman & Robin",
                        year = 1997,
                        director = "Joel Schumacher",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Batman Begins",
                        year = 2005,
                        director = "Christopher Nolan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Batman Forever",
                        year = 1995,
                        director = "Joel Schumacher",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Batman Returns",
                        year = 1992,
                        director = "Tim Burton",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Boondock Saints, The",
                        year = 1999,
                        director = "Troy Duffy",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Dark Knight Rises, The",
                        year = 2012,
                        director = "Christopher Nolan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Dark Knight, The",
                        year = 2008,
                        director = "Christopher Nolan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Die Hard",
                        year = 1988,
                        director = "John McTiernull",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "District 9",
                        year = 2009,
                        director = "Neill Blomkamp",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "The Fugitive",
                        year = 1993,
                        director = "Andrew Davis",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Chamber of Secrets",
                        year = 2002,
                        director = "Chris Columbus",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Deathly Hallows – Part 1",
                        year = 2010,
                        director = "David Yates",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Deathly Hallows – Part 2",
                        year = 2011,
                        director = "David Yates",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Goblet of Fire",
                        year = 2005,
                        director = "Mike Newell",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Half-Blood Prince",
                        year = 2009,
                        director = "David Yates",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Order of the Phoenix",
                        year = 2007,
                        director = "David Yates",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Prisoner of Azkaban",
                        year = 2004,
                        director = "Alfonso Cuarón",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Harry Potter and the Sorcerer's Stone",
                        year = 2001,
                        director = "Chris Columbus",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Incredible Hulk, The",
                        year = 2008,
                        director = "Louis Leterrier",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Independence Day",
                        year = 1996,
                        director = "Roland Emmerich",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Indiana Jones and the Last Crusade",
                        year = 1989,
                        director = "Steven Spielberg",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Indiana Jones and the Raiders of the Lost Ark",
                        year = 1981,
                        director = "Steven Spielberg",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Indiana Jones and the Temple of Doom",
                        year = 1984,
                        director = "Steven Spielberg",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Iron Man",
                        year = 2008,
                        director = "Jon Favreau",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Italian Job, The",
                        year = 2003,
                        director = "F. Gary Gray",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Jurassic Park",
                        year = 1993,
                        director = "Steven Spielberg",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Kick-@$$",
                        year = 2010,
                        director = "Matthew Vaughn",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Ladyhawke",
                        year = 1985,
                        director = "Richard Donner",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Live Die Repeat: Edge of Tomorrow",
                        year = 2014,
                        director = "Doug Liman",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Lock, Stock and Two Smoking Barrels",
                        year = 1999,
                        director = "Guy Ritchie",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Lord of the Rings: The Fellowship of the Ring",
                        year = 2001,
                        director = "Peter Jackson",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Lord of the Rings: The Return of the King, The",
                        year = 2003,
                        director = "Peter Jackson",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Lord of the Rings: The Two Towers, The",
                        year = 2002,
                        director = "Peter Jackson",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Lucky Number Slevin",
                        year = 2006,
                        director = "Paul McGuigan",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Mask of Zorro, The",
                        year = 1998,
                        director = "Martin Campbell",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Matrix, The",
                        year = 1999,
                        director = "The Wachowski Brothers",
                        rating = "R",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Mission: Impossible",
                        year = 1996,
                        director = "Brian De Palma",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Mission: Impossible II",
                        year = 2000,
                        director = "John Woo",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Mission: Impossible III",
                        year = 2006,
                        director = "J.J. Abrams ",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Mr. & Mrs. Smith",
                        year = 2005,
                        director = "Doug Liman",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Ocean's Eleven",
                        year = 2001,
                        director = "Steven Soderbergh",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Phone Booth",
                        year = 2003,
                        director = "Joel Schumacher",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                        year = 2003,
                        director = "Gore Verbinski",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Predator",
                        year = 1987,
                        director = "John McTiernull",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Rocketeer, The",
                        year = 1991,
                        director = "Joe Johnston",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Serenity",
                        year = 2005,
                        director = "Joss Whedon",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Snatch",
                        year = 2001,
                        director = "Guy Ritchie",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Sneakers",
                        year = 1992,
                        director = "Phil Alden Robinson",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Spider-Man",
                        year = 2002,
                        director = "Sam Raimi",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Spider-Man 2",
                        year = 2004,
                        director = "Sam Raimi",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Spider-Man: Into the Spider-Verse",
                        year = 2018,
                        director = "Peter Ramsey, Bob Persichetti, Rodney Rothman",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode I: The Phantom Menace",
                        year = 1999,
                        director = "George Lucas",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode II: Attack of the Clones",
                        year = 2002,
                        director = "George Lucas",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode III: Revenge of the Sith",
                        year = 2005,
                        director = "George Lucas",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode IV: A New Hope",
                        year = 1977,
                        director = "George Lucas",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode V: The Empire Strikes Back",
                        year = 1980,
                        director = " Irvin Kershner",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Star Wars Episode VI: Return of the Jedi",
                        year = 1983,
                        director = "Richard Marquand",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Superman II",
                        year = 1980,
                        director = "Richard Lester",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Superman III",
                        year = 1983,
                        director = "Richard Lester",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Superman IV: The Quest for Peace",
                        year = 1987,
                        director = "Sidney J. Furie",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Superman: The Movie",
                        year = 1978,
                        director = "Richard Donner",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Terminator 2: Judgment Day",
                        year = 1991,
                        director = "James Cameron",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Watchmen",
                        year = 2009,
                        director = "Zack Snyder",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "X-Men",
                        year = 2000,
                        director = "Bryan Singer",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "X-Men: The Last Stand",
                        year = 2006,
                        director = "Brett Ratner ",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "X2",
                        year = 2003,
                        director = "Bryan Singer",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Action/Adventure",
                        title = "Young Guns",
                        year = 1988,
                        director = "Christopher Cain",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Ace Ventura: Pet Detective",
                        year = 1994,
                        director = "Tom Shadyac",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Amélie",
                        year = 2001,
                        director = "Jean-Pierre Jeunet",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Anchorman: The Legend of Ron Burgundy",
                        year = 2004,
                        director = "Adam McKay",
                        rating = "PG-13",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Back to the Future",
                        year = 1985,
                        director = "Robert Zemeckis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Back to the Future Part II",
                        year = 1989,
                        director = "Robert Zemeckis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Back to the Future Part III",
                        year = 1990,
                        director = "Robert Zemeckis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Barefoot in the Park",
                        year = 1967,
                        director = "Gene Saks",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Beetlejuice",
                        year = 1988,
                        director = "Tim Burton",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Best In Show",
                        year = 2000,
                        director = "Christopher Guest",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Better Off Dead",
                        year = 1985,
                        director = "Savage Steve Holland",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Bill & Ted's Bogus Journey",
                        year = 1991,
                        director = "Peter Hewitt",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Big",
                        year = 1988,
                        director = "Penny Marshall",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Bill & Ted's Excellent Adventure",
                        year = 1989,
                        director = "Stephen Herek",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Brian Regan: I Walked on the Moon",
                        year = 2004,
                        director = "John Brenkus",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Bridesmaids",
                        year = 2011,
                        director = "Paul Feig",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Bruce Almighty",
                        year = 2003,
                        director = "Tom Shadyac",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Buster Keaton Collection",
                        year = 1920,
                        director = "Buster Keaton",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Clue",
                        year = 1985,
                        director = "Jonathan Lynn",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
                        year = 1964,
                        director = "Stanley Kubrick",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Dream Team, The",
                        year = 1989,
                        director = "Howard Zieff",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Dumb & Dumber",
                        year = 1994,
                        director = "The Farrelly Brothers",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Ferris Bueller’s Day Off",
                        year = 1986,
                        director = "John Hughes",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Fletch",
                        year = 1985,
                        director = "Michael Ritchie",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Fletch Lives",
                        year = 1989,
                        director = "Michael Ritchie",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "General, The",
                        year = 1927,
                        director = "Buster Keaton",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Ghostbusters",
                        year = 1984,
                        director = "Ivan Reitman",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Gremlins",
                        year = 1984,
                        director = "Joe Dante",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Gremlins 2: The New Batch",
                        year = 1990,
                        director = "Joe Dante",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Groundhog Day",
                        year = 1993,
                        director = "Harold Ramis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Hitch",
                        year = 2005,
                        director = "Andy Tennullt",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Hot Fuzz",
                        year = 2007,
                        director = "Edgar Wright",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Hot Shots!",
                        year = 1991,
                        director = "Jim Abrahams",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Hudsucker Proxy, The",
                        year = 1994,
                        director = "Joel Coen, Ethan Coen",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "I Love You, Man",
                        year = 2009,
                        director = "John Hamburg",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Innerspace",
                        year = 1987,
                        director = "Joe Dante",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Josie and the Pussycats",
                        year = 2001,
                        director = "Harry Elfont, Deborah Kaplan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Kid, The",
                        year = 1921,
                        director = "Charlie Chaplin",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "King of Kong: A Fistful of Quarters, The",
                        year = 2007,
                        director = "Seth Gordon",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Kung Fu Hustle",
                        year = 2005,
                        director = "Stephen Chow",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Kung Pow! Enter the Fist",
                        year = 2001,
                        director = "Steve Oedekerk",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Love Actually",
                        year = 2003,
                        director = "Richard Curtis",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Mask, The",
                        year = 1994,
                        director = "Chuck Russell",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Matador, The",
                        year = 2005,
                        director = "Richard Shepard",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Maverick",
                        year = 1994,
                        director = "Richard Donner",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Mighty Wind, A",
                        year = 2003,
                        director = "Christopher Guest",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Monty Python and the Holy Grail",
                        year = 1975,
                        director = "Terry Gilliam, Terry Jones",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Mrs. Doubtfire",
                        year = 1993,
                        director = "Chris Columbus",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "My Big Fat Greek Wedding",
                        year = 2002,
                        director = "Joel Zwick",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Mystery Men",
                        year = 1999,
                        director = "Kinka Usher",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Mystery Science Theater 3000: The Movie",
                        year = 1996,
                        director = "Jim Mallon",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Naked Gun 2½: The Smell of Fear, The",
                        year = 1991,
                        director = "David Zucker",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Naked Gun: From the Files of Police Squad!, The",
                        year = 1988,
                        director = "David Zucker",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Napoleon Dynamite",
                        year = 2004,
                        director = "Jared Hess",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "National Lampoon’s Loaded Weapon 1",
                        year = 1993,
                        director = "Gene Quintano",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Opportunity Knocks",
                        year = 1990,
                        director = "Donald Petrie",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Oscar",
                        year = 1991,
                        director = "John Landis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Planes, Trains and Automobiles",
                        year = 1987,
                        director = "John Hughes",
                        rating = "R",
                        edited = "Yes",
                        lent = "Dave",
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Pyromaniac’s Love Story, A",
                        year = 1995,
                        director = "Joshua Brand",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Raising Arizona",
                        year = 1987,
                        director = "Joel Coen, Ethan Coen",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Royal Tenenbaums, The",
                        year = 2001,
                        director = "Wes Anderson",
                        rating = "R",
                        edited = "Yes",
                        lent = "Dave",
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Say Anything",
                        year = 1989,
                        director = "Cameron Crowe",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "School of Rock",
                        year = 2003,
                        director = "Richard Linklater",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Serendipity",
                        year = 2001,
                        director = "Peter Chelsom",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "So I Married An Axe Murderer",
                        year = 1993,
                        director = "Thomas Schlamme",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Spies Like Us",
                        year = 1985,
                        director = "John Landis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Steamboat Bill, Jr.",
                        year = 1928,
                        director = "Buster Keaton",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Supersize Me",
                        year = 2004,
                        director = "Morgan Spurlock",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Sweet Home Alabama",
                        year = 2002,
                        director = "Andy Tennullt",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Team America: World Police",
                        year = 2004,
                        director = "Trey Parker",
                        rating = "R",
                        edited = "Yes",
                        lent = "Dave",
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Three Amigos",
                        year = 1986,
                        director = "John Landis",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Tillie’s Punctured Romance",
                        year = 1914,
                        director = "Mack Sennett",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Tommy Boy",
                        year = 1995,
                        director = "Peter Segal",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "UHF",
                        year = 1989,
                        director = "Jay Levey",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Waiting For Guffman",
                        year = 1996,
                        director = "Christopher Guest",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Waking Ned Devine",
                        year = 1998,
                        director = "Kirk Jones",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Comedy",
                        title = "Wedding Planner, The",
                        year = 2001,
                        director = "Adam Shankman",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "127 Hours",
                        year = 2010,
                        director = "Danny Boyle",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "About Time",
                        year = 2013,
                        director = "Richard Curtis",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Big Fish",
                        year = 2003,
                        director = "Tim Burton",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Braveheart",
                        year = 1995,
                        director = "Mel Gibson",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Casablanca",
                        year = 1942,
                        director = "Michael Curtiz",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Count of Monte Cristo, The",
                        year = 2002,
                        director = "Kevin Reynolds",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Departed, The",
                        year = 2006,
                        director = "Martin Scorsese",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Eternal Sunshine of the Spotless Mind",
                        year = 2004,
                        director = "Michel Gondry",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Far and Away",
                        year = 1992,
                        director = "Ron Howard",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Finding Neverland",
                        year = 2004,
                        director = "Marc Forster",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Gone with the Wind",
                        year = 1939,
                        director = "Victor Fleming",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Green Mile, The",
                        year = 1999,
                        director = "Frank Darabont",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "He Loves Me... He Loves Me Not",
                        year = 2002,
                        director = "Laetitia Colombani",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "La La Land",
                        year = 2016,
                        director = "Damien Chazelle",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Ladder 49",
                        year = 2004,
                        director = "Jay Russell",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Lars and the Real Girl",
                        year = 2007,
                        director = "Craig Gillespie",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Leave Her to Heaven",
                        year = 1945,
                        director = "John M. Stahl",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Les Misérables",
                        year = 1998,
                        director = "Billie August",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Little Miss Sunshine",
                        year = 2006,
                        director = "Jonathan Dayton, Valerie Faris",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Memento",
                        year = 2001,
                        director = "Christopher Nolan",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Millions",
                        year = 2004,
                        director = "Danny Boyle",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Moulin Rouge!",
                        year = 2001,
                        director = "Baz Luhrmann",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Phantom of the Opera, The",
                        year = 2005,
                        director = "Joel Schumacher",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Power of One, The",
                        year = 1992,
                        director = "John G. Avildsen",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Pride and Prejudice",
                        year = 2005,
                        director = "Joe Wright",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Shawshank Redemption, The",
                        year = 1994,
                        director = "Frank Darabont",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Silver Linings Playbook",
                        year = 2012,
                        director = "David O. Russell",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Sliding Doors",
                        year = 1998,
                        director = "Peter Howitt",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Slumdog Millionaire",
                        year = 2008,
                        director = "Danny Boyle",
                        rating = "R",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Stranger than Fiction",
                        year = 2006,
                        director = "Marc Forster",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "True Grit",
                        year = 2010,
                        director = "Joel Coen, Ethan Coen",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Truman Show, The",
                        year = 1998,
                        director = "Peter Weir",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Drama",
                        title = "Unforgiven",
                        year = 1992,
                        director = "Clint Eastwood",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Adventures of Ichabod and Mr. Toad, The",
                        year = 1949,
                        director = "Clyde Geronimi, Jack Kinney, James Algar",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Aladdin",
                        year = 1992,
                        director = "Ron Clements, John Musker",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Annie",
                        year = 1982,
                        director = "John Huston",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Beauty and the Beast",
                        year = 1991,
                        director = "Kirk Wise, Gary Trousdale",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Best Two Years, The",
                        year = 2003,
                        director = "Scott S. Anderson",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cars",
                        year = 2006,
                        director = "John Lasseter",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Charlie and the Chocolate Factory",
                        year = 2005,
                        director = "Tim Burton",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cheaper By The Dozen",
                        year = 2003,
                        director = "Shawn Levy",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cinderella",
                        year = 1950,
                        director = "Clyde Geronimi, Wilfred Jackson, Hamilton Luske",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cinderella",
                        year = 2015,
                        director = "Kenneth Branagh",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cinderella Story, A",
                        year = 2004,
                        director = "Mark Rosman",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Cloudy with a Chance of Meatballs",
                        year = 2009,
                        director = "Chris Miller, Phil Lord",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Despicable Me",
                        year = 2010,
                        director = "Pierre Coffin, Chris Renaud",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Emperor’s New Groove, The",
                        year = 2000,
                        director = "Mark Dindal",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Enchanted",
                        year = 2007,
                        director = "Kevin Lima",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Ernest Goes to Camp",
                        year = 1987,
                        director = "John R. Cherry III",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Ernest Goes to Jail",
                        year = 1990,
                        director = "John R. Cherry III",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Ernest Scared Stupid",
                        year = 1991,
                        director = "John R. Cherry III",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Goofy Movie, A",
                        year = 1995,
                        director = "Kevin Lima",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Goonies, The",
                        year = 1985,
                        director = "Richard Donner",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Great Muppet Caper, The",
                        year = 1981,
                        director = "Jim Henson",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Greatest Showman, The",
                        year = 2017,
                        director = "Michael Gracey",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "High School Musical",
                        year = 2006,
                        director = "Kenny Ortega",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Home Alone",
                        year = 1990,
                        director = "Chris Columbus",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Honey, I Shrunk the Kids",
                        year = 1989,
                        director = "Joe Johnston",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Hook",
                        year = 1991,
                        director = "Steven Spielberg",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "How to Succeed in Business Without Really Trying",
                        year = 1967,
                        director = "David Swift",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "In the Good Old Summertime",
                        year = 1949,
                        director = "Buster Keaton, Robert Z. Leonard",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Incredibles, The",
                        year = 2004,
                        director = "Brad Bird",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "It's a Wonderful Life",
                        year = 1946,
                        director = "Frank Capra",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Labyrinth",
                        year = 1986,
                        director = "Jim Henson",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Leap Frog: Letter Factory",
                        year = 2009,
                        director = "Roy Allen Smith",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Lego Movie, The",
                        year = 2014,
                        director = "Chris Miller, Phil Lord",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Lion King, The",
                        year = 1994,
                        director = "Rob Minkoff, Roger Allers",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Little Mermaid, The",
                        year = 1989,
                        director = "Ron Clements, John Musker",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Lizzie McGuire Movie, The",
                        year = 2003,
                        director = "Jim Fall",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Marley & Me",
                        year = 2008,
                        director = "David Frankel",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Matilda",
                        year = 1996,
                        director = "Danny DeVito",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Moana",
                        year = 2016,
                        director = "Ron Clements, John Musker",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Monsters, Inc.",
                        year = 2001,
                        director = "Pete Docter, Lee Unkrich, David Silverman",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Mr. Krueger’s Christmas",
                        year = 1980,
                        director = "Kieth Merrill",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Mr. Popper's Penguins",
                        year = 2011,
                        director = "Mark Waters",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Muppet Movie, The",
                        year = 1979,
                        director = "James Frawley",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Muppets, The",
                        year = 2011,
                        director = "James Bobin",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "My Little Pony: Equestria Girls",
                        year = 2013,
                        director = "Jayson Thiessen",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "NeverEnding Story, The",
                        year = 1984,
                        director = "Wolfgang Petersen",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Newsies",
                        year = 1992,
                        director = "Kenny Ortega",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Nightmare Before Christmas, The",
                        year = 1993,
                        director = "Henry Selick",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "One Magic Christmas",
                        year = 1985,
                        director = "Phillip Borsos",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Open Season",
                        year = 2006,
                        director = "Anthony Stacchi, Roger Allers, Jill Culton",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Pink Panther and Friends Classic Cartoon Collection, Vol. 5: The Ant and the Aardvark, The",
                        year = 2007,
                        director = "Robert Sledge",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Pollyanna",
                        year = 1960,
                        director = "David Swift",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Praise to the Man",
                        year = 2005,
                        director = "T.C. Christensen, Gary Cook",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Princess Bride, The",
                        year = 1986,
                        director = "Rob Reiner",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Ratatouille",
                        year = 2007,
                        director = "Brad Bird, Jan Pinkava",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Sandlot, The",
                        year = 1993,
                        director = "David M. Evans",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Saturday’s Warrior",
                        year = 1989,
                        director = "Bob Williams",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Shop Around the Corner, The",
                        year = 1940,
                        director = "Ernst Lubitsch",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Sleeping Beauty",
                        year = 1959,
                        director = "Clyde Geronimi",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Snow White and the Seven Dwarfs",
                        year = 1938,
                        director = "Larry Morey, Wilfred Jackson, Ben Sharpsteen, Perce Pearce, David Hand, William Cottrell",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Sound of Music, The",
                        year = 1965,
                        director = "Robert Wise",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Support Your Local Gunfighter",
                        year = 1971,
                        director = "Burt Kennedy",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Support Your Local Sheriff",
                        year = 1969,
                        director = "Burt Kennedy",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Sword in the Stone, The",
                        year = 1963,
                        director = "Wolfgang Reitherman",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Teenage Mutant Ninja Turtles",
                        year = 1990,
                        director = "Steve Barron",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Teenage Mutant Ninja Turtles II: The Secret of the Ooze",
                        year = 1991,
                        director = "Michael Pressman",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "They Might Be Giants: Here Comes Science",
                        year = 2009,
                        director = "John Linnell, John Flansburgh",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "They Might Be Giants: Here Comes the 123s",
                        year = 2008,
                        director = "John Linnell, John Flansburgh",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "They Might Be Giants: Here Comes the ABCs",
                        year = 2005,
                        director = "John Linnell, John Flansburgh",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Toy Story",
                        year = 1995,
                        director = "John Lasseter",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Toy Story 2",
                        year = 1999,
                        director = "John Lasseter",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Toy Story 3",
                        year = 2010,
                        director = "Lee Unkrich",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "We Bought a Zoo",
                        year = 2011,
                        director = "Cameron Crowe",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "What a Girl Wants",
                        year = 2003,
                        director = "Dennie Gordon",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Willy Wonka and the Chocolate Factory",
                        year = 1971,
                        director = "Mel Stuart",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Wonder",
                        year = 2017,
                        director = "Stephen Chbosky",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Family",
                        title = "Zootopia",
                        year = 2016,
                        director = "Byron Howard, Rich Moore",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "28 Days Later",
                        year = 2002,
                        director = "Danny Boyle",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "39 Steps",
                        year = 1935,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Blackmail",
                        year = 1929,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Blair Witch Project, The",
                        year = 1999,
                        director = "Eduardo Sánchez, Daniel Myrick",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Bride of Frankenstein, The",
                        year = 1935,
                        director = "James Whale",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Buffy the Vampire Slayer",
                        year = 1992,
                        director = "Fran Rubel Kuzui",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Cabin in the Woods",
                        year = 2012,
                        director = "Drew Goddard",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Changeling, The",
                        year = 1980,
                        director = "Peter Medak",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Chronicle",
                        year = 2012,
                        director = "Josh Trank",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Dawn of the Dead",
                        year = 2004,
                        director = "Zack Snyder",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Dementia 13",
                        year = 1963,
                        director = "Francis Ford Coppola",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Devil",
                        year = 2010,
                        director = "John Erick Dowdle",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Dracula",
                        year = 1931,
                        director = "Tod Browning, Karl Freund",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Fido",
                        year = 2006,
                        director = "Andrew Currie",
                        rating = "R",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Frankenstein",
                        year = 1931,
                        director = "James Whale",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Frankenstein Meets the Wolf Man",
                        year = 1943,
                        director = "Roy William Neill",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Grudge, The",
                        year = 2004,
                        director = "Takashi Shimizu",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "House on Haunted Hill",
                        year = 1959,
                        director = "William Castle",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Identity",
                        year = 2003,
                        director = "James Mangold",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Invaders From Mars",
                        year = 1986,
                        director = "Tobe Hooper",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Invisible Man, The",
                        year = 1933,
                        director = "James Whale",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Jaws",
                        year = 1975,
                        director = "Steven Spielberg",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Juno & The Paycock",
                        year = 1930,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Lady in White",
                        year = 1988,
                        director = "Frank Laloggia",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Lady Vanishes, The",
                        year = 1938,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Lodger",
                        year = 1927,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Man Who Knew Too Much, The",
                        year = 1934,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Masque of the Red Death, The",
                        year = 1964,
                        director = "Roger Corman",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Monster Squad, The",
                        year = 1987,
                        director = "Fred Dekker",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Mothman Prophecies, The",
                        year = 2002,
                        director = "Mark Pellington",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Mummy, The",
                        year = 1932,
                        director = "Karl Freund",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Night of the Living Dead",
                        year = 1968,
                        director = "George A. Romero",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Nosferatu",
                        year = 1922,
                        director = "F. W. Murnau",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Phantom of the Opera, The",
                        year = 1925,
                        director = "Lon Chaney, Sr., Edward Sedgwick, Rupert Julian, Ernst Laemmle",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Plan 9 from Outer Space",
                        year = 1959,
                        director = "Ed Wood",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Premature Burial, The",
                        year = 1962,
                        director = "Roger Corman",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Psycho",
                        year = 1960,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Rear Window",
                        year = 1954,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Return of Dracula, The",
                        year = 1958,
                        director = "Paul Landres",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Rich & Strange",
                        year = 1931,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Ring, The",
                        year = 1927,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Ring, The",
                        year = 2002,
                        director = "Gore Verbinski",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Sabotage",
                        year = 1936,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Saw",
                        year = 2004,
                        director = "James Wan",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Secret Agent",
                        year = 1936,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Shaun of the Dead",
                        year = 2004,
                        director = "Edgar Wright",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "She-Wolf of London",
                        year = 1946,
                        director = "Jean Yarbrough",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Signs",
                        year = 2002,
                        director = "M. Night Shyamalan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Sixth Sense, The",
                        year = 1999,
                        director = "M. Night Shyamalan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Strange Invaders",
                        year = 1983,
                        director = "Michael Laughlin",
                        rating = "PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Sweeney Todd: The Demon Barber of Fleet Street",
                        year = 2007,
                        director = "Tim Burton",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Thing from Another World, The",
                        year = 1951,
                        director = "Christian Nyby, Howard Hawks",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Tormented",
                        year = 1960,
                        director = "Bert I. Gordon",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Unbreakable",
                        year = 2000,
                        director = "M. Night Shyamalan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Vacancy",
                        year = 2007,
                        director = "Nimród Antal",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Vampire, The",
                        year = 1957,
                        director = "Paul Landres",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Village, The",
                        year = 2004,
                        director = "M. Night Shyamalan",
                        rating = "PG-13",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "War of the Worlds, The",
                        year = 1953,
                        director = "Byron Haskin",
                        rating = "G",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Werewolf of London",
                        year = 1935,
                        director = "Stuart Armstrong Walker",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Wolf Man, The",
                        year = 1941,
                        director = "George Waggner",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Young & Innocent",
                        year = 1937,
                        director = "Alfred Hitchcock",
                        rating = "UR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Horror/Suspense",
                        title = "Zombieland",
                        year = 2009,
                        director = "Ruben Fleischer",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "29",
                        year = 2003,
                        director = "Alan Seawright",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "29: Day 2",
                        year = 2004,
                        director = "Alan Seawright",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Barenaked Ladies - Barelaked Nadies",
                        year = 2002,
                        director = "Tim Hamilton",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Bellydance Core Conditioning",
                        year = 2005,
                        director = "Neena & Veena",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Blue Man Group - The Complex Rock Tour Live",
                        year = 2003,
                        director = "Matt Goldman, Phil Stanton, Chris Wink",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Cartoon Lagoon",
                        year = 2012,
                        director = "Euralis Weekes",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Core Secrets: 25 Minute Full Body Workout / Accelerated Core Training",
                        year = 2003,
                        director = "Gunnar Peterson",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Crunch - Pick Your Spot Pilates",
                        year = 2002,
                        director = "Ellen Barrett",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Faux Paw Adventures in the Internet",
                        year = 2008,
                        director = "Kreg Peeler",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Les Miserables the Musical That Swept the World in Concert: The Dream Cast",
                        year = 1995,
                        director = "Gavin Taylor, Paul Kafno",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Ogden: Junction City of the West",
                        year = 2007,
                        director = "Issac Goeckeritz",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Pet Shop",
                        year = 2005,
                        director = "Trent Halvorsen",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Miscellaneous",
                        title = "Seven Days Seven Workouts",
                        year = 2005,
                        director = "N/A",
                        rating = "NR",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "24 (Season 1)",
                        year = 2001,
                        director = "Joel Surnow, Robert Cochran",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "24 (Season 2)",
                        year = 2002,
                        director = "Joel Surnow, Robert Cochran",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "24 (Season 3)",
                        year = 2003,
                        director = "Joel Surnow, Robert Cochran",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Adventures of Brisco County, Jr.: The Complete Series, The",
                        year = 1993,
                        director = "Carlton Cuse, Jeffrey Boam",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Arrested Development (Season 1)",
                        year = 2003,
                        director = "Mitchell Hurwitz",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Arrested Development (Season 2)",
                        year = 2004,
                        director = "Mitchell Hurwitz",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Arrested Development (Season 3)",
                        year = 2005,
                        director = "Mitchell Hurwitz",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Avatar: The Last Airbender (Book 1)",
                        year = 2005,
                        director = "Michael Dante DiMartino, Bryan Konietzko",
                        rating = "TV-Y7",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Avatar: The Last Airbender (Book 2)",
                        year = 2006,
                        director = "Michael Dante DiMartino, Bryan Konietzko",
                        rating = "TV-Y7",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Avatar: The Last Airbender (Book 3)",
                        year = 2007,
                        director = "Michael Dante DiMartino, Bryan Konietzko",
                        rating = "TV-Y7",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 1)",
                        year = 2009,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 2)",
                        year = 2010,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 3)",
                        year = 2011,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 4)",
                        year = 2013,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 5)",
                        year = 2014,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Community (Season 6)",
                        year = 2015,
                        director = "Dan Harmon",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Firefly: The Complete Series",
                        year = 2002,
                        director = "Joss Whedon",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Malcolm in the Middle (Season 1)",
                        year = 2000,
                        director = "Linwood Boomer",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000 Collection, Volume 1, The",
                        year = 2002,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000 Collection, Volume 2, The",
                        year = 2003,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000 Collection, Volume 4, The",
                        year = 2003,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000 Collection, Volume 5, The",
                        year = 2004,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000 Collection, Volume 8, The",
                        year = 2005,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: 20th Anniversary Edition",
                        year = 2008,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: Eegah!",
                        year = 1993,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: Escape 2000",
                        year = 1996,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: Mitchell",
                        year = 1993,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: Samson vs. Vampire Women",
                        year = 1995,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: The Essentials",
                        year = 2004,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Mystery Science Theater 3000: Wild World of Batwoman",
                        year = 1993,
                        director = "Joel Hodgson",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Police Squad! The Complete Series",
                        year = 1982,
                        director = "Jim Abrahams, David Zucker, Jerry Zucker",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Pushing Daisies (Season 1)",
                        year = 2007,
                        director = "Bryan Fuller",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Pushing Daisies (Season 2)",
                        year = 2008,
                        director = "Bryan Fuller",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Roswell (Season 1)",
                        year = 1999,
                        director = "Jonathon Dukes",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Roswell (Season 2)",
                        year = 2000,
                        director = "Jonathon Dukes",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Roswell (Season 3)",
                        year = 2001,
                        director = "Jonathon Dukes",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Saturday Night Live - 25th Anniversary",
                        year = 2004,
                        director = "Lorne Michaels",
                        rating = "TV-14",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Saved By the Bell (Season 5)",
                        year = 1992,
                        director = "Sam Bobrick",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Saved by the Bell (Seasons 1 & 2)",
                        year = 1989,
                        director = "Sam Bobrick",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Saved by the Bell (Seasons 3 & 4) ",
                        year = 1990,
                        director = "Sam Bobrick",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 1 & 2)",
                        year = 1990,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 3)",
                        year = 1991,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 4)",
                        year = 1992,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 5)",
                        year = 1993,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 6)",
                        year = 1994,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 7)",
                        year = 1995,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "Television",
                        title = "Wings (Season 8)",
                        year = 1996,
                        director = "David Angell, Peter Casey, David Lee",
                        rating = "TV-PG",
                        edited = null,
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "VHS",
                        title = "Joy Ride",
                        year = 2001,
                        director = "John Dahl",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    },
                    new Movie
                    {
                        category = "VHS",
                        title = "Untouchables",
                        year = 1987,
                        director = "Brian De Palma",
                        rating = "R",
                        edited = "Yes",
                        lent = null,
                        notes = null
                    }


                );

                context.SaveChanges();
            }
        }
    }
}

