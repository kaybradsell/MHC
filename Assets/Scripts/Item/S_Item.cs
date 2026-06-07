using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Item")]
public class S_Item : ScriptableObject
{
    // an item has a name, texture, description, cost.
    // it can have more, but for now, that's all.

    [SerializeField] private Texture m_texture;
    [SerializeField] private string m_name;
    [SerializeField] private string m_description;
    [SerializeField] private uint m_cost;

    public string GetName() {  return m_name; }
    public string GetDescription() {  return m_description; }
    public Texture GetTexture() {  return m_texture; }
    public uint Getcost() {  return m_cost; }

    // for now, item has no behaviours. It provides getters so the UI handler
    // can get those and display it when needed. A regular item is just an item
    // that cannot be used, only exists in inventory for crafting.
}
