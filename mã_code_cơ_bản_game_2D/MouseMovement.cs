using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Lấy tọa độ chuột trong không gian màn hình
        Vector3 mousePosition = Input.mousePosition;

        // Chuyển tọa độ chuột từ không gian màn hình sang không gian thế giới
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Đặt vị trí của GameObject theo vị trí chuột
        transform.position = new Vector3(worldPosition.x, worldPosition.y, 0f);
    }
}
