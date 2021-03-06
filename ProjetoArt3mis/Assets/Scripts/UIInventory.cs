﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 16;

    private void Awake()
    {
        for (int i=0; i<numberOfSlots; i++)
        {
            GameObject instantiate = Instantiate(slotPrefab);
            instantiate.transform.SetParent(slotPanel);
            uIItems.Add(instantiate.GetComponentInChildren<UIItem>());
        }
    }

    public void UpdateSlot(int slot, Item item)
    {
        uIItems[slot].UpdateItem(item);
    }

    public void AddNewItem(Item item)
    {
        UpdateSlot(uIItems.FindIndex(i => i.item == null), item);
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(uIItems.FindIndex(i => i.item == item), null);
    }

    public void UpdateItem(Item oldItem, Item newItem)
    {
        UpdateSlot(uIItems.FindIndex(i => i.item == oldItem), newItem);
    }
}
