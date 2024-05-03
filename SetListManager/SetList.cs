//Author: Levi Liljedahl
//Date: 04/29/2024
//Purpose: Manage the SetList

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetListManager
{
    internal class SetList
    {
        // Class level Variables

        private string cSetListID;
        private string cSetListName;
        private string cSetListOverallMood;
        private string cSetListRating;
        private string cSetListNumberOfSongs;
        private string cSetListDuration;

        // Getters and Setters for class variables

        public string SetListID 
            {  get { return cSetListID; } set { cSetListID = value; } }

        public string SetListName 
            { get { return cSetListName; } set { cSetListName = value; } }

        public string SetListOverallMood 
            {  get {  return cSetListOverallMood; } set { cSetListOverallMood = value; } }

        public string SetListRating 
            {  get { return cSetListRating; } set { cSetListRating = value; } }

        public string SetListNumberOfSongs 
            { get {  return cSetListNumberOfSongs; } set { cSetListNumberOfSongs = value; } }

        public string SetListDuration 
            {  get { return cSetListDuration; } set { cSetListDuration = value; } }

        // Default Constructor

        public SetList ()
        {
            cSetListID = string.Empty;
            cSetListName = string.Empty;
            cSetListOverallMood = string.Empty;
            cSetListRating = string.Empty;
            cSetListNumberOfSongs = string.Empty;
            cSetListDuration = string.Empty;
        }

        // Overloaded Constructor

        public SetList(string SetListID)
        {
            cSetListID = SetListID;
            cSetListName = string.Empty;
            cSetListOverallMood = string.Empty;
            cSetListRating = string.Empty;
            cSetListNumberOfSongs = string.Empty;
            cSetListDuration = string.Empty;
        }

        //Methods

        // Override to string for listbox
        public override string ToString()
        {
            return cSetListID + " - " + cSetListName;
        }
    }
}
