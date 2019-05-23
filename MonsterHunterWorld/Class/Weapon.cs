using System.Collections.Generic;
using System.Drawing;

namespace MonsterHunterWorld.Class
{
    public class Weapon
    {
        public int WeaponID { get; set; }
        public string Name { get; set; }
        public string WeaponType { get; set; }
        public int Rarity { get; set; }
        public string Category { get; set; }
        public int Attack { get; set; }
        public int AttackTrue { get; set; }
        public int Affinity { get; set; }
        public int Defense { get; set; }
        public int Slot1 { get; set; }
        public int Slot2 { get; set; }
        public int Slot3 { get; set; }
        public string Element1 { get; set; }
        public string Element1Attack { get; set; }
        public string Element2 { get; set; }
        public string Element2Attack { get; set; }
        public bool ElementHidden { get; set; }
        public string ElderSeal { get; set; }
        public string Sharpness { get; set; }
        public Bitmap SharpnessImage { get; set; }
        public bool SharpnessMaxed { get; set; }
        public bool Craftable { get; set; }
        public bool Final { get; set; }
        public string KinsectBonus { get; set; }
        public string Phial { get; set; }
        public string PhialPower { get; set; }
        public string Shelling { get; set; }
        public int ShellingLevel { get; set; }
        public string Notes { get; set; }
        public bool CoatingClose { get; set; }
        public bool CoatingPower { get; set; }
        public bool CoatingParalysis { get; set; }
        public bool CoatingPoison { get; set; }
        public bool CoatingSleep { get; set; }
        public bool CoatingBlast { get; set; }
        public int AmmoID { get; set; }
        public int SkillID { get; set; }
        public int SkillLevel { get; set; }
        public int SkillMaxLevel { get; set; }
        public string SkillName { get; set; }
        private string skill_icon_color { get; set; }
        public string SkillIconColor { get { return skill_icon_color == null ? "" : skill_icon_color.ToLower(); } }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string RecipeType { get; set; }
        public int Quantity { get; set; }
        public string IconName { get; set; }
        public string IconColor { get; set; }
        public List<CraftItem> CraftUpgradeList = new List<CraftItem>();
        public List<CraftItem> CraftCreateList = new List<CraftItem>();
    }

    public class WeaponElderSeal
    {
        public string Value { get; }

        private WeaponElderSeal(string value)
        {
            Value = value;
        }

        public static WeaponElderSeal GetWeaponElderSeal(string ElderSeal)
        {
            if (ElderSeal == null) return None;
            switch (ElderSeal)
            {
                case "low": return Low;
                case "average": return Average;
                case "high": return High;
                default: return None;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public static WeaponElderSeal Low { get { return new WeaponElderSeal(Properties.String.WeaponElderSealLow); } }
        public static WeaponElderSeal Average { get { return new WeaponElderSeal(Properties.String.WeaponElderSealAverage); } }
        public static WeaponElderSeal High { get { return new WeaponElderSeal(Properties.String.WeaponElderSealHigh); } }
        public static WeaponElderSeal None { get { return new WeaponElderSeal(Properties.String.WeaponElderSealNone); } }
    }

    public class WeaponElement
    {
        public string Value { get; }

        private WeaponElement(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public static WeaponElement GetWeaponElement(string Element)
        {
            if (Element == null) return null;
            switch (Element.ToLower())
            {
                case "fire": return Fire;
                case "water": return Water;
                case "ice": return Ice;
                case "thunder": return Thunder;
                case "blast": return Blast;
                case "paralysis": return Paralysis;
                case "poison": return Poison;
                case "sleep": return Sleep;
                default: return null;
            }
        }

        public static WeaponElement Fire { get { return new WeaponElement(Properties.String.WeaponElementFire); } }
        public static WeaponElement Water { get { return new WeaponElement(Properties.String.WeaponElementWater); } }
        public static WeaponElement Ice { get { return new WeaponElement(Properties.String.WeaponElementIce); } }
        public static WeaponElement Thunder { get { return new WeaponElement(Properties.String.WeaponElementThunder); } }
        public static WeaponElement Dragon { get { return new WeaponElement(Properties.String.WeaponElementDragon); } }
        public static WeaponElement Blast { get { return new WeaponElement(Properties.String.WeaponElementBlast); } }
        public static WeaponElement Paralysis { get { return new WeaponElement(Properties.String.WeaponElementParalysis); } }
        public static WeaponElement Poison { get { return new WeaponElement(Properties.String.WeaponElementPoison); } }
        public static WeaponElement Sleep { get { return new WeaponElement(Properties.String.WeaponElementSleep); } }
    }
}