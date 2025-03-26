using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class Item : ScriptableObject
{
    public int Atk;
    public int Def;
    public int Hp;
    public int CritRate;
    public int Gold;
    public bool isEquip;

    public Sprite _Icon;
}
