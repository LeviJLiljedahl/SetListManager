//Author: Levi Liljedahl
//Date: 04/29/2024
//Purpose: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetListManager
{
    internal class Song
    {

        // Class level Variables

        private string cSongID;
        private string cSongName;
        private string cSongOriginalArtist;
        private string cSongAsPerformedBy;
        private string cSongLength;
        private string cSongRating;

        // Getters and Setters for class variables

        public string SongID
        { get { return cSongID; } set { cSongID = value; } }

        public string SongName
        { get { return cSongName; } set { cSongName = value; } }

        public string SongOriginalArtist
        { get { return cSongOriginalArtist; } set { cSongOriginalArtist = value; } }

        public string SongAsPerformedBy
        { get { return cSongAsPerformedBy; } set { cSongAsPerformedBy = value; } }

        public string SongLength
        { get { return cSongLength; } set { cSongLength = value; } }

        public string SongRating
        { get { return cSongRating; } set { cSongRating = value; } }

        // Default Constructor

        public Song()
        {

            cSongID = string.Empty;
            cSongName = string.Empty;
            cSongOriginalArtist = string.Empty;
            cSongAsPerformedBy = string.Empty;
            cSongLength = string.Empty;
            cSongRating = string.Empty;

        }

        // Overloaded Constructor

        public Song(string SongID)
        {
            cSongID = SongID;
            cSongName = string.Empty;
            cSongOriginalArtist = string.Empty;
            cSongAsPerformedBy = string.Empty;
            cSongLength = string.Empty;
            cSongRating = string.Empty;
        }

        //Methods

        // Override to string for listbox
        public override string ToString()
        {
            return cSongID + " - " + cSongName;
        }
    }
}
