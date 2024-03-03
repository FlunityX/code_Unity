using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variadate : MonoBehaviour
{
    public float a;
    // Start is called before the first frame update
    private void OnValidate()
    {
        if (a > 10)
        {
            Destroy(gameObject);
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
