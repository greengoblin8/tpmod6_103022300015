using System;
namespace tpmod6_103022300015
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial design by contract - Gamaliel Pradana");
                video.printVideoDetail();
                Console.WriteLine();
                for (int i = 0; i < 1000; i++)
                {
                    video.increasePlayCount(10000000);
                    video.printVideoDetail();
                    Console.WriteLine();

                    if (video.getPlaycount() == int.MaxValue)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!" + e.Message);
            }

        }
    }
}