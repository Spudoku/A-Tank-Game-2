using UnityEngine;

public class ItemGameObject : MonoBehaviour
{
    [SerializeField] ItemStack stack;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // attempt to add itself to an Inventory
        if (collision.gameObject.TryGetComponent<Inventory>(out var inventory))
        {
            PickUp(inventory);
        }
    }

    void PickUp(Inventory inventory)
    {
        // probably play a sound? particles?

        // add itself to the inventory?
        if (inventory.AddItemStack(stack))
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log($"[ItemGameObject.PickUp] could not be picked up!");
        }
    }
}
