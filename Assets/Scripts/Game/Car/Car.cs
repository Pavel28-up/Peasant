using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public void ShowInventory(CarScriptableObject car)
    {
        //FindObjectOfType<InventoryManager>().ShowSlots(car.spareParts.Count);

        foreach (var part in car.spareParts)
        {
            Debug.Log(part.item);
            FindObjectOfType<InventoryManager>().AddItem(part.item, part.amount);
        }

        //FindObjectOfType<InventoryManager>().DeleteSlot();
    }
}
