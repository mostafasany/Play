using Core.Models.Enum;

namespace Core.Models.Model
{
    public class Cup : Tournament
    {
        public CupTypeEnum CupType { get; set; }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }
    }
}
