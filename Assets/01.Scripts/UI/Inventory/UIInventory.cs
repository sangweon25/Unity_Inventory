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
    [SerializeField] Transform _slotPrefab;

    [Header("Button")]
    [SerializeField] Button _btn_Back;
    [SerializeField] Button _btn_NewItem;

    private UISlot prefab;
    [SerializeField] List<Item> _items;

    private void Start()
    {
        prefab = Resources.Load<UISlot>("Prefabs/Slot");
        _btn_Back.onClick.AddListener(CloseInventory);
        _btn_NewItem.onClick.AddListener(AddItem);
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
                int rand = Random.Range(0, _items.Count);
                _slots[i].SetItem(_items[rand]);

            }
        }
    }

    public void AddItem()
    {
        _slots.Add(Instantiate(prefab));
        _slots[_slots.Count-1].transform.SetParent(_slotPrefab);
        _slots[_slots.Count-1].name = $"Slot ({_slots.Count-1})";
        int rand = Random.Range(0, _items.Count);
        _slots[_slots.Count - 1].SetItem(_items[rand]);
        UpdateCurCapacity();
    }
    
    private void UpdateCurCapacity()
    {
        _txt_CurCapacity.text = _slots.Count.ToString();
    }
}
