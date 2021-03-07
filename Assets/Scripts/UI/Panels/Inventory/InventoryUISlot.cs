using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryUISlot : MonoBehaviour
{
    [SerializeField]
    public InventoryItem inventoryItem;

    public Button inventoryButton;

    public Text inventoryText;
    public Image inventoryImage;


    public void AssignInventoryItem(InventoryItem newItem)
    {
        inventoryItem = newItem;
        if (inventoryText != null)
        {
            inventoryText.text = inventoryItem.itemName;
        }
        inventoryImage.sprite = inventoryItem.itemTexture;
    }

}
