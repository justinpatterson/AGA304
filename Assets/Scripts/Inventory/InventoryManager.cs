using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    
    public List<InventoryItem> InventoryList = new List<InventoryItem>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InventoryItem i = new InventoryItem();
            i.itemName = "Sword of Damocles";

            InventoryItem.ItemStatEntry statEntry = new InventoryItem.ItemStatEntry();
            statEntry.statKey = "CardSuit";
            statEntry.statValue = 1;
            i.itemStats.Add(statEntry);

            i.itemTexture = null;
            AddItem(i);
        }
    }

    public bool AddItem(InventoryItem newItem)
    {
        InventoryList.Add(newItem);
        Debug.Log("I have added the item: " + newItem.itemName);
        Debug.Log("Inventory Count: " + InventoryList.Count);
        return true;
    }
    public bool RemoveItem(InventoryItem itemToRemove)
    {
        return InventoryList.Remove(itemToRemove);
    }
}