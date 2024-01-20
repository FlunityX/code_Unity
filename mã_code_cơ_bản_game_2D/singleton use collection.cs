using System.Collections;
using System.Collections.Generic;
using UnityEngine;
cách 1:
// Định nghĩa lớp singleton
public class SingletonClass: MonoBehaviour {
    private static SomeClass instance;

    public static SomeClass Instance { get { return instance; } }

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }
    }
}

// Sử dụng nó trong một lớp khác
public class AnotherClass: MonoBehaviour {
    public Singleton instance;

    private void Awake() {
       instance = Singleton.Instance;
    }
}

cách 2 :
public class SingletonClass : MonoBehaviour
{
    private static SingletonClass instance;

    public static SingletonClass Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SingletonClass>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<SingletonClass>();
                    singletonObject.name = "SingletonClass";
                    DontDestroyOnLoad(singletonObject);
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
public class AnotherClass : MonoBehaviour
{
    public SingletonClass instance;

    private void Awake()
    {
        instance = SingletonClass.Instance;
    }
}