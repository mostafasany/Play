using GalaSoft.MvvmLight;

namespace Core.Models.Model
{
    public class Score : ViewModelBase
    {
        private int team1Score;
        public int Team1Score
        {
            get { return team1Score; }
            set { team1Score = value; RaisePropertyChanged(); }
        }

        private int team2Score;
        public int Team2Score
        {
            get { return team2Score; }
            set { team2Score = value; RaisePropertyChanged(); }
        }
    }
}
