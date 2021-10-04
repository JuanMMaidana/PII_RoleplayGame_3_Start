using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: Character , IMagicCharacter
    {

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }

        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    }
}