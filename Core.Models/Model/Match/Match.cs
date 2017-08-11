using GalaSoft.MvvmLight;
using Core.Models.Enum;
using System;

namespace Core.Models.Model
{
    public class Match : ViewModelBase
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }

        private Team team1;
        public Team Team1
        {
            get { return team1; }
            set { team1 = value; RaisePropertyChanged(); }
        }

        private Team team2;
        public Team Team2
        {
            get { return team2; }
            set { team2 = value; RaisePropertyChanged(); }
        }

        private DateTime startedDateTime;
        public DateTime StartedDateTime
        {
            get { return startedDateTime; }
            set { startedDateTime = value; RaisePropertyChanged(); }
        }

        public ScoreEnum ScoreEnum { get; set; }

        private Score score;
        public Score Score
        {
            get { return score; }
            set { score = value; RaisePropertyChanged(); }
        }

    }
}
