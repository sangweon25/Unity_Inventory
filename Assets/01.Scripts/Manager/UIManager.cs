using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] UIMainMenu _uIMainMenu;
    [SerializeField] UIStatus _uiStatus;
    [SerializeField] UIInventory _uIInventory;

    public UIMainMenu UIMainMenu { get { return _uIMainMenu; }}
    public UIStatus UIStatus { get { return _uiStatus; } }
    public UIInventory UIInventory { get { return _uIInventory; } }

    protected override void Init()
    {
        base.Init();
    }


}
