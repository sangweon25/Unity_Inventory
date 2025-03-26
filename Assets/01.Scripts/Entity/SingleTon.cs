using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));
                if (_instance == null)
                {
                    string name = typeof(T).ToString();
                    var singletonObj = new GameObject(name);
                    _instance = singletonObj.AddComponent<T>();
                    DontDestroyOnLoad(singletonObj);
                }
            }
            return _instance;
        }
    }

    protected virtual void Init()
    {

    }

    private void Awake()
    {
        if (_instance != null)
            DontDestroyOnLoad(_instance);
    }
    private void Start()
    {
        Init();
    }
}