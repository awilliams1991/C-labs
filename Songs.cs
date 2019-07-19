using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Songs
    {

        /*
         * 9. Song
a. artist – string
b. title – string
c. lengthInSeconds – int
         * */

        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        public Songs(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }//end FQCTOR

        public Songs() { }//end generic ctor

        public override string ToString()
        {
            return string.Format($"{Artist}\n{Title}\nSong Length: {LengthInSeconds} seconds");
        }
    }//end class
}//end namespace
