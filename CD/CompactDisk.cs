using System;
using System.Collections.Generic;
using System.Text;

namespace CD
{
    /// <summary>
    /// Data structure for a CD
    /// Holds CD name, artist, genre, price and a list of tracks
    /// </summary>
    class CompactDisk
    {
        public String name;
        public String artist;
        public String genre;
        public String price;
        private Track[] tracks;

        public CompactDisk(String name, String artist, String genre, String price)
        {
            this.name = name;
            this.artist = artist;
            this.genre = genre;
            this.price = price;
            this.tracks = new Track[0]; //TODO not implemented
        }

        /// <summary>
        /// Get the track listing
        /// </summary>
        /// <returns>an array of Track objects</returns>
        public Track[] TrackList()
        {
            return (Track[])tracks.Clone();
        }
        /// <summary>
        /// Get the desired track
        /// </summary>
        /// <param name="number">the number of the track, indexed from 1</param>
        /// <returns>the track asked for</returns>
        public Track Track(int number)
        {
            if (number < 1 || number > tracks.Length)
            {
                return null;
            }
            else return tracks[number - 1];
        }

        public override String ToString()
        {
            return "Name: " + name +"\nArtist: " + artist +"\nGenre: " + genre +"\nPrice: " + price +"\nTracks: " + tracks.Length +"\n";
        }
    }
}
