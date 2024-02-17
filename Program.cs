using System;
using System.Reflection;
namespace FunWithMusic
{

    class Program
    {
        enum Genre
        {
            HardRock,
            Metal,
            Alternative,
            Blues,
            HipHop
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;


            /*
            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;

            }
            */

            public void setTitle(string title)
            {
                Title = title;
            }

            public void setArtist(string artist)
            {
                Artist = artist;
            }

            public void setAlbum(string album)
            {
                Album = album;
            }

            public void setLength(string length)
            {
                Length = length;
            }

            public void setGenre(Genre genre)
            {
                Genre = genre;
            }

            public string Display()
            {
                return "Title " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {

                for (int i = 0; i < size; i++)
                {

                    Console.WriteLine("What is the title of your song?");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Who is the Artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the Album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("H - hardRock\nM - metal\nA - alternative\nB - blues\nP - hiphop ");
                    Genre tempGenre = Genre.HardRock;

                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'H':
                            tempGenre = Genre.HardRock;
                            break;
                        case 'M':
                            tempGenre = Genre.Metal;
                            break;
                        case 'A':
                            tempGenre = Genre.Alternative;
                            break;
                        case 'B':
                            tempGenre = Genre.Blues;
                            break;
                        case 'P':
                            tempGenre = Genre.HipHop;
                            break;

                    }
                    collection[i].setGenre(tempGenre);
                }
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine($"Here are your songs...");
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Display());
                }
            }

        }
        }
    }


