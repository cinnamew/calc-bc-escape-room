using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    

    public void OnPickupItem() {
        GameObject.Find("inventory").GetComponent<InventorySystem>().Add(referenceItem);
        Destroy(gameObject);
    }
}
