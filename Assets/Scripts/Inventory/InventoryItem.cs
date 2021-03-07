using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Default Inventory Item", menuName = "Inventory Item/Default Item")]
public class InventoryItem : ScriptableObject
{
    public enum ItemTypes { Weapon, Equipment, Furniture, Default  }

    [SerializeField]
    public string itemName;

    [SerializeField]
    public ItemTypes itemType = ItemTypes.Default;

    [SerializeField]
    public List<ItemStatEntry> itemStats = new List<ItemStatEntry>();

    [SerializeField]
    public Sprite itemTexture;

    [System.Serializable]
    public struct ItemStatEntry
    {
        [SerializeField]
        public string statKey;
        [SerializeField]
        public int statValue;
    }


    public void AddItemStat(ItemStatEntry entry)
    {
        itemStats.Add(entry);
    }

}