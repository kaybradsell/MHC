using UnityEngine;

// struct that stores item ref and uint amount.
// can be used for inventory, but also for recipe ingredients,
// so it's a public struct.
[System.Serializable]
public struct ItemNum
{
    Item item;
    uint amount;
}

public class S_Inventory : MonoBehaviour
{
    
}
