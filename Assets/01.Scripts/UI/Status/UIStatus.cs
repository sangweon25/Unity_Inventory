using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] List<TextMeshProUGUI> _statusValue;

    [Header("Button")]
    [SerializeField] Button _btn_Back;

    private void Start()
    {
        _btn_Back.onClick.AddListener(CloseStatus);
    }

    public void CloseStatus()
    {
        this.gameObject.SetActive(false);
    }
    public void SetData(Character player)
    {
        _statusValue[0].text = $" {player._atk}";
        _statusValue[1].text = $" {player._def}";
        _statusValue[2].text = $" {player._hp}";
        _statusValue[3].text = $" {player._critRate}";
    }
}
