using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public List<Item> Inventory;

    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int CritRate { get; private set; }
    public int Lv { get; private set; }
    public int CurExp { get; private set; }
    public int MaxExp { get; private set; }
    public int Gold { get; private set; }

    public Character()
    {
        Atk = 5;   
        Def = 5;
        Hp = 100;
        CritRate = 5;
        Lv = 1;
        CurExp = 0;
        MaxExp = 12;
        Gold = 20000;
    }

    public void AddItem()
    {

    }

    public void Equip(Item item)
    {
        Atk += item.Atk;
        Def += item.Def;
        Hp += item.Hp;
        CritRate += item.CritRate;
        GameManager.Instance.SetData();
    }

    public void UnEquip(Item item)
    {
        Atk-= item.Atk;
        Def-= item.Def;
        Hp-= item.Hp;
        CritRate-= item.CritRate;
        GameManager.Instance.SetData();
    }
}
