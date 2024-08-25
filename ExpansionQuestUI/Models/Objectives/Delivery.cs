using ExpansionQuestUI.Models.Items;

namespace ExpansionQuestUI.Models.Objectives
{
    public class Delivery
    {
        public int ConfigVersion { get; set; } = 28;
        public int ID { get; set; }
        public int ObjectiveType { get; set; } = 5;
        public string ObjectiveText { get; set; } = string.Empty;
        public int TimeLimit { get; set; } = -1;
        public int Active { get; set; } = 1;
        public List<CollectItem> Collections { get; set; }
        public int ShowDistance { get; set; } = 0;
        public int AddItemsToNearbyMarketZone { get; set; } = 0;
        public double MaxDistance { get; set; }
        public string MarkerName { get; set; } = string.Empty;
    }
}
