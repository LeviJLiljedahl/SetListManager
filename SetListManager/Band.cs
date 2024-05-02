//Author: Levi Liljedahl
//Date: 04/29/2024
//Purpose: Manage the Band

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetListManager
{
    internal class Band
    {
        // Class level Variables

        private string cBandID;
        private string cBandName;
        private string cBandMembers;
        private string cBandGenre;

        // Getters and Setters for class variables
        public string BandID 
        { get { return cBandID; } set { cBandID = value; } }

        public string BandName 
        { get { return cBandName; } set { cBandName = value; } }

        public string BandMembers 
        { get { return cBandMembers; } set { cBandMembers = value; } }

        public string BandGenre 
        { get { return cBandGenre; } set { cBandGenre = value; } }

        //Default Constructor
        public Band()
        {
            cBandID = string.Empty;
            cBandName = string.Empty;
            cBandMembers = string.Empty;
            cBandGenre = string.Empty;
        }

        //Overload Constructor
        public Band(string BandID)
        {
            cBandID = BandID;
            cBandName = string.Empty;
            cBandMembers = string.Empty;
            cBandGenre = string.Empty;
        }

        //Methods

        // Override to string for listbox
        public override string ToString()
        {
            return cBandID + " - " + cBandName;
        }
    }
}
