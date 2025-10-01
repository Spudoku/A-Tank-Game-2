using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("Inventory Contents")]
    public int InventorySize = 10;
    [SerializeField] private ItemStack[] startingItems;         // items that will be added immediately during Awake();
    [SerializeField] private ItemStack[] inventoryList;             // the items that are ACTUALLY CONTAINED in this class

    [Header("Current State")]
    [SerializeField] private ItemStack selectedItem;
    [SerializeField] private int selectedIndex;

    [Header("Communications")]
    public InventoryUI ui;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Add all items from startingItems into inventoryList
        #region startingItems
        Debug.Log($"[Inventory.Awake] adding starting items to inventoryList...");
        if (InventorySize < startingItems.Length)
        {

        }

        foreach (ItemStack stack in startingItems)
        {
            if (AddItemStack(stack))
            {
                Debug.Log($"[Inventory.Awake] successfully added item {stack} to inventoryList");
            }
            else
            {
                Debug.Log($"[Inventory.Awake] failed to add item {stack} to inventoryList");
            }
        }
        #endregion
    }

    // Add an ItemStack to this inventory!!!!
    public bool AddItemStack(ItemStack stack)
    {
        // attempt to add the stack into the inventoryList
        return false;
    }

    public void OnSelectChanged()
    {
        if (ui != null)
        {
            ui.SelectSlot(selectedIndex);
        }
    }
}
