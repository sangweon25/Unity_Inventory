using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    Character _player;
    public Character Player { get { return _player; }  }

    private void Awake()
    {
        if (_player == null)
        {
            _player = FindObjectOfType<Character>();
            if (_player == null)
            {
                string _name = typeof(Character).ToString();
                var newObj = new GameObject();
                _player = newObj.AddComponent<Character>();
                _player.name = _name;
            }
        }
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        UIManager.Instance.UIMainMenu.SetData(Player);
        UIManager.Instance.UIStatus.SetData(Player);
    }
}
