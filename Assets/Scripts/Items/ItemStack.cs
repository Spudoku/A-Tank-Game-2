using System;


[System.Serializable]
public class ItemStack
{
    public Item Item;
    public int Count;

    // Constructors
    public ItemStack(Item Item, int n)
    {
        this.Item = Item;
        AddToStack(n);
        if (Count < 1)
        {
            Count = 1;
        }
    }

    // add copies of Item to this stack, and prevent overflow
    public void AddToStack(int n)
    {
        Count += Math.Max(n, 1);
        if (Count > Item.maxStackSize)
        {
            Count = Item.maxStackSize;
            // TODO: split into a new stack or something?
        }
    }

    public void RemoveFromStack(int n)
    {
        Count -= Math.Max(n, 1);
        if (Count <= 0)
        {
            // Beg whatever is calling this method to delete the Itemstack.

        }
    }

    public override string ToString()
    {
        return Item.itemName + " " + Count;
    }
}