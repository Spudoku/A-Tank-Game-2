using UnityEngine;
// Interface for all items


[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]

public class Item : ScriptableObject
{
    [Header("Statistics")]
    public string itemName;
    public float useSpeed = 1f;      // the interval this item can be used in sequence

    public int maxStackSize = 1000; // maximum number of this Item that can exist in an ItemStack

    [Header("Cosmetics")]
    public Sprite sprite;

    public bool isConsumable;   // if true, use immediately after being picked up

    [Header("SoundEffects")]
    public AudioClip useClip;
    public AudioClip cantUseClip;   // Sound that plays when a cooldown is active

    public virtual void Use()
    {


    }

    public virtual void Use(Vector2 location, Quaternion rotation)
    {

    }

}
