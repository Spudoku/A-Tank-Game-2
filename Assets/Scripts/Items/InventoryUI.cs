using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] Inventory targetInventory;     // the inventory to read data from
    [SerializeField] GameObject slotPrefab;
    [SerializeField] Transform panel;
    [Header("Current State")]
    [SerializeField] List<InventorySlot> inventorySlots;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (targetInventory != null)
        {
            // initialize this somehow...
            Init();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Init()
    {
        targetInventory.ui = this;  // establish connection between this InventoryUI and targetInventory

        // instantiate prefabs
        if (slotPrefab != null)
        {
            if (!slotPrefab.TryGetComponent<InventorySlot>(out var slotTest))
            {
                Debug.LogError("Error: slotPrefab");
                return;
            }

        }
        else
        {
            Debug.LogError("error: no slot prefab");
            return;
        }

        if (panel == null)
        {
            Debug.LogError("Error: no panel");
            return;
        }


        // create inventory slots
        for (int i = 0; i < targetInventory.InventorySize; i++)
        {
            GameObject newSlotGO = Instantiate(slotPrefab, panel);

        }

        // select slot 1, item, etc.
        SelectSlot(0);
    }

    public void SelectSlot(int slot)
    {

    }
}
