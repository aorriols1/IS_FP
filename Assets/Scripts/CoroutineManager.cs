using UnityEngine;
using System.Collections;

public class CoroutineManager : MonoBehaviour
{
    private static CoroutineManager _instance;

    public static CoroutineManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("CoroutineManager");
                _instance = obj.AddComponent<CoroutineManager>();
                DontDestroyOnLoad(obj);
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void StartRoutine(IEnumerator routine)
    {
        StartCoroutine(routine);
    }
}
