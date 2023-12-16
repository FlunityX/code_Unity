
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class this_if_destroy_debug : MonoBehaviour
{
    // tạo 2 biến để so sánh //
    public int dichuyen = 10;
    public int nghi = 20;
    // Start is called before the first frame update
    void Start()
    {
 // nếu dichuyen == nghi => phá huỷ vật thể 
 // nếu ko bằng nhau => chạy phương thức kohienthi 
 // this là đối tượng của script được gắn vào 
        if(dichuyen == nghi){
             Destroy(gameObject);
            Debug.Log("đã phá huỷ đối tượng");
        }
        else{
        this.kohiengi();}
    }
    
    public void kohiengi(){
        Debug.Log("ko phá đối tg");
    }
}
