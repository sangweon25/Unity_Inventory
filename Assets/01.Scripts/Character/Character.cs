using UnityEngine;

public class Character : MonoBehaviour
{
    public int _atk { get; private set; }
    public int _def { get; private set; }
    public int _hp { get; private set; }
    public int _critRate { get; private set; }
    public int _lv { get; private set; }
    public int _curExp { get; private set; }
    public int _maxExp { get; private set; }
    public int _gold { get; private set; }

    Character()
    {
        _atk = 5;   
        _def = 5;
        _hp = 100;
        _critRate = 5;
        _lv = 1;
        _curExp = 0;
        _maxExp = 12;
        _gold = 20000;
    }
}
