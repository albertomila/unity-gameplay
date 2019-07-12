using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;

    public static void CreateInstance()
    {
        Debug.Assert(_instance == null);
        _instance = UnityEngine.Object.FindObjectOfType<T>();
        Debug.Assert(_instance != null, "Instance " + typeof(T).ToString() + " doesn't exist");
    }

    public static T GetInstance()
    {
        Debug.Assert(_instance != null, "Instance doesn't exist");
        return _instance;
    }

    public static bool IsValid()
    {
        return _instance != null;
    }
}
