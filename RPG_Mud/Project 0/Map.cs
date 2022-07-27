namespace P0_mud
{
    public class map
    {
        bool[] visited = new bool[16];
        

        public map()
        {
            for (int i = 0; i < this.visited.Length; i++)
            {
                this.visited[i] = false;
            }
        }

        public string maplookup(int locationX, int locationY)
        {

            switch (locationX)
            {
                case 0:         
                    switch (locationY)
                    {
                        case 0:
                            Console.WriteLine("Under Construction\n Location 0-0");
                            if (visited[0])
                                Console.WriteLine("");
                            visited[0] = true;
                            break;
                        case 1:
                            Console.WriteLine("Under Construction\n Location 0-1");
                            if (visited[1])
                                Console.WriteLine("");
                            visited[1] = true;
                            break;
                        case 2:
                            if (visited[2])
                            { Console.WriteLine("Common man, Go north, it's really cool."); }
                            else
                            {
                                Console.WriteLine("Currently in demo mode. \nPlease return to the previous room to show off \na nifty feature. :)");
                                visited[2] = true;
                            }
                            break;
                        case 3:
                            if (visited[3])
                            { Console.WriteLine("It still saddens you to know that someone missed " +
                                "\nthe party. The candle still bravely burns on.\n"); }
                            else
                            {
                                Console.WriteLine("This small 10x10 foot room contains a small cake on a \nstool and a skeleton decayed beside it.\n" +
                                    "Looks like someone was waiting for a long time to give someone a suprise.\n" +
                                    "The cake is suprisingly well preserved. The candle on \ntop still seems to be burning even.");
                            }
                            visited[3] = true;
                            break;
                        default:
                            Console.WriteLine("You are in no mans land. Good luck");
                            break;

                    }
                    break;
                case 1:
                    switch (locationY)
                    {
                        case 0:
                            Console.WriteLine("Under Construction\n Location 1-0");
                            if (visited[4])
                                Console.WriteLine("");
                            visited[4] = true;
                            break;
                        case 1:
                            Console.WriteLine("Under Construction\n Location 1-1");
                            if (visited[5])
                                Console.WriteLine("");
                            visited[5] = true;
                            break;
                        case 2:
                            Console.WriteLine("Under Construction\n Location 1-2");
                            if (visited[6])
                                Console.WriteLine("");
                            visited[6] = true;
                            break;
                        case 3:
                            if (visited[7])
                            { Console.WriteLine("The sandwich is still there,\nTaunting you with it's evil."); }
                            else
                            {
                                Console.WriteLine("Somebody left a sandwich in the middle of the room.\nUpon closer inspection you realize it's a \nliverworst sandwich.\n" +
                                "What kind of monster could have left this here?\n");
                                visited[7] = true;
                            }
                            break;
                        default:
                            Console.WriteLine("You are in no mans land. Good luck");
                            break;

                    }
                    break;
                case 2:
                    switch (locationY)
                    {
                        case 0:
                            Console.WriteLine("Under Construction\n Location: 2-0");
                            if (visited[8])
                                Console.WriteLine("");
                            visited[8] = true;
                            break;
                        case 1:
                            Console.WriteLine("Under Construction\n Location: 2-1");
                            if (visited[9])
                                Console.WriteLine("");
                            visited[9] = true;
                            break;
                        case 2:
                            Console.WriteLine("This 20x20 foot room is where you woke up. Seems smaller now that you have been wondering around.\n");
                            break;
                        case 3:
                            if (visited[11])
                            { Console.WriteLine("Still got that dome lamp.\n"); }
                            else
                            {
                                Console.WriteLine("This Room is empty save for a small dome Light \nin the ceiling.\nLooks like passage ways open to the East, West \nand South.\n");
                                visited[11] = true;
                            }
                            break;
                        default:
                            Console.WriteLine("You are in no mans land. Good luck");
                            break;

                    }
                    break;
                case 3:
                    switch (locationY)
                    {
                        case 0:
                            if (visited[12])
                            { Console.WriteLine("Yep, still a creepy blood red room. Why did we come \n" +
                                "back here?\n"); }
                            else
                            {
                                Console.WriteLine("This room is lit by a light source hidden behind a \ncurtain.\n" +
                                    "The light bouncing off the walls makes them appear a \ndeep blood red.\n" +
                                    "This room is giving you the creeps, maybe it's time to move on.\n");
                            }
                            visited[12] = true;
                            break;
                        case 1:
                            Console.WriteLine("Under Construction\n Location: 3-1");
                            if (visited[13])
                                Console.WriteLine("");
                            visited[13] = true;
                            break;
                        case 2:
                            Console.WriteLine("Under Construction\n Location: 3-2");
                            if (visited[14])
                                Console.WriteLine("");
                            visited[14] = true;
                            break;
                        case 3:
                            Console.WriteLine("Under Construction\n Location: 3-3");
                            if (visited[15])
                                Console.WriteLine("");
                            visited[15] = true;
                            break;
                        default:
                            Console.WriteLine("You are in no mans land. Good luck");
                            break;

                    }
                    break;
                default:
                Console.WriteLine("You are in no mans land. Good luck");
                break;                
            }

            return "";
        }











    }

}