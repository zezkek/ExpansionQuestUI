namespace ExpansionQuestUI.Models.Objectives
{
    public class Travel
    {
        public int ConfigVersion { get; set; } = 28;
        public int ID { get; set; }
        public int ObjectiveType { get; set; } = 3;
        public string ObjectiveText { get; set; } = string.Empty;
        public int TimeLimit { get; set; } = -1;
        public int Active { get; set; } = 1;
        public List<double> Position { get; set; } =
        [
            0.0, 0.0, 0.0
        ];
        public double MaxDistance { get; set; } = -1.0;
        public string MarkerName { get; set; } = string.Empty;
        public int ShowDistance { get; set; }
        public int TriggerOnEnter { get; set; }
        public int TriggerOnExit { get; set; }
    }
}
