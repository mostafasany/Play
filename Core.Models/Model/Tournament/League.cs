namespace Core.Models.Model
{
    public class League : Tournament
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }
    }
}
