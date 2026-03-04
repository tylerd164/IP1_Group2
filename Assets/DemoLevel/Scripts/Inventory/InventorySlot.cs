using UnityEngine;

[System.Serializable] 
public class InventorySlot
{
    [SerializeField] public Item item;
    [SerializeField] public int amount;

    public bool IsEmpty()
    {
        return item == null;
    }
}

