namespace ExpansionQuestUI.Models
{
    public class Quest
    {
        public int ConfigVersion { get; set; } = 22;
        public int ID { get; set; }
        public int Type { get; set; } = 1;
        public string Title { get; set; } = string.Empty;
        public List<string> Descriptions { get; set; } = new List<string>()
        {
            string.Empty,
            string.Empty,
            string.Empty
        };
        public string ObjectiveText { get; set; } = string.Empty;
        public int FollowUpQuest {  get; set; }
        public int Repeatable { get; set; }
        public int IsDailyQuest { get; set; }
        public int IsWeeklyQuest { get; set; }
        public int CancelQuestOnPlayerDeath {  get; set; }
        public int Autocomplete { get; set; }
        public int IsGroupQuest { get; set; }
        public string ObjectSetFileName { get; set; } = string.Empty;
        public List<QuestItem> QuestItems { get; set; } = [];
        public List<Reward> Rewards { get; set; } = [];
        public int NeedToSelectReward { get; set; }
        public int RandomReward { get; set; }
        public int RandomRewardAmount { get; set; } = -1;
        public int RewardsForGroupOwnerOnly { get; set; }
        public int RewardBehavior { get; set; }
        public List<int> QuestGiverIDs { get; set; } = [];
        public List<int> QuestTurnInIDs { get; set; } = [];
        public int IsAchievement { get; set; }
        public List<Objective> Objectives { get; set; } = [];
        public int QuestColor { get; set; }
        public int ReputationReward { get; set; }
        public int ReputationRequirement { get; set; } = -1;
        public List<int> PreQuestIDs { get; set; } = [];
        public string RequiredFaction { get; set; } = string.Empty;
        public string FactionReward { get; set; } = string.Empty;
        public int PlayerNeedQuestItems { get; set; }
        public int DeleteQuestItems { get; set; }
        public int SequentialObjectives { get; set; }
        public Dictionary<string, int> FactionReputationRequirements { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> FactionReputationRewards { get; set; } = new Dictionary<string, int>();
        public int SuppressQuestLogOnCompetion { get; set; } = 0;
        public int Active { get; set; } = 1;
    }
}
