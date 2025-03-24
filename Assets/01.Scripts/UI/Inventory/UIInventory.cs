using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] TextMeshProUGUI _txt_CurCapacity;

    [Header("Item Slots")]
    [SerializeField] List<UISlot> _slots;

    [Header("Button")]
    [SerializeField] Button _btn_Back;
}
