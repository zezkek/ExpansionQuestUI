namespace ExpansionQuestUI.Models.Items
{
    public class Loot
    {
        public string Name { get; set; } = string.Empty;
        public double Chance { get; set; }
        public List<string> Attachments { get; set; }
        public int QuantityPercent { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public List<string> Variants { get; set; }
    }
}
