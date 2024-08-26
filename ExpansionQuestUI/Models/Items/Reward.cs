namespace ExpansionQuestUI.Models.Items
{
    public class Reward
    {
        //Не наследую questitem потому что ломается очередность
        public string ClassName { get; set; } = string.Empty;
        public int Amount { get; set; } = 0;
        public List<string> Attachments { get; set; }
        public int DamagePercent { get; set; }
        public int QuestID { get; set; } = -1;
        public double Chance { get; set; }
    }
}
