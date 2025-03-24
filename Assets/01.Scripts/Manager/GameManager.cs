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
                string name = typeof(Character).ToString();
                var newObj = new GameObject(name);
                _player = newObj.AddComponent<Character>();
            }
        }
    }

    private void Start()
    {
        SetData();
    }

    void SetData()
    {
        UIManager.Instance.UIMainMenu.SetData(Player);
        UIManager.Instance.UIStatus.SetData(Player);
    }
}
