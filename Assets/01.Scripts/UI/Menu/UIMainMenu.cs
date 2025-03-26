using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] TextMeshProUGUI _txt_Gold;
    [SerializeField] TextMeshProUGUI _txt_LvValue;
    [SerializeField] TextMeshProUGUI _txt_Exp;

    [Header("Slider")]
    [SerializeField] Slider _bg_Exp;

    [Header("Button")]
    [SerializeField] Button _btn_Status;
    [SerializeField] Button _btn_Inventory;

    private void Start()
    {
        _btn_Status.onClick.AddListener(OpenStatus);
        _btn_Inventory.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }

    public void SetData(Character player)
    {
        _txt_Gold.text = $" {player.Gold}";
        _txt_LvValue.text = $"{player.Lv}";
        _txt_Exp.text = $"{player.CurExp} / {player.MaxExp}";
        _bg_Exp.value = player.CurExp;
    }
}
