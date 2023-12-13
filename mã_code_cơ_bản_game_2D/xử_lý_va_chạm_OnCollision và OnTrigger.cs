
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 private void OnCollisionEnter2D(Collision2D other)
      {
     if(other.gameObject.CompareTag("Player")){
        Debug.Log(" bong da va cham voi gia do ");
     }}
// OnCollisionEnter2D cho phép va chạm 2 box sẽ thực thi ,

//đều kiện (biến đó . (gameObject) . CompareTag("...tag cần vật va chạm")){ ... thực thi}

//dùng trong các trường hợp như chướng ngại vật , vật vật lý ,...

//  OnTrigerEnter2D cho phép va chạm xuyên 1 trong 2 có is Trigger là nó sẽ thực hiện lệnh 

điều kiện(biến đó .CompaReTag ("... tag cần vật va chạm "){...thực thi}

// dùng trong các trường hợp ăn đồ vật phải xuyên .
     private void OnTrigerEnter2D(Collision2D other)
      {
 if(other.gameObject.CompareTag("Deathzone")){
        Debug.Log("game over");
     }
    }
}
