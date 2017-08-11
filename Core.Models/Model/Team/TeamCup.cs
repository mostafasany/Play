namespace Core.Models.Model
{
    public class TeamCup : Team
    {
        public override void Win(Score score)
        {
            base.Win(score);
        }

        public override void Lose(Score score)
        {
            base.Lose(score);
        }
    }
}
