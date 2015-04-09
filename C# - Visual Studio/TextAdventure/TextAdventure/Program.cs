using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1H, aIH, p1Mana, aIMana;
            string player;
            string element;
            string elementDesc;
            string tempans;
            string gameOver = @"_______  _______  _______  _______            _______           _______  _______  _ 
(  ____ \(  ___  )(       )(  ____ \          (  ___  )|\     /|(  ____ \(  ____ )( )
| (    \/| (   ) || () () || (    \/          | (   ) || )   ( || (    \/| (    )|| |
| |      | (___) || || || || (__              | |   | || |   | || (__    | (____)|| |
| | ____ |  ___  || |(_)| ||  __)             | |   | |( (   ) )|  __)   |     __)| |
| | \_  )| (   ) || |   | || (                | |   | | \ \_/ / | (      | (\ (   (_)
| (___) || )   ( || )   ( || (____/\          | (___) |  \   /  | (____/\| ) \ \__ _ 
(_______)|/     \||/     \|(_______/          (_______)   \_/   (_______/|/   \__/(_)
                                                                                     ";
            bool error = false;
            Player playerinfo = new Player();
            Enemy enemyinfo = new Enemy();
            p1H = playerinfo.getHP();
            p1Mana = playerinfo.getMana();
            aIH = enemyinfo.getHP();
            aIMana = enemyinfo.getMana();
            Console.WriteLine("Please insert your name to begin your adventure!");
            playerinfo.setPlayerName(Console.ReadLine());
            player = playerinfo.getPlayerName();
            Console.Clear();
            Console.WriteLine("\tThis story begins with a young man named {0}. He is an apprentice wizard who has studied under the tutelage of Avira the Radiant for five years.\n They practice the Arcane Arts in a secluded domain created by Avira inside of\n New York City hidden away from prying eyes.", player);
            Console.Write("Avira once had a student by the name of Stithix; he showed great promise but had evil in his heart unlike {0}. When Avira saw Stithix cast an nefarious spell raising the undead, She exiled him into another realm. Stithix swore revenge against her as he was tumbling into the unknown.",player);
            Console.WriteLine("After many centuries Stithix broke free from his dark prison. In all that time spent, he thought of nothing but revenge and sought Avira out to do just that...\n\n <Press any key to continue...>");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("One day during a lesson with Lady Avira. You were informed you had to choose a elemental mastery to attune with as mages typically can master only one element.\n1)fire \n2)water \n3)earth \n4)air",player);
            playerinfo.setElementalMastery();
            element = playerinfo.getElementalMastery();
            elementDesc = playerinfo.getElementalDesc();
            Console.WriteLine("You have learned the spell: ({0}), {1}",element, elementDesc);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("You finish up your lesson and Lady Avira insists you get some rest after the strenous day. You go back to your room, crash on the bed and go to sleep.");
            Console.WriteLine("You wake up startled by a loud noise coming from the other end of the building. What do you do? \n1)Get your britches on and rush to see what's wrong.\n2)Rush to the scene in your jammies.\n3)Fall back asleep.");
            //EVENT 1
            while (error == false)
            {
                tempans = Console.ReadLine();
                Console.Clear();
                switch (tempans)
                {
                    case "1":
                        Console.Write("\tYou successfully get your britches on and rush out to see a hooded figure haul Lady Avira in-tow.");
                        error = true;
                        break;
                    case "2":
                        Console.WriteLine("\tYou rush out in your jammies to see an argument occuring between your master and a mysterious hooded man. You hear Lady Avira say (Curse you Stithix I should have killed you when I had the chance!)The hooded figure then mutters a spell and with a flash Avira was entombed in a white veil of ice and carried off by the figure. As the figure was making his way out the door he noticed you in your jammies and says (If you wish to save your master meet me in my realm and prove yourself).");
                        error = true;
                        break;
                    case "3":
                        Console.WriteLine("\tYou fall back asleep and awake to find that avira had gone missing in the night. You search and search for her but cannot find her. With no master to train you in the arcane arts you slowly lose your powers and become a normal person");
                        Console.WriteLine(gameOver);
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You failed to choose a correct number please choose \n1)Britches\n2)Jammies\n3)Sleep");
                        break;
                }
            }
            //end of event 1
            Console.Write("\tYou quickly try to cast {0} but he vanishes leaving only some kind of mysterious trail of magic dust behind him. You can't help but wonder if this is some kind of trap but you are left no choice but to follow the figure to try and save your master before it's too late",element);
            Console.WriteLine("You follow the trail into the sewers and come across a strange magical enemy!...The Mud Monster created of the two elements Water and Earth.\n1)Try to sneak by The Mud Monster\n2)Cast your spell\n3)Fight him without your spell");
            //EVENT 2
            while (error == true)
            {
                tempans = Console.ReadLine();
                Console.Clear();
                switch (tempans)
                {
                    case "1":
                        Console.WriteLine("You successfully evade your opponent but you contemplate if it is wise to avoid combat when you need to practice to beat a powerful wizard such as Stithix ... Narrator : (idiot)");
                        error = false;
                        break;
                    case "2":
                        if (element == "Fireball")
                        {
                            Console.WriteLine("You cast Fireball and it was super effective the Mud Monster dries out and hardens. You celebrate and continue to follow the Magic Dust");
                        }
                        else if (element == "Water Elemental")
                        {
                            Console.WriteLine("You cast Water Elemental. It was not very effective but the water elemental manages communicate and brefriend the monster allowing you passage");
                        }
                        else if (element == "Stone Fist")
                        {
                            Console.WriteLine("You cast Stone Fist. You attempt to throw punches at the Mud Monster but the Mud Monster absorbs the punches. The mud creeps up your arm until your enveloped and you suffocate");
                            Console.WriteLine(gameOver);
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("You cast Fleet of Foot. The Mud Monster and you attempt to duke it out but the Mud Monster can't keep up with your speed he chases you for several hours until all his magical energy fades away granting you passage");
                        }
                        error = false;
                        break;
                    case "3":
                        Console.WriteLine("You stand before the might Mud Monster and unleash a mighty belch. The Mud Monster stares at you bewildered and confused and not sure what to make of you. Without wasting another moment the Mud Monster envelops you and you slowly suffocate.");
                        Console.WriteLine(gameOver);
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You failed to choose a correct number please choose \n1)Sneak by\n2)Cast a spell\n3)Fight with your fists");
                        break;
                }
            }
            //end of event 2
            Console.WriteLine("You continue to follow the mana trail into the sewers. You come upon a crossroads in the sewer where the trail vanishes. What do you do? \n1)Go left \n2)Go straight \n3)Go right");
            //Event 3
            while (error == false)
            {
                tempans = Console.ReadLine();
                Console.Clear();
                switch (tempans)
                {
                    case "1":
                        Console.WriteLine("You go down the left path. It's pitch black you attempt to feel for the wall as you walk along. You stumble and fall 30 feet to your death.");
                        Console.WriteLine(gameOver);
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case "2":
                        Console.WriteLine("You chose the straight path. Narrator : (You're not very original are you?)");
                        error = true;
                        break;
                    case "3":
                        Console.WriteLine("You chose the right path. Narrator : (Insert pun here; no, you actually chose the right path)");
                        error = true;
                        break;
                    default:
                        Console.WriteLine("You failed to choose a correct number please choose \n1)Left path\n2)Straight path\n3)Right path");
                        break;
                }
            }
            //end of event 3
            Console.WriteLine("You see a light at the end of the tunnel. You wonder if it is natural sunlight or man-made. You approach the light with caution but you reach the end of the tunnel. You come out into a large chamber with a strange portal in the center. Throwing caution to the wind you plunge into the portal. ");
            Console.WriteLine();
            Console.WriteLine("You emerge from the portal and take a look around. You see that you are in an enclosed area and that there is sand at your feet. You evaluate that you must be somewhere in Egypt possibly even inside of a pyramid. You see a chamber at the end of the hall and make your way towards it. A figure resembling a mummy falls down in front of you. The mummy tries to mutter something incoherent What do you do? \n1)Cast your spell\n2)Jeer at mummy\n3)Survey your surroundings");
            //Event 4
            while (error == true)
            {
                tempans = Console.ReadLine();
                Console.Clear();
                switch (tempans)
                {
                    case "1":
                        if (element == "Fireball")
                        {
                            Console.WriteLine("You cast fireball at the mummy and his rags burn exposing his naked manhood. Your eyes literally burn out of your skull. You died!");
                            Console.WriteLine(gameOver);
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (element == "Water Elemental")
                        {
                            Console.WriteLine("You cast Water Elemental. You attempt to fight him with the Water Elemental but it was proving to be a difficult fight so you let the Water Elemental distract as you pass by.");
                        }
                        else if (element == "Stone Fist")
                        {
                            Console.WriteLine("You cast Stone Fist. You throw a single punch at the mummy and he disengrates into dust. You ponder why that was so effective but continue on your path.");
                            
                        }
                        else
                        {
                            Console.WriteLine("You cast Fleet of Foot. You attempt to run up a wall to leap on him but lose momentum and fall. You crack your skull and die.");
                            Console.WriteLine(gameOver);
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        error = false;
                        break;
                    case "2":
                        Console.WriteLine("You say (What's wrong mummy did your mummy abandon you?) The mummy taking great offense to that comment goes into a fit of rage and one shots you. You are dead!");
                        Console.WriteLine(gameOver);
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case "3":
                        Console.WriteLine("You notice a sarcophagus in the corner. You realize you could trap him in the sarcophagus. You run around the sarcophagus until the mummy gets into position and you successfully catch him.");
                        error = false;
                        break;
                    default:
                        Console.WriteLine("You failed to choose a correct number please choose \n1)Cast\n2)Jeer\n3)Look around");
                        break;
                }
            }
            //end Event 4
            Console.WriteLine("\tYou find your way out of the pyramid. Then, out of nowhere Stithix appears laughing at you mainacally. He says to you that he is actually your father. Confused and filled with many different emotions you are unsure what to do.\n1)Join Stithix\n2)Fight Stithix\n3)Commit Suicide");
            // Event 5
            while (error == false)
            {
                tempans = Console.ReadLine();
                Console.Clear();
                switch (tempans)
                {
                    case "1":
                        Console.WriteLine("Happy to finally reunite with you long lost father you end up going over to his place and watch the entire star wars series forgetting all about your old master.");
                        Console.WriteLine("YOU WIN!");
                        error = true;
                        break;
                    case "2":
                        Console.WriteLine("You pull out your sword and prepare for battle!");
                        Console.ReadKey();
                        byte i = 5;
                        error = true;
                        //Start of the Fight
                        while (aIH >= 0 && p1H >= 0)
                        {
                            //start of your turn
                            bool error1 = false;
                            Console.WriteLine("It's your turn. Which attack would you like to use: \n1)One-Hand Slash\n2)Berzerk {0}\n3)Fireball\n4)Meditate",i);
                            while (error1 == false)
                            {
                                tempans = Console.ReadLine();
                                Console.Clear();
                                switch (tempans)
                                {
                                    case "1":
                                        Console.WriteLine("You slash Stithix for 15!");
                                        Console.ReadKey();
                                        aIH = aIH - 15;
                                        error1 = true;
                                        break;
                                    case "2":
                                        if (i == 0)
                                        {
                                            goto default;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You go Berzerk on Stithix and deal 30 damage you have {0} Berzerk tokens left!", i);
                                            Console.ReadKey();
                                            aIH = aIH - 30;
                                            i--;
                                            error1 = true;
                                            break;
                                        }
                                    case "3":
                                        if (p1Mana <= 0)
                                        {
                                            goto default;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You use Fireball and deal 25 damage!");
                                            Console.ReadKey();
                                            aIH = aIH - 25;
                                            p1Mana = p1Mana - 30;
                                            error1 = true;
                                            break;
                                        }
                                    case "4":
                                        Console.WriteLine("You regain 1 Berzerk token and 25 mana");
                                        Console.ReadKey();
                                        if (p1Mana < 100)
                                        {
                                            p1Mana = p1Mana + 25;
                                        }
                                        i++;
                                        error1 = true;
                                        break;
                                    default:
                                        Console.WriteLine("You failed to input a correct attack, have ran out of Berzerk tokens or have ran out of Mana. Please try 1)Slash 2)Berzerk 3)Fireball 4)Meditate");
                                        break;
                                }
                            }
                            //Ally conclusion
                            Console.WriteLine("Your current health {0}/150 and mana {1}/100. Enemy current health {2}/250 and mana {3}/100",p1H, p1Mana, aIH, aIMana);
                            Console.ReadKey();
                            //Enemy Turn
                            if (p1Mana < 100)
                            {
                                p1Mana = p1Mana + 5;
                            }
                            Random rnd = new Random();
                            int rngjesus = rnd.Next(1, 100);
                            if (rngjesus >= 65 && rngjesus <= 100)
                            {
                                if (aIMana <= 0)
                                {
                                    Console.WriteLine("Stithix has ran out of mana. He meditates to gain 20 mana");
                                    Console.ReadKey();
                                    aIMana = aIMana + 20;
                                }
                                else
                                {
                                    Console.WriteLine("Stithix Lightning Bolts you for 15 damage.");
                                    Console.ReadKey();
                                    aIMana = aIMana - 15;
                                    p1H = p1H - 15;
                                }
                            }
                            else if (rngjesus >= 50 && rngjesus <= 64)
                            {
                                if (aIMana <= 0)
                                {
                                    Console.WriteLine("Stithix has ran out of mana. He meditates to gain 20 mana");
                                    Console.ReadKey();
                                    aIMana = aIMana + 20;
                                }
                                else
                                {
                                    Console.WriteLine("Stithix calls upon the Darkness within dealing 50 damage.");
                                    Console.ReadKey();
                                    p1H = p1H - 50;
                                    aIMana = aIMana - 20;
                                }
                            }
                            else if (rngjesus >= 30 && rngjesus <= 49)
                            {
                                Console.WriteLine("Stithix fails to hit you with anything...");
                                Console.ReadKey();
                            }
                            else if (rngjesus >= 10 && rngjesus <= 29)
                            {
                                Console.WriteLine("Stithix summons a familiar that gives him 50 mana.");
                                Console.ReadKey();
                                if (aIMana < 100)
                                    aIMana = aIMana + 50;
                            }
                            else
                            {
                                Console.WriteLine("Stithix watches his skin grow... gain 5 health.");
                                Console.ReadKey();
                                if (aIH < 250)
                                    aIH = aIH + 5;
                            }
                            //Enemy conclusion
                            Console.WriteLine("Your current health {0}/150 and mana {1}/100. Enemy current health {2}/250 and mana {3}/100", p1H, p1Mana, aIH, aIMana);
                            Console.ReadKey();
                        }
                        if(aIH <= 0)
                        {
                            Console.WriteLine("You and Stithix end up battling for many hours. You finally end up defeating him. Narrator: (Sorry but your princess is in another castle)");
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Even against your best efforts you have failed to save your master. The world around you fades to black and you die.");
                            Console.WriteLine(gameOver);
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }
                    case "3":
                        Console.WriteLine("You pull your sword out and plunge it into your chest. Everything around you turns to black. You die.");
                        Console.WriteLine(gameOver);
                        Console.ReadKey();
                        Environment.Exit(0);
                        error = true;
                        break;
                    default:
                        Console.WriteLine("You failed to choose a correct number please choose \n1)Join\n2)Kill\n3)Suicide");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
