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
}
