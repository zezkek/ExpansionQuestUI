namespace ExpansionQuestUI.Models
{
    public class Reward : QuestItem
    {
        public List<string> Attachments { get; set; } = [];
        public int DamagePercent { get; set; }
        public int QuestID { get; set; } = -1;
        public double Chance { get; set; }
    }
}
