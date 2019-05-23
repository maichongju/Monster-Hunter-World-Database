using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    public class WeaponAmmo
    {
        public int AmmoID { get; }
        public AmmoDeviation Deviation { get; }
        public AmmoSpecialAmmo SpecialAmmo { get; }
        public List<Ammo> Ammos = new List<Ammo>();

        public WeaponAmmo(TempWeaponAmmo tempWeaponAmmo)
        {
            AmmoID = tempWeaponAmmo.AmmoID;
            Deviation = AmmoDeviation.GetAmmoDeviation(tempWeaponAmmo.Deviation);
            SpecialAmmo = AmmoSpecialAmmo.GetAmmoSpecialAmmo(tempWeaponAmmo.SpecialAmmo);

            #region Add all Ammo

            //([0-9]+), ([A-z]+).([A-z]+).([A-z0-9]+)
            if (tempWeaponAmmo.Normal1Reload != null)
            {
                Ammos.Add(new Ammo(559, Properties.String.AmmoNormal1Ammo, tempWeaponAmmo.Normal1Clip, tempWeaponAmmo.Normal1Rapid, tempWeaponAmmo.Normal1Recoil, tempWeaponAmmo.Normal1Reload));
            }

            if (tempWeaponAmmo.Normal2Reload != null)
            {
                Ammos.Add(new Ammo(560, Properties.String.AmmoNormal2Ammo, tempWeaponAmmo.Normal2Clip, tempWeaponAmmo.Normal2Rapid, tempWeaponAmmo.Normal2Recoil, tempWeaponAmmo.Normal2Reload));
            }

            if (tempWeaponAmmo.Normal3Reload != null)
            {
                Ammos.Add(new Ammo(561, Properties.String.AmmoNormal3Ammo, tempWeaponAmmo.Normal3Clip, tempWeaponAmmo.Normal3Rapid, tempWeaponAmmo.Normal3Recoil, tempWeaponAmmo.Normal3Reload));
            }

            if (tempWeaponAmmo.Pierce1Reload != null)
            {
                Ammos.Add(new Ammo(562, Properties.String.AmmoPierce1Ammo, tempWeaponAmmo.Pierce1Clip, tempWeaponAmmo.Pierce1Rapid, tempWeaponAmmo.Pierce1Recoil, tempWeaponAmmo.Pierce1Reload));
            }

            if (tempWeaponAmmo.Pierce2Reload != null)
            {
                Ammos.Add(new Ammo(563, Properties.String.AmmoPierce2Ammo, tempWeaponAmmo.Pierce2Clip, tempWeaponAmmo.Pierce2Rapid, tempWeaponAmmo.Pierce2Recoil, tempWeaponAmmo.Pierce2Reload));
            }

            if (tempWeaponAmmo.Pierce3Reload != null)
            {
                Ammos.Add(new Ammo(564, Properties.String.AmmoPierce3Ammo, tempWeaponAmmo.Pierce3Clip, tempWeaponAmmo.Pierce3Rapid, tempWeaponAmmo.Pierce3Recoil, tempWeaponAmmo.Pierce3Reload));
            }

            if (tempWeaponAmmo.Spread1Reload != null)
            {
                Ammos.Add(new Ammo(565, Properties.String.AmmoSpread1Ammo, tempWeaponAmmo.Spread1Clip, tempWeaponAmmo.Spread1Rapid, tempWeaponAmmo.Spread1Recoil, tempWeaponAmmo.Spread1Reload));
            }

            if (tempWeaponAmmo.Spread2Reload != null)
            {
                Ammos.Add(new Ammo(566, Properties.String.AmmoSpread2Ammo, tempWeaponAmmo.Spread2Clip, tempWeaponAmmo.Spread2Rapid, tempWeaponAmmo.Spread2Recoil, tempWeaponAmmo.Spread2Reload));
            }

            if (tempWeaponAmmo.Spread3Reload != null)
            {
                Ammos.Add(new Ammo(567, Properties.String.AmmoSpread3Ammo, tempWeaponAmmo.Spread3Clip, tempWeaponAmmo.Spread3Rapid, tempWeaponAmmo.Spread3Recoil, tempWeaponAmmo.Spread3Reload));
            }

            if (tempWeaponAmmo.Sticky1Reload != null)
            {
                Ammos.Add(new Ammo(568, Properties.String.AmmoSticky1Ammo, tempWeaponAmmo.Sticky1Clip, tempWeaponAmmo.Sticky1Rapid, tempWeaponAmmo.Sticky1Recoil, tempWeaponAmmo.Sticky1Reload));
            }

            if (tempWeaponAmmo.Sticky2Reload != null)
            {
                Ammos.Add(new Ammo(569, Properties.String.AmmoSticky2Ammo, tempWeaponAmmo.Sticky2Clip, tempWeaponAmmo.Sticky2Rapid, tempWeaponAmmo.Sticky2Recoil, tempWeaponAmmo.Sticky2Reload));
            }

            if (tempWeaponAmmo.Sticky3Reload != null)
            {
                Ammos.Add(new Ammo(570, Properties.String.AmmoSticky3Ammo, tempWeaponAmmo.Sticky3Clip, tempWeaponAmmo.Sticky3Rapid, tempWeaponAmmo.Sticky3Recoil, tempWeaponAmmo.Sticky3Reload));
            }

            if (tempWeaponAmmo.Cluster1Reload != null)
            {
                Ammos.Add(new Ammo(571, Properties.String.AmmoCluster1Ammo, tempWeaponAmmo.Cluster1Clip, tempWeaponAmmo.Cluster1Rapid, tempWeaponAmmo.Cluster1Recoil, tempWeaponAmmo.Cluster1Reload));
            }

            if (tempWeaponAmmo.Cluster2Reload != null)
            {
                Ammos.Add(new Ammo(572, Properties.String.AmmoCluster2Ammo, tempWeaponAmmo.Cluster2Clip, tempWeaponAmmo.Cluster2Rapid, tempWeaponAmmo.Cluster2Recoil, tempWeaponAmmo.Cluster2Reload));
            }

            if (tempWeaponAmmo.Cluster3Reload != null)
            {
                Ammos.Add(new Ammo(573, Properties.String.AmmoCluster3Ammo, tempWeaponAmmo.Cluster3Clip, tempWeaponAmmo.Cluster3Rapid, tempWeaponAmmo.Cluster3Recoil, tempWeaponAmmo.Cluster3Reload));
            }

            if (tempWeaponAmmo.Recover1Reload != null)
            {
                Ammos.Add(new Ammo(587, Properties.String.AmmoRecover1Ammo, tempWeaponAmmo.Recover1Clip, tempWeaponAmmo.Recover1Rapid, tempWeaponAmmo.Recover1Recoil, tempWeaponAmmo.Recover1Reload));
            }

            if (tempWeaponAmmo.Recover2Reload != null)
            {
                Ammos.Add(new Ammo(588, Properties.String.AmmoRecover2Ammo, tempWeaponAmmo.Recover2Clip, tempWeaponAmmo.Recover2Rapid, tempWeaponAmmo.Recover2Recoil, tempWeaponAmmo.Recover2Reload));
            }

            if (tempWeaponAmmo.Poison1Reload != null)
            {
                Ammos.Add(new Ammo(579, Properties.String.AmmoPoison1Ammo, tempWeaponAmmo.Poison1Clip, tempWeaponAmmo.Poison1Rapid, tempWeaponAmmo.Poison1Recoil, tempWeaponAmmo.Poison1Reload));
            }

            if (tempWeaponAmmo.Poison2Reload != null)
            {
                Ammos.Add(new Ammo(580, Properties.String.AmmoPoison2Ammo, tempWeaponAmmo.Poison2Clip, tempWeaponAmmo.Poison2Rapid, tempWeaponAmmo.Poison2Recoil, tempWeaponAmmo.Poison2Reload));
            }

            if (tempWeaponAmmo.Paralysis1Reload != null)
            {
                Ammos.Add(new Ammo(581, Properties.String.AmmoParalysis1Ammo, tempWeaponAmmo.Paralysis1Clip, tempWeaponAmmo.Paralysis1Rapid, tempWeaponAmmo.Paralysis1Recoil, tempWeaponAmmo.Paralysis1Reload));
            }

            if (tempWeaponAmmo.Paralysis2Reload != null)
            {
                Ammos.Add(new Ammo(582, Properties.String.AmmoParalysis2Ammo, tempWeaponAmmo.Paralysis2Clip, tempWeaponAmmo.Paralysis2Rapid, tempWeaponAmmo.Paralysis2Recoil, tempWeaponAmmo.Paralysis2Reload));
            }

            if (tempWeaponAmmo.Sleep1Reload != null)
            {
                Ammos.Add(new Ammo(583, Properties.String.AmmoSleep1Ammo, tempWeaponAmmo.Sleep1Clip, tempWeaponAmmo.Sleep1Rapid, tempWeaponAmmo.Sleep1Recoil, tempWeaponAmmo.Sleep1Reload));
            }

            if (tempWeaponAmmo.Sleep2Reload != null)
            {
                Ammos.Add(new Ammo(584, Properties.String.AmmoSleep2Ammo, tempWeaponAmmo.Sleep2Clip, tempWeaponAmmo.Sleep2Rapid, tempWeaponAmmo.Sleep2Recoil, tempWeaponAmmo.Sleep2Reload));
            }

            if (tempWeaponAmmo.Exhaust1Reload != null)
            {
                Ammos.Add(new Ammo(585, Properties.String.AmmoExhaust1Ammo, tempWeaponAmmo.Exhaust1Clip, tempWeaponAmmo.Exhaust1Rapid, tempWeaponAmmo.Exhaust1Recoil, tempWeaponAmmo.Exhaust1Reload));
            }

            if (tempWeaponAmmo.Exhaust2Reload != null)
            {
                Ammos.Add(new Ammo(586, Properties.String.AmmoExhaust2Ammo, tempWeaponAmmo.Exhaust2Clip, tempWeaponAmmo.Exhaust2Rapid, tempWeaponAmmo.Exhaust2Recoil, tempWeaponAmmo.Exhaust2Reload));
            }

            if (tempWeaponAmmo.FlamingReload != null)
            {
                Ammos.Add(new Ammo(574, Properties.String.AmmoFlamingAmmo, tempWeaponAmmo.FlamingClip, tempWeaponAmmo.FlamingRapid, tempWeaponAmmo.FlamingRecoil, tempWeaponAmmo.FlamingReload));
            }

            if (tempWeaponAmmo.WaterReload != null)
            {
                Ammos.Add(new Ammo(575, Properties.String.AmmoWaterAmmo, tempWeaponAmmo.WaterClip, tempWeaponAmmo.WaterRapid, tempWeaponAmmo.WaterRecoil, tempWeaponAmmo.WaterReload));
            }

            if (tempWeaponAmmo.FreezeReload != null)
            {
                Ammos.Add(new Ammo(577, Properties.String.AmmoFreezeAmmo, tempWeaponAmmo.FreezeClip, tempWeaponAmmo.FreezeRapid, tempWeaponAmmo.FreezeRecoil, tempWeaponAmmo.FreezeReload));
            }

            if (tempWeaponAmmo.ThunderReload != null)
            {
                Ammos.Add(new Ammo(576, Properties.String.AmmoThunderAmmo, tempWeaponAmmo.ThunderClip, tempWeaponAmmo.ThunderRapid, tempWeaponAmmo.ThunderRecoil, tempWeaponAmmo.ThunderReload));
            }

            if (tempWeaponAmmo.DragonReload != null)
            {
                Ammos.Add(new Ammo(578, Properties.String.AmmoDragonAmmo, tempWeaponAmmo.DragonClip, tempWeaponAmmo.DragonRapid, tempWeaponAmmo.DragonRecoil, tempWeaponAmmo.DragonReload));
            }

            if (tempWeaponAmmo.SlicingReload != null)
            {
                Ammos.Add(new Ammo(590, Properties.String.AmmoSlicingAmmo, tempWeaponAmmo.SlicingClip, tempWeaponAmmo.SlicingRapid, tempWeaponAmmo.SlicingRecoil, tempWeaponAmmo.SlicingReload));
            }

            if (tempWeaponAmmo.WyvernReload != null)
            {
                Ammos.Add(new Ammo(589, Properties.String.AmmoWyvernAmmo, tempWeaponAmmo.WyvernClip, false, 0, tempWeaponAmmo.WyvernReload));
            }

            if (tempWeaponAmmo.DemonReload != null)
            {
                Ammos.Add(new Ammo(592, Properties.String.AmmoDemonAmmo, tempWeaponAmmo.DemonClip, false, tempWeaponAmmo.DemonRecoil, tempWeaponAmmo.DemonReload));
            }

            if (tempWeaponAmmo.ArmorReload != null)
            {
                Ammos.Add(new Ammo(593, Properties.String.AmmoArmorAmmo, tempWeaponAmmo.ArmorClip, false, tempWeaponAmmo.ArmorRecoil, tempWeaponAmmo.ArmorReload));
            }

            if (tempWeaponAmmo.TranqReload != null)
            {
                Ammos.Add(new Ammo(591, Properties.String.AmmoTranqAmmo, tempWeaponAmmo.TranqClip, false, tempWeaponAmmo.TranqRecoil, tempWeaponAmmo.TranqReload));
            }

            #endregion Add all Ammo
        }
    }

    public class Ammo
    {
        public int ItemID { get; }
        public string AmmoName { get; }
        public int AmmoClip { get; }
        public bool AmmoRapid { get; }
        public AmmoRecoil AmmoRecoil { get; }
        public AmmoReload AmmoReload { get; }

        public Ammo(int ID, string Name, int Clip, bool Rapid, int Recoil, string Reload)
        {
            ItemID = ID;
            AmmoName = Name;
            AmmoClip = Clip;
            AmmoRapid = Rapid;
            AmmoRecoil = AmmoRecoil.GetAmmoRecoil(Recoil);
            AmmoReload = AmmoReload.GetAmmoReload(Reload);
        }
    }

    public class TempWeaponAmmo
    {
        /// <summary>
        /// Clip 弹夹容量
        /// Rapid 速射
        /// Recoil 后坐力 -1 Auto reload
        /// Reload 换弹速度
        /// </summary>
        public int AmmoID { get; set; }

        public string Deviation { get; set; }
        public string SpecialAmmo { get; set; }

        #region Ammo Data

        public int Normal1Clip { get; set; }
        public bool Normal1Rapid { get; set; }
        public int Normal1Recoil { get; set; }
        public string Normal1Reload { get; set; }
        public int Normal2Clip { get; set; }
        public bool Normal2Rapid { get; set; }
        public int Normal2Recoil { get; set; }
        public string Normal2Reload { get; set; }
        public int Normal3Clip { get; set; }
        public bool Normal3Rapid { get; set; }
        public int Normal3Recoil { get; set; }
        public string Normal3Reload { get; set; }
        public int Pierce1Clip { get; set; }
        public bool Pierce1Rapid { get; set; }
        public int Pierce1Recoil { get; set; }
        public string Pierce1Reload { get; set; }
        public int Pierce2Clip { get; set; }
        public bool Pierce2Rapid { get; set; }
        public int Pierce2Recoil { get; set; }
        public string Pierce2Reload { get; set; }
        public int Pierce3Clip { get; set; }
        public bool Pierce3Rapid { get; set; }
        public int Pierce3Recoil { get; set; }
        public string Pierce3Reload { get; set; }
        public int Spread1Clip { get; set; }
        public bool Spread1Rapid { get; set; }
        public int Spread1Recoil { get; set; }
        public string Spread1Reload { get; set; }
        public int Spread2Clip { get; set; }
        public bool Spread2Rapid { get; set; }
        public int Spread2Recoil { get; set; }
        public string Spread2Reload { get; set; }
        public int Spread3Clip { get; set; }
        public bool Spread3Rapid { get; set; }
        public int Spread3Recoil { get; set; }
        public string Spread3Reload { get; set; }
        public int Sticky1Clip { get; set; }
        public bool Sticky1Rapid { get; set; }
        public int Sticky1Recoil { get; set; }
        public string Sticky1Reload { get; set; }
        public int Sticky2Clip { get; set; }
        public bool Sticky2Rapid { get; set; }
        public int Sticky2Recoil { get; set; }
        public string Sticky2Reload { get; set; }
        public int Sticky3Clip { get; set; }
        public bool Sticky3Rapid { get; set; }
        public int Sticky3Recoil { get; set; }
        public string Sticky3Reload { get; set; }
        public int Cluster1Clip { get; set; }
        public bool Cluster1Rapid { get; set; }
        public int Cluster1Recoil { get; set; }
        public string Cluster1Reload { get; set; }
        public int Cluster2Clip { get; set; }
        public bool Cluster2Rapid { get; set; }
        public int Cluster2Recoil { get; set; }
        public string Cluster2Reload { get; set; }
        public int Cluster3Clip { get; set; }
        public bool Cluster3Rapid { get; set; }
        public int Cluster3Recoil { get; set; }
        public string Cluster3Reload { get; set; }
        public int Recover1Clip { get; set; }
        public bool Recover1Rapid { get; set; }
        public int Recover1Recoil { get; set; }
        public string Recover1Reload { get; set; }
        public int Recover2Clip { get; set; }
        public bool Recover2Rapid { get; set; }
        public int Recover2Recoil { get; set; }
        public string Recover2Reload { get; set; }
        public int Poison1Clip { get; set; }
        public bool Poison1Rapid { get; set; }
        public int Poison1Recoil { get; set; }
        public string Poison1Reload { get; set; }
        public int Poison2Clip { get; set; }
        public bool Poison2Rapid { get; set; }
        public int Poison2Recoil { get; set; }
        public string Poison2Reload { get; set; }
        public int Paralysis1Clip { get; set; }
        public bool Paralysis1Rapid { get; set; }
        public int Paralysis1Recoil { get; set; }
        public string Paralysis1Reload { get; set; }
        public int Paralysis2Clip { get; set; }
        public bool Paralysis2Rapid { get; set; }
        public int Paralysis2Recoil { get; set; }
        public string Paralysis2Reload { get; set; }
        public int Sleep1Clip { get; set; }
        public bool Sleep1Rapid { get; set; }
        public int Sleep1Recoil { get; set; }
        public string Sleep1Reload { get; set; }
        public int Sleep2Clip { get; set; }
        public bool Sleep2Rapid { get; set; }
        public int Sleep2Recoil { get; set; }
        public string Sleep2Reload { get; set; }
        public int Exhaust1Clip { get; set; }
        public bool Exhaust1Rapid { get; set; }
        public int Exhaust1Recoil { get; set; }
        public string Exhaust1Reload { get; set; }
        public int Exhaust2Clip { get; set; }
        public bool Exhaust2Rapid { get; set; }
        public int Exhaust2Recoil { get; set; }
        public string Exhaust2Reload { get; set; }
        public int FlamingClip { get; set; }
        public bool FlamingRapid { get; set; }
        public int FlamingRecoil { get; set; }
        public string FlamingReload { get; set; }
        public int WaterClip { get; set; }
        public bool WaterRapid { get; set; }
        public int WaterRecoil { get; set; }
        public string WaterReload { get; set; }
        public int FreezeClip { get; set; }
        public bool FreezeRapid { get; set; }
        public int FreezeRecoil { get; set; }
        public string FreezeReload { get; set; }
        public int ThunderClip { get; set; }
        public bool ThunderRapid { get; set; }
        public int ThunderRecoil { get; set; }
        public string ThunderReload { get; set; }
        public int DragonClip { get; set; }
        public bool DragonRapid { get; set; }
        public int DragonRecoil { get; set; }
        public string DragonReload { get; set; }
        public int SlicingClip { get; set; }
        public bool SlicingRapid { get; set; }
        public int SlicingRecoil { get; set; }
        public string SlicingReload { get; set; }
        public int WyvernClip { get; set; }
        public string WyvernReload { get; set; }
        public int DemonClip { get; set; }
        public int DemonRecoil { get; set; }
        public string DemonReload { get; set; }
        public int ArmorClip { get; set; }
        public int ArmorRecoil { get; set; }
        public string ArmorReload { get; set; }
        public int TranqClip { get; set; }
        public int TranqRecoil { get; set; }
        public string TranqReload { get; set; }

        #endregion Ammo Data
    }

    /// <summary>
    /// 偏移
    /// </summary>
    public class AmmoDeviation
    {
        private AmmoDeviation(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static AmmoDeviation GetAmmoDeviation(string Deviation)
        {
            if (Deviation == null)
            {
                return null;
            }

            switch (Deviation.ToLower())
            {
                case "none": return None;
                case "low": return Low;
                case "average": return Average;
                case "high": return High;
                default: return null;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public static AmmoDeviation None { get { return new AmmoDeviation(Properties.String.AmmoDeviationNone); } }
        public static AmmoDeviation Low { get { return new AmmoDeviation(Properties.String.AmmoDeviationLow); } }
        public static AmmoDeviation Average { get { return new AmmoDeviation(Properties.String.AmmoDeviationAverage); } }
        public static AmmoDeviation High { get { return new AmmoDeviation(Properties.String.AmmoDeviationHigh); } }
    }

    /// <summary>
    /// 后坐力
    /// </summary>
    public class AmmoRecoil
    {
        private AmmoRecoil(string value)
        {
            Value = value;
        }

        public static AmmoRecoil GetAmmoRecoil(int Recoil)
        {
            switch (Recoil)
            {
                case -1: return AutoReload;
                case 1: return Low;
                case 2: return Average;
                case 3: return High;
                case 4: return VeryHigh;
                default: return null;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public string Value { get; }
        public static AmmoRecoil AutoReload { get { return new AmmoRecoil(Properties.String.AmmoRecoilAutoReload); } }
        public static AmmoRecoil Low { get { return new AmmoRecoil(Properties.String.AmmoRecoilLow); } }
        public static AmmoRecoil Average { get { return new AmmoRecoil(Properties.String.AmmoRecoilAverage); } }
        public static AmmoRecoil High { get { return new AmmoRecoil(Properties.String.AmmoRecoilHigh); } }
        public static AmmoRecoil VeryHigh { get { return new AmmoRecoil(Properties.String.AmmoRecoilVeryHigh); } }
    }

    public class AmmoReload
    {
        private AmmoReload(string value)
        {
            Value = value;
        }

        public static AmmoReload GetAmmoReload(string Reload)
        {
            if (Reload == null)
            {
                return null;
            }

            switch (Reload.ToLower())
            {
                case "very slow": return VerySlow;
                case "slow": return Slow;
                case "normal": return Normal;
                case "fast": return Fast;
                default: return null;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public string Value { get; }
        public static AmmoReload VerySlow { get { return new AmmoReload(Properties.String.AmmoReloadVerySlow); } }
        public static AmmoReload Slow { get { return new AmmoReload(Properties.String.AmmoReloadSlow); } }
        public static AmmoReload Normal { get { return new AmmoReload(Properties.String.AmmoReloadNormal); } }
        public static AmmoReload Fast { get { return new AmmoReload(Properties.String.AmmoReloadFast); } }
    }

    public class AmmoSpecialAmmo
    {
        private AmmoSpecialAmmo(string value)
        {
            Value = value;
        }

        public static AmmoSpecialAmmo GetAmmoSpecialAmmo(string SpecialAmmo)
        {
            if (SpecialAmmo == null)
            {
                return null;
            }

            switch (SpecialAmmo.ToLower())
            {
                case "wyvernblast": return Wyvernblast;
                case "wyvernsnipe": return Wyvernsnipe;
                case "wyvernheart": return Wyvernheart;
                default: return null;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public string Value { get; }
        public static AmmoSpecialAmmo Wyvernblast { get { return new AmmoSpecialAmmo(Properties.String.AmmoSpecialAmmoWyvernblast); } }
        public static AmmoSpecialAmmo Wyvernsnipe { get { return new AmmoSpecialAmmo(Properties.String.AmmoSpecialAmmoWyvernsnipe); } }
        public static AmmoSpecialAmmo Wyvernheart { get { return new AmmoSpecialAmmo(Properties.String.AmmoSpecialAmmoWyvernheart); } }
    }
}