using ExpansionQuestUI.Models.Items;

namespace ExpansionQuestUI.Models.Objectives
{
    public class Collect
    {
        public int ConfigVersion { get; set; } = 28;
        public int ID { get; set; }
        public int ObjectiveType { get; set; } = 4;
        public string ObjectiveText { get; set; } = string.Empty;
        public int TimeLimit { get; set; } = -1;
        public int Active { get; set; } = 1;
        public List<CollectItem> Collections { get; set; }
        public int ShowDistance { get; set; } = 0;
        public int AddItemsToNearbyMarketZone { get; set; } = 0;
        public int NeedAnyCollection { get; set; } = 0;
    }
}
