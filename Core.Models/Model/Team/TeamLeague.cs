namespace Core.Models.Model
{
    public class TeamLeague : Team
    {
        public int Pts { get; set; }

        public override void Draw(Score score)
        {
            D++;
            Pts += 1;
        }

        public override void Win(Score score)
        {
            base.Win(score);
            Pts += 3;
        }

        public override void Lose(Score score)
        {
            base.Lose(score);
        }
    }
}
