namespace ExpansionQuestUI.Models.Objectives
{
    public class Target
    {
        public int ConfigVersion { get; set; } = 28;
        public int ID { get; set; }
        public int ObjectiveType { get; set; } = 2;
        public string ObjectiveText { get; set; } = string.Empty;
        public int TimeLimit { get; set; } = -1;
        public int Active { get; set; } = 1;
        public List<double> Position { get; set; } =
        [
            0.0, 0.0, 0.0
        ];
        public double MaxDistance { get; set; } = -1.0;
        public double MinDistance { get; set; } = -1.0;
        public double Amount { get; set; }
        public List<string> ClassNames { get; set; } = [];
        public int CountSelfKill { get; set; }
        public List<string> AllowedWeapons { get; set; }
        public List<string> ExcludedClassNames { get; set; }
        public int CountAIPlayers { get; set; }
        public List<string> AllowedTargetFactions { get; set; }
        public List<string> AllowedDamageZones { get; set; }

    }
}
