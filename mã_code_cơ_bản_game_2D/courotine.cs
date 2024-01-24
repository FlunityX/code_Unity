using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class courotine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] SpriteRenderer _sp;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        _sp.enabled= true;
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
