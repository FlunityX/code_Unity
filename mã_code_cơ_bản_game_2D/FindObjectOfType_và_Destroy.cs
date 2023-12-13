
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // đặt 1 biến tên là m_gc kiểu GameController

    // 1 tham chiếu đến GameObject

   GameController m_gc;

   private void Start () {

   //FindObjectOfType<GameController>() để tìm đối tượng GameController trong game và gán tham chiếu của nó vào biến m_gc.

        m_gc = FindObjectOfType<GameController>();

   }
 private void OnCollisionEnter2D(Collision2D other)
      {

     if(other.gameObject.CompareTag("Player")){

      // gọi phương thức tăng điểm của GameController 

      m_gc.tangdiem();
      
        Debug.Log(" bong da va cham voi gia do ");
     }
    }

 private void OnTriggerEnter2D(Collider2D other) {

      if (other.CompareTag("Deathzone")){

         // gọi phương thức isGameover là true để phá huỷ GameObject 

         m_gc.SetisGameover(true);

         Destroy(gameObject);

         Debug.Log(" game over");
      }
    }
}
