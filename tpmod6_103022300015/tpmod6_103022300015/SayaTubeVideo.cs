using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod6_103022300015
{
     class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;
        Random random = new Random();

        public SayaTubeVideo(String title)
        {
            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul tidak lebih dari 100 kata ");
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playcount = 0;
            
        }

        public void increasePlayCount(int views) {
            Debug.Assert(views <= 10000000, "Jumlah views diantara 1 hingga 10000000");

            try
            {
                checked
                {
                    if (this.playcount > int.MaxValue - views)
                    {

                        throw new OverflowException();
                    }
                    this.playcount += views;
                }
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Terjadi Kesalahan karena sudah mencapai batas maksimum views");
                this.playcount -= views;
            }
        }

        public void printVideoDetail()
        {
            Console.WriteLine("ID video: " + this.id);
            Console.WriteLine("Judul video: " + this.title);
            Console.WriteLine("Jumlah penonton: " + this.playcount);
        }
        public int getPlaycount()
        {
            return this.playcount;
        }
    }
}
