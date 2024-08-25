using ExpansionQuestUI.Models.Items;

namespace ExpansionQuestUI.Models.Objectives
{
    public class Treasure
    {
        public int ConfigVersion { get; set; } = 28;
        public int ID { get; set; }
        public int ObjectiveType { get; set; } = 6;
        public string ObjectiveText { get; set; } = string.Empty;
        public int TimeLimit { get; set; } = -1;
        public int Active { get; set; } = 1;
        public int ShowDistance { get; set; } = 0;
        public string ContainerName { get; set; }
        public int DigInStash { get; set; }
        public string MarkerName { get; set; }
        public int MarkerVisibility { get; set; }
        public List<List<double>> Positions { get; set; }
        public int LootItemsAmount { get; set; }
        public double MaxDistance { get; set; }
        public List<Loot> Loot { get; set; }
    }
}
