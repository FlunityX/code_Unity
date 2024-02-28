using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_follow_mouse : MonoBehaviour
{
    public float angle;         // Góc quay
    public Vector3 rotation;    // Vị trí chuột trong không gian thế giới
    public Vector3 dir;         // Hướng từ vị trí hiện tại đến vị trí chuột

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Cập nhật vị trí chuột trong không gian thế giới
        rotation = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Tính toán hướng từ vị trí hiện tại đến vị trí chuột
        dir = rotation - this.transform.position;

        // Chuẩn hóa hướng
        dir.Normalize();

        // Tính toán góc quay từ hướng chuẩn hóa
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        // Đặt góc quay cho đối tượng
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}