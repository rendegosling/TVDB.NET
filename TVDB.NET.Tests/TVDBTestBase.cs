﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVDB.NET.Tests
{
    public abstract class TVDBTestBase
    {
        //put your api key here
        protected const string YourTheTVDBAPIKey = "B55E6F0F1B82D8F7";
        protected const string APIKeyMissing = "Plese get an api key from the tvdb first!";

        protected string GetTestXml()
        {
            return @"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <Data>
                          <Series>
                            <seriesid>278591</seriesid>
                            <language>en</language>
                            <SeriesName>Game of Arms</SeriesName>
                            <banner>graphical/278591-g.jpg</banner>
                            <Overview>
                              Game of Arms is a look inside the raw and highly competitive world of American arm wrestling. The series follows the members of five regional arm wrestling clubs in Erie, PA, Kansas City, KS, New York, NY, Sacramento, CA and Baton Rouge, LA as they hit the road and wager their reputation, relationships and money for the sport. Game of Arms not only focuses on the technique and skill in this high-stakes world, but also the family, careers and personal struggles of each man outside of the sport. Each episode features a dramatic regional match, leading to a tournament finale where the entire cast will compete for prize money and bragging rights.

                              The series hails from Matt Renner and Ethan Prochnik, the Emmy Award-winning producers of Deadliest Catch, and executive producer Dan Ilani, their partner in Undertow Films.
                            </Overview>
                            <FirstAired>2014-02-25</FirstAired>
                            <Network>AMC</Network>
                            <IMDB_ID>tt3525596</IMDB_ID>
                            <zap2it_id>EP01853455</zap2it_id>
                            <id>278591</id>
                          </Series>
                          <Series>
                            <seriesid>262890</seriesid>
                            <language>en</language>
                            <SeriesName>Game of Deceit</SeriesName>
                            <Overview>Crafty Zheng (Nick), often used his skills to con people to survive in the society. One day, Zheng and his friend, Jing (Yuen King Dan) meets the young master of Top Appraisal, Yu (Jessica Hsuan) and Yu's fiancÃ©e, Er and Jing finds himself attracted to Er. When Yu helps Er's father to think of a plan to let the people give up their coins, Zheng spoils Yu's plan. as the deadline for the new coins is coming, Yu thinks of another plan. However, it so happens that when Zheng went to Yu's house, he accidentally stumbles upon the fact that Yu is actually a woman. On the day of the deadline, he openly exposes Yu in front of the Emperor, causing Er's father to commit suicide because he cannot accept the punishment. Er and Yu's family end up in jail. When they are saved by Zheng, Er vows to get back on Yu while Yu and Zheng's father trick them into getting married. Zheng and Yu both agreed that they will only be husband and wife in name only and Zheng is now in charge of Top Appraisal. As the days goes, they feeling for each other deepen. On the other hand, Jing still adores Er, but little does he know that Jiu (Qian Jia Le), Yu's friend is in love with him too. But all these feeling must be put on a hold...as they stumbled upon four statues that have implications for the fate of the Emperor and the Qing Dynasty...</Overview>
                            <id>262890</id>
                          </Series>
                          <Series>
                            <seriesid>121361</seriesid>
                            <language>en</language>
                            <SeriesName>Game of Thrones</SeriesName>
                            <banner>graphical/121361-g19.jpg</banner>
                            <Overview>Seven noble families fight for control of the mythical land of Westeros. Friction between the houses leads to full-scale war. All while a very ancient evil awakens in the farthest north. Amidst the war, a neglected military order of misfits, the Night's Watch, is all that stands between the realms of men and icy horrors beyond.</Overview>
                            <FirstAired>2011-04-17</FirstAired>
                            <Network>HBO</Network>
                            <IMDB_ID>tt0944947</IMDB_ID>
                            <zap2it_id>SH01389809</zap2it_id>
                            <id>121361</id>
                          </Series>
                          <Series>
                            <seriesid>278339</seriesid>
                            <language>en</language>
                            <SeriesName>Game of Stones</SeriesName>
                            <banner>graphical/278339-g2.jpg</banner>
                            <Overview>An ""extreme gem hunter"" named Don Kogen, who is described as a ""legend"" in the business. Kogen, who is CEO of Gem Guys Inc., specializes in rare stones ""from the most dangerous and lawless places on earth, racing the clock to be the first to each new find, always staying one step ahead of the competition.""</Overview>
                            <FirstAired>2014-02-28</FirstAired>
                            <Network>Discovery</Network>
                            <id>278339</id>
                          </Series>
                          <Series>
                            <seriesid>82244</seriesid>
                            <language>en</language>
                            <SeriesName>History Of Football: The Beautiful Game</SeriesName>
                            <banner>graphical/82244-g.jpg</banner>
                            <Overview>The entire history of the world's favorite game? It's an extraordinary challenge that could go have gone horribly wrong, but ""History Of Football: The Beautiful Game"" is a class act. It boasts top-drawer production values, including narration by Terence Stamp, access to everybody who has really mattered in the game, ever, plus loads of famous, rare, and never-seen-before footage, each volume offering a blend of narrative, action, and illuminating interviews. This is a polished product: part celebration, part commemoration, but always with a sharp investigative sense, digging around the misty-eyed, good ol' days tradition, to explore in the company of those interviewed the reality behind some of soccer's myths and legends.</Overview>
                            <FirstAired>2002-09-23</FirstAired>
                            <Network>BBC One</Network>
                            <IMDB_ID>tt0408221</IMDB_ID>
                            <id>82244</id>
                          </Series>
                          <Series>
                            <seriesid>73597</seriesid>
                            <language>en</language>
                            <SeriesName>NFL Game of the Week</SeriesName>
                            <banner>graphical/73597-g.jpg</banner>
                            <Overview>Welcome to the newly-realigned NFL Game of the Week guide at TV Tome. Those of you who watch NFL Network and see the NFL Game of the Week are probably asking, What makes an NFL Game of the Week? There are many factors involved.  It could be a record-setting performance or a great rivalry.  Most of the time, it is the games that go down to the final seconds. Starting in 1965, NFL Films produced NFL Game of the Week to showcase the league's biggest contest.  It started out as the last reminder of the old newsreels.  These shows were packaged for air less than 24 hours after the game was played.  This was the pattern established for the show's first 22 years (1965-1986). Production of the old NFL Game of the Week presented its drawbacks.  Facilities were so primitive that the slightest mistake in a narration meant starting over.  This did not sit well with the proven sportscasters brought in to narrate the shows. NFL Game of the Week found its mark around 1970, wh</Overview>
                            <FirstAired>1965-09-01</FirstAired>
                            <zap2it_id>SH618615</zap2it_id>
                            <id>73597</id>
                          </Series>
                          <Series>
                            <seriesid>250013</seriesid>
                            <language>en</language>
                            <SeriesName>Queen of the Game</SeriesName>
                            <Overview>23 years ago, Kang Eun Seolâ€™s father, Kang Jae Ho, stole the position of Lee Shin Junâ€™s father. This led to Lee Shin Junâ€™s father to commit suicide with his wife and son. Now 23 years later, Lee Shin Jun, now known as Chase, wants revenge and isnâ€™t going to stop until he gets it. He makes Kang Eun Seol fall for him, so that he can get to her father. But there is a twist, Lee Shin Jun has also fallen in love with Kang Eun Seol, but Lee Shin Junâ€™s partner, Park Joo Won loves him tooâ€¦ Later Eun Seol finds out about Shin Junâ€™s revenge plot against her father and she decides to get revenge on him for using her..</Overview>
                            <FirstAired>2006-11-08</FirstAired>
                            <Network>SBS</Network>
                            <IMDB_ID>tt0983961</IMDB_ID>
                            <id>250013</id>
                          </Series>
                          <Series>
                            <seriesid>74997</seriesid>
                            <language>en</language>
                            <SeriesName>Cathedrals of the Game</SeriesName>
                            <Overview>Welcome to the Cathedrals of the Game guide at TV Tome. INHD's look at Major League ballparks. There is no editor for this show. If you would like to be the editor look here for details.</Overview>
                            <FirstAired>2004-07-01</FirstAired>
                            <id>74997</id>
                          </Series>
                          <Series>
                            <seriesid>80877</seriesid>
                            <language>en</language>
                            <SeriesName>Rise of the Video Game</SeriesName>
                            <banner>graphical/80877-g3.jpg</banner>
                            <Overview>
                              The video game revolution has been under way for decades, progressing from simple amusements created in the 1950s to an all-pervasive force in today's popular culture that rivals â€” and will perhaps soon surpass â€” film and television. What began as a subculture pastime has evolved and transcended genres to become a unique form of expression impacting everything from modern warfare to interpersonal relationships.

                              Rise of the Video Game is a comprehensive and progressive exploration of the past, present and future of video games and video gamers. From the early days of Pong to today's ever-popular Halo 2, and from Atari 2600 to Nintendo to PlayStation, Rise of the Video Game tells the story of the people, the ideologies and the technology behind video games and how they have exploded into a cultural phenomenon. The evolution of gaming has seen the pendulum move from the days of games replicating society, to society replicating games. Featuring interviews with giants in the gaming industry of yesterday and today, this five-part series examines the evolution of the video game and its cultural impact on the world of entertainment today.
                            </Overview>
                            <FirstAired>2007-11-21</FirstAired>
                            <Network>Discovery</Network>
                            <IMDB_ID>tt1150772</IMDB_ID>
                            <zap2it_id>SH021365</zap2it_id>
                            <id>80877</id>
                          </Series>
                          <Series>
                            <seriesid>254597</seriesid>
                            <language>en</language>
                            <SeriesName>Master of the game</SeriesName>
                            <banner>graphical/254597-g.jpg</banner>
                            <Overview>
                              Based on the novel by Sidney Sheldon, the story spans six generations in the lives of the fictional MacGregor/Blackwell family.

                              Elderly Kate Blackwell looks back at her family's life beginning with her Scottish father Jamie McGregor's journey to South Africa to make his fortune in diamonds. The family history is littered with revenge, lust, betrayal, manipulation, and murder.
                            </Overview>
                            <FirstAired>1984-02-19</FirstAired>
                            <Network>CBS</Network>
                            <IMDB_ID>tt0086755</IMDB_ID>
                            <id>254597</id>
                          </Series>
                          <Series>
                            <seriesid>271078</seriesid>
                            <language>en</language>
                            <SeriesName>The Genius: Rule of The Game</SeriesName>
                            <Overview>A reality series pitting people identified with ""genius traits"" against one another in social games of strategy, logic, and negotiation skills. Each episode consists of a main match and a death math.  The main match decides the winner and elimination candidate for the day. The winner receives a token of life, which grants immunity from the death match, and potentially garnets, a game currency worth â‚©1,000,000 each. Garnets can be used to improve a player's chances of winning a game, as well as be traded with other players to gain favor. The elimination candidate chooses a player without a token of life to take part in a 1v1 game called the death match.  The player who loses the death match is eliminated, and the winner of the death match gains their garnets.  The last remaining player is the champion, and the total garnets held by the champion will be the final prize.</Overview>
                            <FirstAired>2013-04-26</FirstAired>
                            <Network>tvN</Network>
                            <id>271078</id>
                          </Series>
                          <Series>
                            <seriesid>77546</seriesid>
                            <language>en</language>
                            <SeriesName>The Name of the Game</SeriesName>
                            <banner>graphical/77546-g4.jpg</banner>
                            <Overview>The Name of the Game was actually three series under one title.  Each of the three stars of the show, Gene Barry, Robert Stack and Tony Franciosa were featured in their own self-contained episodes.  The connection between them was Howard Publications, a Los Angeles based publishing empire that had been built up from scratch by its dynamic owner, Glenn Howard. Howard's position of power, his confrontations with business and political enemies, and his own flamboyant lifestyle were portrayed in his portion of The Name of the Game. Within the Howard empire were investigative correspondent Jeff Dillon and editor Dan Farrell. Dillon was a super-agressive former newsboy who had clawed his way up to a position of power and respect working for Howard's People Magazine. Farrell was a former FBI agent who had gone into the publishing business because it provided a position from which to make the public aware of the threats posed by organized crime.</Overview>
                            <FirstAired>1968-09-01</FirstAired>
                            <Network>NBC</Network>
                            <id>77546</id>
                          </Series>
                          <Series>
                            <seriesid>128731</seriesid>
                            <language>en</language>
                            <SeriesName>The Beauty of the Game</SeriesName>
                            <banner>graphical/128731-g.jpg</banner>
                            <Overview>
                              ç¾Žéº—é«˜è§£åƒ
                              Setting out on their quest for fame and fortune, three female TV stars of different backgrounds are resolved to achieve their dreams at any price.  But after so many ups and downs in their acting careers, they finally come to discover the secret of true beauty.
                              Driven by sheer vanity, KO CHING MAN (Kate Tsui) takes part in a beauty pageant despite the strong opposition of her mother, a long-retired actress named CHEUNG LAI HUNG (Yuen King Tan), and leaps to stardom soon after winning the championship.  Rising actress TONG HO YEE (Sharon Chan) feels threatened by MAN and decides to join another TV station to look for a breakthrough, which is not supported by her production assistant friend DEACON CHONG (Lai Lok Yi).  Leading actress KEUNG CHIN FUNG (Ng Wing Mei) used to be a bitter rival of HUNG.  Realizing that MANâ€™s acting career is taking off at top speed, FUNG means to approach her as a mentor, through which she hopes to drag the girl into her moral downfall bit by bit.  Desperate for everlasting beauty, FUNG injects herself with illegal substances in an attempt to slow the aging process.  But things do not really go as planned and her face starts to change in shape.  Her advertising deal with a cosmetics company is subsequently canceled and MAN has soon replaced her as the new product endorser.  Even the Award of Best Actress, which she has won for years, is slipping out of her hands.  To vent her anger, FUNG seeks to extract revenge on MAN, finally plunging her into a world of pain and troubleâ€¦
                            </Overview>
                            <FirstAired>2009-12-14</FirstAired>
                            <Network>TVB</Network>
                            <id>128731</id>
                          </Series>
                          <Series>
                            <seriesid>136601</seriesid>
                            <language>en</language>
                            <SeriesName>More Than A Game - The Story of Football</SeriesName>
                            <banner>graphical/136601-g.jpg</banner>
                            <id>136601</id>
                          </Series>
                        </Data>";
        }
    }
}
