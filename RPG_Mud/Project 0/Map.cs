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
                            Console.WriteLine("Current Location 0,0");
                            break;
                        case 1:
                            Console.WriteLine("Current Location 0,1");
                            break;
                        case 2:
                            Console.WriteLine("Current Location 0,2");
                            break;
                        case 3:
                            Console.WriteLine("Current Location 0,3");
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
                            Console.WriteLine("Current Location 1,0");
                            break;
                        case 1:
                            Console.WriteLine("Current Location 1,1");
                            break;
                        case 2:
                            Console.WriteLine("Current Location 1,2");
                            break;
                        case 3:
                            Console.WriteLine("Current Location 1,3");
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
                            Console.WriteLine("Current Location 2,0");
                            break;
                        case 1:
                            Console.WriteLine("Current Location 2,1");
                            break;
                        case 2:
                            Console.WriteLine("Current Location 2,2");
                            break;
                        case 3:
                            Console.WriteLine("Current Location 2,3");
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
                            Console.WriteLine("Current Location 3,0");
                            break;
                        case 1:
                            Console.WriteLine("Current Location 3,1");
                            break;
                        case 2:
                            Console.WriteLine("Current Location 3,2");
                            break;
                        case 3:
                            Console.WriteLine("Current Location 3,3");
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