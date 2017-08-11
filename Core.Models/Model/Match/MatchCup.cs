namespace Core.Models.Model
{
    public class MatchCup : Match
    {
        private int _Round;
        public int Round
        {
            get { return _Round; }
            set { _Round = value; RaisePropertyChanged(); }
        }

        private int _NextMatchId;
        public int NextMatch
        {
            get { return _NextMatchId; }
            set { _NextMatchId = value; RaisePropertyChanged(); }
        }

    }
}
