namespace MonsterHunterWorld.Class
{
    public class CraftItem
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; }
        private string iconName { get; set; }

        public string IconName
        {
            get
            {
                if (iconName == null)
                    return null;
                else return iconName.ToLower();
            }
            set
            {
                iconName = value;
            }
        }

        private string iconColor { get; set; }

        public string IconColor
        {
            get
            {
                if (iconColor == null)
                    return "";
                else return iconColor.ToLower();
            }

            set
            {
                iconColor = value;
            }
        }

        public CraftItem()
        {
        }

        public CraftItem(Armor armor)
        {
            ItemID = armor.ItemID;
            Quantity = armor.Quantity;
            ItemName = armor.ItemName;
            IconName = armor.IconName?.ToLower();
            IconColor = armor.IconColor;
        }

        public CraftItem(Weapon weapon)
        {
            ItemID = weapon.ItemID;
            Quantity = weapon.Quantity;
            ItemName = weapon.ItemName;
            IconName = weapon.IconName?.ToLower();
            IconColor = weapon.IconColor;
        }

        public CraftItem(Charm charm)
        {
            ItemID = charm.ItemID;
            Quantity = charm.Quantity;
            ItemName = charm.ItemName;
            IconName = charm.ItemIconName?.ToLower();
            IconColor = charm.ItemIconColor;
        }
    }
}