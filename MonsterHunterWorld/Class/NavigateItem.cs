namespace MonsterHunterWorld.Class
{
    internal class NavigateItem
    {
        public string Key { get; }
        public string Value { get; }

        public NavigateItem(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}