using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MenuPanel
{
    public GameObject inventorySlotPrefab;

    public GameObject inventoryGridContainer;


    public override void OpenPanel()
    {
        base.OpenPanel();

        //Delete any old Inventory Slot Buttons from my grid
        int childCount = inventoryGridContainer.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform currentChild = inventoryGridContainer.transform.GetChild(i);
            Destroy(currentChild.gameObject);
        }
        //find Inventory manager
        InventoryManager im = GameObject.FindObjectOfType<InventoryManager>();
        if (im != null)
        {
            //get Inventory manager's current inventory
            //FOR EVERY INVENTORY ITEM
            foreach (InventoryItem currentItem in im.InventoryList)
            {
                //Spawn a new Inventory Slot Button
                //Add button to my Inventory Grid
                GameObject slotButton = Instantiate(inventorySlotPrefab, inventoryGridContainer.transform);
                InventoryUISlot currentUISlot = slotButton.GetComponent<InventoryUISlot>();
                if (currentUISlot != null)
                {
                    currentUISlot.AssignInventoryItem(currentItem);
                }
            }

        }


    }
}
