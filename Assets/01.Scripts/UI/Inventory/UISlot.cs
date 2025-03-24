using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] Button _slot;
    [SerializeField] Image _image;
    [SerializeField] Image _img_Equip;
    [SerializeField] Item _item; // ScriptableObject

    private void Start()
    {
        RefreshUI();
        _slot.onClick.AddListener(OnEquip);
        _img_Equip.gameObject.SetActive(false);
    }

    public void SetItem(Item item)
    {
        _item = item;
    }

    public void OnEquip()
    {
        if (!_item.isEquip)
        {
            _item.isEquip = true;
            _img_Equip?.gameObject.SetActive(true);
            GameManager.Instance.Player.Equip(_item);
        }
        else
        {
            _item.isEquip = false;
            _img_Equip?.gameObject.SetActive(false);
            GameManager.Instance.Player.UnEquip(_item);
        }
    }

    public void RefreshUI()
    {
        if (_item != null)
            _image.sprite = _item._Icon;
    }

}
