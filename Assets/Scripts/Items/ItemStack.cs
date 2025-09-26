using System;


[System.Serializable]
public class ItemStack
{
    public Item item;
    public int count;

    // Constructors
    public ItemStack(Item item, int n)
    {
        this.item = item;
        AddToStack(n);
        if (count < 1)
        {
            count = 1;
        }
    }

    // add copies of item to this stack, and prevent overflow
    public void AddToStack(int n)
    {
        count += Math.Max(n, 1);
        if (count > item.maxStackSize)
        {
            count = item.maxStackSize;
            // TODO: split into a new stack or something?
        }
    }

    public void RemoveFromStack(int n)
    {
        count -= Math.Max(n, 1);
        if (count <= 0)
        {
            // Beg whatever is calling this method to delete the itemstack.

        }
    }

    public override string ToString()
    {
        return item.itemName + " " + count;
    }
}