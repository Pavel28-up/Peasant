using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventorySlot> slots = new List<InventorySlot>();
    public Menu inventoryMenu;
    public GameObject slotPrefab;
    public Transform content;

    public int slotCount;

    private void Start()
    {
        CreateSlot(slotCount);
        AddInventorySlots();
        inventoryMenu.Close();
    }

    public void DeleteSlot()
    {
        bool del = true;
        while (del)
        {
            Debug.Log(slots[0]);
            if (slots[0] == null)
                slots.RemoveAt(0);
            else
                del = false;
        }
    }

    public void CreateSlot(int count)
    {
        //for (int i = 0; i < content.childCount; i++)
        //{
        //    Destroy(content.GetChild(i).gameObject);
        //}

        for (int i = 0; i < count; i++)
        {
            Instantiate(slotPrefab, content);
        }
    }

    public void ShowSlots(int count)
    {
        CreateSlot(count);
        AddInventorySlots();
    }

    public void AddInventorySlots()
    {
        for (int i = 0;i < content.childCount; i++)
        {
            Debug.Log(content.childCount);
            if (content.GetChild(i).GetComponent<InventorySlot>() != null)
                slots.Add(content.GetChild(i).GetComponent<InventorySlot>());
        }
    }

    public void AddItem(ItemScriptableObject item, int amount)
    {
        foreach (InventorySlot slot in slots)
        {
            if (slot.item == item)
            {
                break;
            }
        }

        foreach (InventorySlot slot in slots)
        {
            if (slot.isEmpty)
            {
                slot.item = item;
                slot.isEmpty = false;
                slot.SetIcon(item.icon);
                slot.amount = amount;
                slot.itemAmountText.text = slot.amount.ToString();
                break;
            }
        }
    }
}
