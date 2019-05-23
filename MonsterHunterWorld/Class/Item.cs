using System.Collections.Generic;

namespace MonsterHunterWorld.Class
{
    internal class Item
    {
        #region Dapper Item Query

        private int id { get; set; }
        private string category { get; set; }
        private string subcategory { get; set; }
        private int rarity { get; set; }
        private int buy_price { get; set; }
        private int sell_price { get; set; }
        private int carry_limit { get; set; }
        private int points { get; set; }
        private string icon_name { get; set; }
        private string icon_color { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        public int first_id { get; set; }
        public string first_name { get; set; }
        public string first_icon_name { get; set; }
        public string first_icon_color { get; set; }
        public int second_id { get; set; }
        public string second_name { get; set; }
        public string second_icon_name { get; set; }
        public string second_icon_color { get; set; }
        public int quantity { get; set; }

        #endregion Dapper Item Query

        public int Id { get { return this.id; } }
        public string Category { get { return category.ToLower(); } }
        public string Subcategory { get { return subcategory.ToLower(); } }
        public int Rarity { get { return rarity; } }
        public int BuyPrice { get { return buy_price; } }
        public int SellPrice { get { return sell_price; } }
        public int CarryLimit { get { return carry_limit; } }
        public int Points { get { return points; } }
        public string IconName { get { return icon_name == null ? null : icon_name.ToLower(); } }
        public string IconColor { get { return icon_color == null ? "" : icon_color.ToLower(); } }
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        private readonly List<ItemCraft> Crafts = new List<ItemCraft>();

        public void AddCraft(ItemCraft itemCraft)
        {
            Crafts.Add(itemCraft);
        }

        public List<ItemCraft> GetCraftList()
        {
            return Crafts;
        }
    }

    internal class ItemCraft
    {
        public int FirstId { get; }
        public string FirstName { get; }
        public string FirstIconName { get; }
        public string FirstIconColor { get; }
        public int SecondId { get; }
        public string SecondName { get; }
        public string SecondIconName { get; }
        public string SecondIconColor { get; }
        public int Quantity { get; }

        public ItemCraft(Item item)
        {
            FirstId = item.first_id;
            FirstName = item.first_name;
            FirstIconName = item.first_icon_name == null ? null : item.first_icon_name.ToLower();
            FirstIconColor = item.first_icon_color == null ? "" : item.first_icon_color.ToLower();
            SecondId = item.second_id;
            SecondName = item.second_name;
            SecondIconName = item.second_icon_name == null ? null : item.second_icon_name.ToLower(); ;
            SecondIconColor = item.second_icon_color == null ? "" : item.second_icon_color.ToLower(); ;
            Quantity = item.quantity;
        }
    }
}