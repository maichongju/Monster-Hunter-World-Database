using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class Monster
    {
        public int MonsterID { get; }
        public string Name { get; }
        public string Size { get; }
        public string Ecology { get; }
        public string Description { get; }
        public string AltStateDescription { get; }
        private List<MonsterAilment> _monsterailments;

        public List<MonsterAilment> MonsterAilments
        {
            get
            {
                if (_monsterailments == null)
                {
                    _monsterailments = new List<MonsterAilment>();
                }
                return _monsterailments;
            }
            set => _monsterailments = value;
        }

        private List<MonsterBreak> _monsterbreak;

        public List<MonsterBreak> MonsterBreaks
        {
            get
            {
                if (_monsterbreak == null)
                {
                    _monsterbreak = new List<MonsterBreak>();
                }
                return _monsterbreak;
            }
            set => _monsterbreak = value;
        }

        private List<MonsterHitZone> _monsterhitzone;

        public List<MonsterHitZone> MonsterHitZones
        {
            get
            {
                if (_monsterhitzone == null)
                {
                    _monsterhitzone = new List<MonsterHitZone>();
                }
                return _monsterhitzone;
            }
            set => _monsterhitzone = value;
        }

        private Dictionary<string, Dictionary<string, List<MonsterReward>>> _monsterreward;

        public Dictionary<string, Dictionary<string, List<MonsterReward>>> MonsterRewards
        {
            get
            {
                if (_monsterreward == null)
                {
                    _monsterreward = new Dictionary<string, Dictionary<string, List<MonsterReward>>>()
                    {
                        {"LR",new Dictionary<string,List<MonsterReward>>() },
                        {"HR",new Dictionary<string,List<MonsterReward>>() }
                    };
                }
                return _monsterreward;
            }
            set => _monsterreward = value;
        }

        private List<MonsterWeakness> _monsterweakness;

        public List<MonsterWeakness> MonsterWeakness
        {
            get
            {
                if (_monsterweakness == null)
                {
                    _monsterweakness = new List<MonsterWeakness>();
                }
                return _monsterweakness;
            }
            set => _monsterweakness = value;
        }

        private List<MonsterWeakness> _monsteraltweakness;

        public List<MonsterWeakness> MonsterAltWeakness
        {
            get
            {
                if (_monsteraltweakness == null)
                {
                    _monsteraltweakness = new List<MonsterWeakness>();
                }
                return _monsteraltweakness;
            }
            set => _monsteraltweakness = value;
        }

        public Monster(TempMonster monster)
        {
            MonsterID = monster.MonsterID;
            Name = monster.Name;
            Size = monster.Size;
            Ecology = monster.Ecology;
            Description = monster.Description;
            MonsterWeakness = monster.MonsterWeakness;
            MonsterAltWeakness = monster.MonsterAltWeakness;
            MonsterAilments = monster.MonsterAilments;
            AltStateDescription = monster.AltStateDescription;
        }
    }

    public class TempMonster
    {
        public int MonsterID { get; }
        public string Name { get; }
        public string Size { get; }
        public string Ecology { get; }
        public string Description { get; }
        public string AltStateDescription { get; }
        public bool HasWeakness { get; }
        public bool HasAltWeakness { get; }
        public int WeaknessFire { get; }
        public int WeaknessWater { get; }
        public int WeaknessIce { get; }
        public int WeaknessThunder { get; }
        public int WeaknessDragon { get; }
        public int WeaknessPoison { get; }
        public int WeaknessSleep { get; }
        public int WeaknessParalysis { get; }
        public int WeaknessBlast { get; }
        public int WeaknessStun { get; }
        public int AltWeaknessFire { get; }
        public int AltWeaknessWater { get; }
        public int AltWeaknessIce { get; }
        public int AltWeaknessThunder { get; }
        public int AltWeaknessDragon { get; }
        public string AilmentRoar { get; }
        public string AilmentWind { get; }
        public string AilmentTremor { get; }
        public bool AilmentDefensedown { get; }
        public bool AilmentFireblight { get; }
        public bool AilmentWaterblight { get; }
        public bool AilmentThunderblight { get; }
        public bool AilmentIceblight { get; }
        public bool AilmentDragonblight { get; }
        public bool AilmentBlastblight { get; }
        public bool AilmentPoison { get; }
        public bool AilmentSleep { get; }
        public bool AilmentParalysis { get; }
        public bool AilmentBleed { get; }
        public bool AilmentStun { get; }
        public bool AilmentMud { get; }
        public bool AilmentEffluvia { get; }
        private List<MonsterAilment> _monsterailments;

        public List<MonsterAilment> MonsterAilments
        {
            get
            {
                if (_monsterailments == null)
                {
                    _monsterailments = new List<MonsterAilment>();
                }
                return _monsterailments;
            }
        }

        private List<MonsterWeakness> _monsterweakness;

        public List<MonsterWeakness> MonsterWeakness
        {
            get
            {
                if (_monsterweakness == null)
                {
                    _monsterweakness = new List<MonsterWeakness>();
                }
                return _monsterweakness;
            }
        }

        private List<MonsterWeakness> _monsteraltweakness;

        public List<MonsterWeakness> MonsterAltWeakness
        {
            get
            {
                if (_monsteraltweakness == null)
                {
                    _monsteraltweakness = new List<MonsterWeakness>();
                }
                return _monsteraltweakness;
            }
        }
    }

    /// <summary>
    /// Monster Weakness Class
    /// </summary>
    public class MonsterWeakness
    {
        public string WeaknessName { get; }
        public int Weakness { get; }

        public MonsterWeakness(string WeaknessName, int Weakness)
        {
            this.WeaknessName = WeaknessName;
            this.Weakness = Weakness;
        }
    }

    public class MonsterAilment
    {
        public string AilmentName { get; }
        public string ExtraInfo { get; }

        public MonsterAilment(string Name, string Value)
        {
            AilmentName = Name;
            ExtraInfo = Value;
        }

        public MonsterAilment(string Name)
        {
            AilmentName = Name;
            ExtraInfo = null;
        }
    }

    public class TempMonsterBreak
    {
        public int MonsterID { get; }
        public int Flinch { get; }
        public int Wound { get; }
        public int Sever { get; }
        public string Extract { get; }
        public string PartName { get; }
        private List<MonsterBreak> _monsterbreak;

        public List<MonsterBreak> MonsterBreaks
        {
            get
            {
                if (_monsterbreak == null)
                {
                    _monsterbreak = new List<MonsterBreak>();
                }
                return _monsterbreak;
            }
        }
    }

    public class MonsterBreak
    {
        public int Flinch { get; }
        public int Wound { get; }
        public int Sever { get; }
        public string Extract { get; }
        public string PartName { get; }

        public MonsterBreak(TempMonsterBreak monsterbreak)
        {
            Flinch = monsterbreak.Flinch;
            Wound = monsterbreak.Wound;
            Sever = monsterbreak.Sever;
            Extract = monsterbreak.Extract;
            PartName = monsterbreak.PartName;
        }
    }

    public class TempMonsterHitZone
    {
        public int MonsterID { get; }
        public string PartName { get; }
        public int Cut { get; }
        public int Impact { get; }
        public int Shot { get; }
        public int Fire { get; }
        public int Water { get; }
        public int Ice { get; }
        public int Thunder { get; }
        public int Dragon { get; }
        public int KO { get; }
        private List<MonsterHitZone> _monsterhitzone;

        public List<MonsterHitZone> MonsterHitZones
        {
            get
            {
                if (_monsterhitzone == null)
                {
                    _monsterhitzone = new List<MonsterHitZone>();
                }
                return _monsterhitzone;
            }
        }
    }

    public class MonsterHitZone
    {
        public string PartName { get; }
        public int Cut { get; }
        public int Impact { get; }
        public int Shot { get; }
        public int Fire { get; }
        public int Water { get; }
        public int Ice { get; }
        public int Thunder { get; }
        public int Dragon { get; }
        public int KO { get; }

        public MonsterHitZone(TempMonsterHitZone tempMonsterHitZone)
        {
            PartName = tempMonsterHitZone.PartName;
            Cut = tempMonsterHitZone.Cut;
            Impact = tempMonsterHitZone.Impact;
            Shot = tempMonsterHitZone.Shot;
            Fire = tempMonsterHitZone.Fire;
            Water = tempMonsterHitZone.Water;
            Ice = tempMonsterHitZone.Ice;
            Thunder = tempMonsterHitZone.Thunder;
            Dragon = tempMonsterHitZone.Dragon;
            KO = tempMonsterHitZone.KO;
        }
    }

    public class TempMonsterReward
    {
        public int MonsterID { get; }
        public string Rank { get; }
        public int ItemID { get; }
        public int Stack { get; }
        public int Percentage { get; }
        public string ConditionName { get; }
        public string IconName { get; }
        public string IconColor { get; }
        public string ItemName { get; }

        private Dictionary<string, Dictionary<string, List<MonsterReward>>> _monsterreward;

        public Dictionary<string, Dictionary<string, List<MonsterReward>>> MonsterRewards
        {
            get
            {
                if (_monsterreward == null)
                {
                    _monsterreward = new Dictionary<string, Dictionary<string, List<MonsterReward>>>()
                    {
                        {"LR",new Dictionary<string,List<MonsterReward>>() },
                        {"HR",new Dictionary<string,List<MonsterReward>>() }
                    };
                }
                return _monsterreward;
            }
            set => _monsterreward = value;
        }
    }

    public class MonsterReward
    {
        public string Rank { get; }
        public int ItemID { get; }
        public int Stack { get; }
        public int Percentage { get; }
        public string ConditionName { get; }
        public string IconName { get; }
        public string IconColor { get; }
        public string ItemName { get; }

        public MonsterReward(TempMonsterReward tempMonsterReward)
        {
            ItemID = tempMonsterReward.ItemID;
            Stack = tempMonsterReward.Stack;
            Percentage = tempMonsterReward.Percentage;
            ConditionName = tempMonsterReward.ConditionName;
            IconName = tempMonsterReward.IconName?.ToLower();
            if (tempMonsterReward.IconColor == null)
            {
                IconColor = "";
            }
            else
            {
                IconColor = tempMonsterReward.IconColor.ToLower();
            }
            ItemName = tempMonsterReward.ItemName;
        }
    }

    public class MonsterAilmentStatus
    {
        private string Value;

        private MonsterAilmentStatus(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public static MonsterAilmentStatus GetMonsterAilmentStatus(string AilmentStatus)
        {
            if (AilmentStatus == null)
            {
                return null;
            }

            switch (AilmentStatus.ToLower())
            {
                case "small": return Small;
                case "large": return Large;
                case "extreme": return Extreme;
                default: return null;
            }
        }

        public static MonsterAilmentStatus Small => new MonsterAilmentStatus(Properties.String.MonsterAilmentSmall);
        public static MonsterAilmentStatus Large => new MonsterAilmentStatus(Properties.String.MonsterAilmentLarge);
        public static MonsterAilmentStatus Extreme => new MonsterAilmentStatus(Properties.String.MonsterAilmentExtreme);
    }
}