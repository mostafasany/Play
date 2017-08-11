using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace Core.Models.Model
{
    public class Tournament : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }

        private int noOfPlayers;
        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; RaisePropertyChanged(); }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                RaisePropertyChanged();
            }
        }

        private DateTime startedDate;
        public DateTime StartedDate
        {
            get { return startedDate; }
            set { startedDate = value; RaisePropertyChanged(); }
        }

        private List<Account> players;
        public List<Account> Players
        {
            get { return players; }
            set { players = value; RaisePropertyChanged(); }
        }

        private List<Match> matchesList;
        public List<Match> MatchesList
        {
            get { return matchesList; }
            set { matchesList = value; RaisePropertyChanged(); }
        }
    }
}
