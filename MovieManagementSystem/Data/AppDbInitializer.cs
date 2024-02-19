using MovieManagementSystem.Data.Enums;
using MovieManagementSystem.Models;
using System.IO;

namespace MovieManagementSystem.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaLogo = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689752727/eTickets/fcube_hipfje.jpg",
                            CinemaName = "FCube Cinemas",
                            Description = "The halls are equipped with cutting edge technologies like Dolby 3 Ware Digital sound systems and digital 2K projection view. Considered to be one of the most sophisticated and advanced equipment, these will bring forth the best picture and sound quality for the audience to enjoy. The super comfy seats and modern decor adds a luxurious touch to this high-tech movie theater.\r\n\r\nNo movie experience is complete without refreshment and at FCUBE Cinemas this need is also taken care of with its snack corner. Rest assured that watching movies at FCUBE Cinemas will be an audio-visual treat for the audience, which you can enjoy in a relaxed ambiance.",
                        },
                        new Cinema()
                        {
                            CinemaLogo = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689752825/eTickets/qfx_troeaf.png",
                            CinemaName = "QFX",
                            Description = "This modern cinema offers a range of Hollywood hits as well as local & regional films.",
                        },
                        new Cinema()
                        {
                            CinemaLogo = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689752726/eTickets/CDCcinemas_pwmi54.png",
                            CinemaName = "CDC Cinema",
                            Description = "CDC-Cinemas Welcomes you to its about us section. We thank you for visiting our website and showing interest in our information.\r\n\r\nCDC-Cinemas is our vision of experiencing movies in the best possible way. At CDC-Cinemas we believe that just playing the movie on the screen for our members is not enough, instead, we set out with the goal of giving the customers the experience of watching the movie with us. When you walk out of Cine de Chef, it is not the movie that we want you to remember, its the time and memories that you created with us that’s what needs to stay with you.\r\n\r\nTo achieve this goal, we have considered the most obvious features of a movie theater such as acoustics, seats, sounds, screen to the minutest details such as temperature of glass in which we serve you drinks to the faucets you use to wash your hands. That’s the level of detail and customization we wanted to offer to our customers. To achieve this, we have gone far and beyond to design and equip Cine de Chef with the best of each available options from across the globe. Below is the very brief summary of some of our features, all of which are being introduced for the very first time in Nepal in the multiplex industry:",
                        },
                        new Cinema()
                        {
                            CinemaLogo = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689752727/eTickets/Big-Movies_cl0avb.jpg",
                            CinemaName = "Big Movies",
                            Description = "Big Movies is one of the best & Nepal’s First Multiplex operated by Vishal Group.\r\n\r\nWe have 3 Screens with a total seating capacity of 887 seats, providing world class auditoriums. We are enabled by BARCO 2K Digital Projection System, Crystal Clear DTS Sound System along with DOLBY ATMOS as an upgrade. We have 3 screens with high quality 3D effect serving best sound and picture and DOLBY ATMOS enabled.",
                        },
                        new Cinema()
                        {
                            CinemaLogo = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689752726/eTickets/onecinemas_spqiw7.jpg",
                            CinemaName = "One Cinemas",
                            Description = "Introducing One Cinemas, the ultimate destination in Nepal for an amazing movie-watching experience. Located at the prime spot in New Baneshwor, Kathmandu, Nepal and Kalimati, Kathmandu, Nepal, One Cinemas is brought to you by Core Plan Builders Company Pvt. Ltd and Ocular Holding Pvt. Ltd.\r\n \r\nAt One Cinemas, our mission is to craft extraordinary experiences for movie enthusiasts, focusing on Luxury, Service, and Technology, all centered around our theme, \"There is a difference.\"\r\n \r\nSetting a new standard in the cinema industry, One Cinemas proudly stands as Nepal's only exclusive 4k cinema chain. Over the years, we have consistently expanded our screen network, adding premium screening options at New Baneshwor with 69 seats. Currently, our venues at Kalimati Trade Center, Kalimati, and Eyeplex Mall, New Baneshwor feature 38x17 feet silver screens. With a total seating capacity of 761, One Cinemas provides world-class auditorium experiences through our 4K digital projection system and crystal-clear DTS sound system with DOLBY Surround 7.1. Both venues are equipped with top-notch 3D effects, delivering the finest video and audio quality. At One Cinemas, we bring movies to life!\r\n \r\nAs a leading entertainment company, One Cinemas is committed to delivering exceptional cinematic experiences to our valued customers. Our cutting-edge facilities,  and unwavering focus on customer satisfaction ensure that One Cinemas creates unforgettable moments for moviegoers. Our company culture is built upon teamwork, innovation, and maintaining the highest standards of service. We prioritize the well-being and professional growth of our employees, fostering a fair and productive work environment.",
                        }
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753828/eTickets/Actors/cristianbale_jgy1ww.jpg",
                            FullName = "Cristian Bale",
                            Bio = "Christian Charles Philip Bale (born 30 January 1974) is an English actor. Known for his versatility and physical transformations for his roles, he has been a leading man in films of several genres. He has received various accolades, including an Academy Award and two Golden Globe Awards.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753828/eTickets/Actors/tomcruise_bv9ks5.jpg",
                            FullName = "Tom Cruise",
                            Bio = "Tom Cruise, byname of Thomas Cruise Mapother IV, (born July 3, 1962, Syracuse, New York, U.S.), American actor who emerged in the 1980s as one of Hollywood's most popular leading men, known for his clean-cut good looks and versatility.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753828/eTickets/Actors/tomhardy_tgjuur.jpg",
                            FullName = "Tom Hardy",
                            Bio = "Tom Hardy, in full Edward Thomas Hardy, (born September 15, 1977, London, England), British actor who was known for his striking good looks, idiosyncratic personality, and cerebral performances in both cult films and mainstream blockbusters.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753827/eTickets/Actors/henrycavill_zhz2ev.jpg",
                            FullName = "Henry Cavill",
                            Bio = "Cavill is described as British and English. He was born on Jersey, an island in the Channel Islands. Cavill resides in South Kensington, London. He was engaged to English show jumper Ellen Whitaker from 2011 until 2012.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753828/eTickets/Actors/dayahangrai_ns4pz6.jpg",
                            FullName = "Dayahang Rai",
                            Bio = "Dayahang Rai was born on April 13, 1980, in Khawa, Bhojpur district in Eastern Nepal to Tilak Ram Rai and Chandra Devi Rai. He is the middle child of the family. He has two younger sisters and an older brother. His family belongs to the Bantawa Rai people of Kirat ethnicity of Nepal.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753827/eTickets/Actors/saugatmalla_jxxtbf.jpg",
                            FullName = "Saugat Malla",
                            Bio = "Saugat Malla is an Nepalese film actor and producer. He is known as a versatile actor in the Nepali cinema industry, he began acting professionally in the 2010s, and he later rose to fame for his leading role Haku Kale in Loot.",
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689753828/eTickets/Actors/bipinkarki_disojg.jpg",
                            FullName = "Bipin karki",
                            Bio = "Bipin Karki (Nepali: बिपिन कार्की, born 21 August 1982 in Bahuni, Nepal) is a Nepalese film and theatre actor known for his work in Nepali cinema. Karki started acting at a young age by appearing in stage plays with his brother, Arjun Karki.",
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName = "Mission: Impossible - Fallout",
                            MovieDescription = "When an IMF mission ends badly, the world is faced with dire consequences. As Ethan Hunt takes it upon himself to fulfill his original briefing, the CIA begin to question his loyalty and his motives. The IMF team find themselves in a race against time, hunted by assassins while trying to prevent a global catastrophe.",
                            Price = 49.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755707/eTickets/Movies/missionimpossible_nkj6au.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Action,
                            CinemaId = 1,
                            ProducerId = 1
                        },
                        new Movie()
                        {
                            MovieName = "Mad Max: Fury Road",
                            MovieDescription = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and most everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order.",
                            Price = 49.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755707/eTickets/Movies/madmax_k5ujbr.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Adventure,
                            CinemaId = 2,
                            ProducerId = 2,
                        },
                        new Movie()
                        {
                            MovieName = "Equilibrium",
                            MovieDescription = "In a dystopian future, a totalitarian regime maintains peace by subduing the populace with a drug, and displays of emotion are punishable by death. A man in charge of enforcing the law rises to overthrow the system.",
                            Price = 39.49,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755707/eTickets/Movies/Equilibrium_jruz1u.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Adventure,
                            CinemaId = 3,
                            ProducerId = 3,
                        },
                        new Movie()
                        {
                            MovieName = "The Night Hunter",
                            MovieDescription = "A weathered Lieutenant, his police force, and a local vigilante are all caught up in a dangerous scheme involving a troubled, recently-arrested man who's linked to years of female abductions and murders.",
                            Price = 45.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755707/eTickets/Movies/nighthunter_cwurjf.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Drama,
                            CinemaId = 4,
                            ProducerId = 1,
                        },
                        new Movie()
                        {
                            MovieName = "Kabaddi",
                            MovieDescription = "Kazi a young aimless man dreams of marrying Maiya, a village girl by any means although she wants to go to the city for higher education. Their lives are thrown into turmoil with the arrival of Bibek, a charming young man from the city.",
                            Price = 50.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755706/eTickets/Movies/kabaddi_e6cyt6.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 5,
                            ProducerId = 5,
                        },
                        new Movie()
                        {
                            MovieName = "Loot",
                            MovieDescription = "A man with a 'master plan' to rob a bank searches and leads four frustrated men in their quest for quick money.",
                            Price = 10.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755706/eTickets/Movies/Loot_2012_film_cnhcie.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 3,
                            ProducerId = 5,
                        },
                        new Movie()
                        {
                            MovieName = "Edge of Tomorrow",
                            MovieDescription = "Major Bill Cage is an officer who has never seen a day of combat when he is unceremoniously demoted and dropped into combat. Cage is killed within minutes, managing to take an alpha alien down with him. He awakens back at the beginning of the same day and is forced to fight and die again... and again - as physical contact with the alien has thrown him into a time loop.",
                            Price = 10.99,
                            ImageURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689755707/eTickets/Movies/edgeoftomorrow_poi2hg.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.Date.AddDays(7),
                            MovieCategory = MovieCategory.Adventure,
                            CinemaId = 5,
                            ProducerId = 2,
                        },
                    });
                    context.SaveChanges();
                }

                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Christopher McQuarrie",
                            Bio = "Christopher McQuarrie is an American film director, producer and screenwriter. He received the BAFTA Award, Independent Spirit Award, and Academy Award for Best Original Screenplay for the neo-noir mystery film The Usual Suspects (1995).",
                            ProfilePictureURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689756539/eTickets/Directors/christophermcquarrie_uuy2gb.jpg"
                        },
                        new Producer()
                        {
                            FullName = "George Miller",
                            Bio = "George Miller is an Australian film director, screenwriter, producer, and former medical doctor. He is best known for his Mad Max franchise, with The Road Warrior (1981) and Mad Max: Fury Road (2015) Aside from the Mad Max films, Miller has been involved in a wide range of projects.",
                            ProfilePictureURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689756541/eTickets/Directors/George_Miller_e07adm.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Kurt Wimmer",
                            Bio = "Kurt Wimmer (born 1964) is an American screenwriter and film director. Wimmer is of German descent, he attended the University of South Florida and graduated with a BFA degree in Art History. He then moved to Los Angeles where he worked for 12 years as a screenwriter before making his 2002 film, Equilibrium.",
                            ProfilePictureURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689756540/eTickets/Directors/kurtwimmer_rt9b9c.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Nischal Basnet",
                            Bio = "Nischal Basnet is a Nepalese film director and actor who primarily appears in Nepali language films. He made his directorial debut in 2012 with the crime-thriller Loot and wrote screenplay for the film. The film focuses on Hakku Kale (played by Saugat Malla), who masterminds a bank robbery.",
                            ProfilePictureURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689756540/eTickets/Directors/NischalBasnet_rckjay.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Upendra Subba",
                            Bio = "Upendra Bahadur Angdembe who is known as Upendra Subba (Nepali: उपेन्द्र सुब्बा) is a Nepali poet, lyricist, writer, and film director. He is one of the initiators of the movement called Srijanshil Arajakta (Creative Anarchy) along with Rajan Mukarung and Hangyug Agyat.",
                            ProfilePictureURL = "https://res.cloudinary.com/dl29hrqdb/image/upload/v1689756540/eTickets/Directors/upendrasubba_l2kn6c.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Actors and Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 1,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 2,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 3,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 5,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 6,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 7,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 5,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 6,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 7,
                            ActorId = 2,
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

