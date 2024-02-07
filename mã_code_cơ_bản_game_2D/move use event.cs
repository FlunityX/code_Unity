using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public event EventHandler abc;
    [SerializeField] float a = 1;
    // Start is called before the first frame update
    void Start()
    {
  
    }
     void Moveright(object sender ,EventArgs s)
    {
        this.transform.Translate(new Vector3(a,0,0));
    }
    void Moveleft(object sender, EventArgs s)
    {
        this.transform.Translate(new Vector3(-a, 0, 0));
    }
    // Update is called once per frame
    void Update()
    {
        abc?.Invoke(this, EventArgs.Empty);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            abc += Moveleft;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            abc += Moveright;
        }
    }
}
