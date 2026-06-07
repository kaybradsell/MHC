using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Recipe", menuName = "Item/Recipe")]
public class Recipe : ScriptableObject
{
    [System.Serializable]
    public struct Ingredient
    {
        Item item;
        uint amount;
    }

    // recipe has reference to item result
    // references to all ingredients
    // amount of each ingredient
    // total cost
    // level of the craft
    // and base stats needed to craft.
    // may also have function to check player inventory if the recipe is craftable
    // and hence remove the items from the inventory on craft. Maybe.

    [SerializeField] private Item m_result;
    [SerializeField] private List<Ingredient> m_ingredients;
    [SerializeField] private uint m_cost;
    [SerializeField] private uint m_level;
    //[SerializeField] private Stat m_statsRequired; // TODO: After adding stats, add base stats for crafting recipes here!

    public Item GetItem() {  return m_result; }
    public List<Ingredient> GetIngredients() {  return m_ingredients; }
    public uint GetCost() {  return m_cost; }
    public uint GetLeve() {  return m_level; }
    //public Stat GetRequiredStats() {  return m_statsRequired; }

}
