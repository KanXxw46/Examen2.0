using System;
using System.Collections.Generic;

namespace Exsamen2._0
{
    class Program
    {
        private static List<Rock_grups> rock_grups;
        private static Profile profile;
        static void Main(string[] args)
        {
            InitSqlStubData();
            Console.WriteLine("Здравствуйте,выберите действие:\n1.Рандомная Рок-группа\n2.Получить всю инормацию о Рок-Группах\n3.Получить свой профиль");
            while (true)
            {
                var actionNumberAsString = Console.ReadLine();
                var action = 0;
                if (int.TryParse(actionNumberAsString, out action))
                {
                    switch (action)
                    {
                        case 1:
                            {
                                var response = new PseudoServerRespose<Rock_grups>
                                {
                                    Data = rock_grups[0]
                                };

                                Console.WriteLine($", {response.Data.Name},{response.Data.Album},{response.Data.Description},{response.Data.Music}.");
                                break;
                            }
                        case 2:
                            {
                                var response = new PseudoServerRespose<List<Rock_grups>>
                                {
                                    Data = rock_grups
                                };
                                foreach (var rock_grups in rock_grups)
                                {
                                    Console.WriteLine($"{rock_grups.Name},{rock_grups.Album},{rock_grups.Description},{rock_grups.Music}. ");
                                }
                                break;
                            }
                        case 3:
                            {
                                var response = new PseudoServerRespose<Profile>
                                {
                                    Data = profile
                                };
                                Console.WriteLine($"{profile.Username},{profile.Id} ");
                                break;
                            }
                    }
                }
                else
                {
                    //TODO выход

                }
            }
        }

        private static void InitSqlStubData()
        {
            profile = new Profile { Username = "Andreik2004" ,Password ="2004DKD"};

            rock_grups = new List<Rock_grups> {
            new Rock_grups
            {
                    Name = "Evanescence\n",
                    Album = "1)Fallen2)Cold\n",
                    Description = "1)Fallen - вышел в марте 2003 г. был продан в количестве 15 млн\n2)Cold-вышла в 1995 г. в г. Литл-Рок, штат Арканзас. 16 млн просмотров\n",
                    Music = "1)Fallen-«Bring Me To Life»,«Сорвиголова»,2)Cold-«The Open Door»,3)«Call Me When You’re Sober»\n"
            },

            new Rock_grups
            {
                    Name = "Bring Me The Horizon\n",
                    Album = "The Bedroom Sessions,This Is What the Edge of Your Seat Was Made For,The Chill Out Sessions \n",
                    Description = "1)The Bedroom Sessions-дебютный студийный альбом британской рок-группы Bring Me the Horizon, вышедший 30 октября 2006 года в Великобритании." +
                    "\n2)This Is What the Edge of Your Seat Was Made For-первый мини-альбом группы из Британии Bring me The Horizon[1]. Название этого «мини-альбома» переводится с английского как: Это то, для чего был сделан край вашего места." +
                    "\n3)The Chill Out Sessions-третий студийный альбом британской металкор-группы Bring Me the Horizon, вышедший 4 октября 2010 года в Великобритании и большинстве европейских стран и 5 октября 2010 года — в США[2])\n",
                    Music = "1)«Crucify Me»,2)«Anthem»,3)«It Never Ends »\n"
            },

            new Rock_grups
            {
                    Name = "Amatory\n",
                    Album = "Вечно прячется судьба,Неизбежность,Книга мёртвых.\n",
                    Description = "Вечно прячется судьба-вышел в марте 2007 г.,Неизбежность-вышел в марте 2009 г,Книга-вышел в марте 2019 г\n",
                    Music = "«Восковой дождь»,«Страница VI»,«Мимикрия»\n"
            },

            };
        }
    }
}
