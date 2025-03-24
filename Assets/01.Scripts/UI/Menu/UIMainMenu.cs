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


}
