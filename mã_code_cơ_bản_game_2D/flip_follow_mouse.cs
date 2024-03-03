using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip_follow_mouse : MonoBehaviour
{
    public Vector3  mousepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 distance = mousepos - transform.position;
        distance.Normalize();
        if(distance.x > 0)
        {
            if (transform.localScale.x < 0)
            {
                this.transform.localScale = new Vector3(transform.localScale.x*(-1),transform.localScale.y,transform.localScale.z);
            }
        }
        else if (distance.x < 0)
        {
            if(transform.localScale.x > 0)
            {
                this.transform.localScale = new Vector3(transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z);
            }
        }


    }
}
