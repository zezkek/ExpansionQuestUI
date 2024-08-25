namespace ExpansionQuestUI.Models.Items
{
    public class CollectItem
    {
        public int Amount { get; set; } = 1;
        public string ClassName { get; set; } = string.Empty;
        public int QuantityPercent { get; set; } = -1;
        public int MinQuantityPercent { get; set; } = -1;
    }
}
