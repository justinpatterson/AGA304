using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    public InventoryItem myItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CollectBehavior();
        }
    }

    void CollectBehavior()
    {
        //(1) FIND THE INVENTORY MANAGER
        InventoryManager im = GameObject.FindObjectOfType<InventoryManager>();
        //(2) ADD MYSELF TO THE INVENTORY MANAGER
        if (im != null)
        {
            im.AddItem(myItem);
        }
        else
        {
            Debug.LogWarning("Pickup Item couldn't find an inventory manager - did you remember to add one to the scene?");
        }
        //(3) DESTROY MY PICKUP OBJECT
        Destroy(gameObject);
    }
}
