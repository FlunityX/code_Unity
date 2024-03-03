using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiate_follow_mouse : MonoBehaviour
{
    Vector3 mousepos;
    [SerializeField]GameObject _object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Lấy vị trí chuột trong không gian thế giới

        if (Input.GetMouseButtonDown(0)) // Kiểm tra xem nút chuột trái đã được nhấn xuống chưa
        {
            Vector3 offset = new Vector3(0, 0, 10); // Tạo một vector offset với giá trị (0, 0, 10)
            Instantiate(_object, mousepos + offset, Quaternion.identity); // Tạo một phiên bản mới của đối tượng _object tại vị trí chuột cộng với offset và với góc xoay mặc định
        }
    }
}
