using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static CraftController;

public class UICrafitController : MonoBehaviour
{
    public CraftController craftController;
    public Transform fistSlotCraft;
    public Transform secondSlotCraft;
    public Transform resultSlot;

    private Inventory inventory;

    void Start()
    {
        if(craftController == null)
        {
            craftController = FindObjectOfType(typeof(CraftController)) as CraftController;
        }

        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    public void Craft()
    {
        // Se o slot de resultado possuir um item, não craftar!
        UIItem resultUIItem = resultSlot.GetComponentInChildren<UIItem>();
        if (resultUIItem != null && resultUIItem.item != null)
        {
            return;
        }

        // Buscar itens em todos os slots de craft (1 e 2)
        List<UIItem> slotItems = getSlotUIItems();

        // Buscar receita que prossui os items dos slots
        Recip recip = getItemResult(slotItems);
        if (recip != null)
        {
            
            if (resultUIItem != null)
            {
                resultUIItem.UpdateItem(inventory.itemDatabase.GetItem(recip.resultItem.name));

                slotItems.ForEach(i => i.UpdateItem(inventory.itemDatabase.GetItem(null)));

            }
        }
    }

    private Recip getItemResult(List<UIItem> slotUIItems)
    {
        if (slotUIItems != null && !slotUIItems.Any())
        {
            return null;
        }

        List<Item> slotItems = slotUIItems.Where(i => i.item != null).Select(i => i.item).ToList();
        if (slotItems != null && !slotItems.Any())
        {
            return null;
        }

        List<Recip> recips = craftController.recips;
        foreach (Recip recip in recips)
        {
            if (checkRecip(recip, slotItems))
            {
                return recip;
            }
        }
        return null;
    }

    private bool checkRecip(Recip recip, List<Item> slotItems)
    {
        List<Item> recipItems = new List<Item>();
        foreach (RecipItem recipItem in recip.requestItems)
        {
            if (recipItem == null)
                continue;

            Item item = inventory.itemDatabase.GetItem(recipItem.item.name);
            if (item != null)
            {
                recipItems.Add(item);
            }
        }  
            
        return Helper.AreEquals<Item>(recipItems, slotItems);
    }

    private List<UIItem> getSlotUIItems()
    {
        List<UIItem> lstUIItem = new List<UIItem>();

        setSlotUIItem(fistSlotCraft, ref lstUIItem);
        setSlotUIItem(secondSlotCraft, ref lstUIItem);

        return lstUIItem;
    }

    private void setSlotUIItem(Transform slot, ref List<UIItem> lstItem)
    {
        UIItem slotUIItem = slot.GetComponentInChildren<UIItem>();
        if (slotUIItem == null || slotUIItem.item == null)
        {
            return;
        }

        lstItem.Add(slotUIItem);
        return; 
    }
}