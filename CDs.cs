using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CDs //: Songs
    {
        /*
         * 10. CD
a. tracks – Song[]
b. title – string
c. genre – string
         * */

        
        public string Genre { get; set; }
        public string[] Songs { get; set; }
        public string Artist { get; set; }

        public CDs(string Artist, string genre, string[] song)
            //:base (artist, name, lengthInSeconds)
        {
            Genre = genre;
            Songs = song;
        }//end FQCTOR

        public CDs() { }//end generic ctor

        public override string ToString()
        {
            string songPlaceholder = "";
            foreach (string song in Songs)
            {
                
                //Console.WriteLine(song);
                songPlaceholder  += song + "\n";
            }//end foreach
            return string.Format("\n Artist: " + Artist + "\nGenre: " + Genre + "\nSongs: " + songPlaceholder); 
        }//end string override


    }//end class
}//end namespace3
