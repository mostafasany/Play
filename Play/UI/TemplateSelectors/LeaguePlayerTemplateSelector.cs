using Core.Models.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UI.TemplateSelectors
{
    public class LeaguePlayerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RankOneTemplate { get; set; }
        public DataTemplate OtherPlayerTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            Account account = item as Account;
            if (account != null)
            {
                if (account.Rank == 1)
                    return RankOneTemplate;
                else
                    return OtherPlayerTemplate;
            }
            return base.SelectTemplateCore(item);
        }
    }
}
