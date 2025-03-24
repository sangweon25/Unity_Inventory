using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class UIInventory : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] TextMeshProUGUI _txt_CurCapacity;

    [Header("Item Slots")]
    [SerializeField] List<UISlot> _slots;
    [SerializeField] Transform _slotPrefab;

    [Header("Button")]
    [SerializeField] Button _btn_Back;

    private UISlot prefab;

    private void Start()
    {
        prefab = Resources.Load<UISlot>("Prefabs/Slot");
        _btn_Back.onClick.AddListener(CloseInventory);
        InitInventoryUI();
        UpdateCurCapacity();
    }

    public void CloseInventory()
    {
        this.gameObject.SetActive(false);
    }

    public void InitInventoryUI()
    {
        if (_slots.Count < 9)
        {
            for (int i = _slots.Count; i < 9; i++)
            {
                _slots.Add(Instantiate(prefab));
                _slots[i].transform.SetParent(_slotPrefab);
                _slots[i].name = $"Slot ({i})";

            }
        }
    }
    
    private void UpdateCurCapacity()
    {
        _txt_CurCapacity.text = _slots.Count.ToString();
    }
}
