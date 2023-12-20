
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_cs : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      int soluong= 12;   
       for(int i = 0; i < soluong; i++) {

            this.spawn(i);
        }
    }
public void spawn (int i) {
    Debug.Log("no lap "+ i+ " lan ");
}
}
