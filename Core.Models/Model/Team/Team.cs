using GalaSoft.MvvmLight;
using Core.Models.Enum;
using System.Collections.Generic;

namespace Core.Models.Model
{
    public class Team : ViewModelBase
    {
        public TeamTypeEnum MatchType { get; set; }

        private string teamName;
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// In Case of Single Team , Players will contains only one player
        /// In Case of Multi Team , Players will contains only many players
        /// </summary>
        private List<Account> players;
        public List<Account> Players
        {
            get { return players; }
            set { players = value; RaisePropertyChanged(); }
        }

        public int Played { get; set; }
        public int W { get; set; }
        public int L { get; set; }
        public int D { get; set; }
        public int F { get; set; } //For
        public int A { get; set; } //Against
        public int GD { get { return F - A; } } //Goal Differnece

        public virtual void Win(Score score)
        {
            W++;
            F += score.Team1Score;
            A += score.Team2Score;
        }

        public virtual void Lose(Score score)
        {
            L--;
            F += score.Team1Score;
            F += score.Team2Score;
        }

        public virtual void Draw(Score score)
        {

        }
    }
}
