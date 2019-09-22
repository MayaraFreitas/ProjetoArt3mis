using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryTrash : MonoBehaviour, IPointerClickHandler
{
    private UIItem selectedItem;
    private Inventory inventory;
    private void Awake()
    {
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // Tem algum item selecionado?
        if (selectedItem.item != null)
        {
            inventory.DropItem(selectedItem);
        }
    }
}
