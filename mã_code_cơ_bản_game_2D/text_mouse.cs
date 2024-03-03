using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_mouse : MonoBehaviour
{
    // Tham chiếu đến các đối tượng TextMeshProUGUI trong scene
    public TextMeshProUGUI TextMeshProUGUI; // Được sử dụng để hiển thị vị trí chuột
    public TextMeshProUGUI TextMeshProUGUI1; // Được sử dụng để hiển thị số nguyên

    // Biến số nguyên để lưu trữ số lần nhấn chuột
    public int number;

    // Phương thức Start được gọi trước khi khung hình đầu tiên được vẽ
    void Start()
    {
        // Không có hoạt động cụ thể được thực hiện ở đây trong ví dụ này
    }

    // Phương thức Update được gọi mỗi frame
    void Update()
    {
        // Kiểm tra nếu người dùng nhấn phím "0" trên bàn phím
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // Lấy giá trị số nguyên từ cơ sở dữ liệu cục bộ với key "number" và gán vào biến "highscore"
            int highscore = PlayerPrefs.GetInt("number", number);

            // Log giá trị số nguyên đã lấy được
            Debug.Log(highscore);
        }

        // Kiểm tra nếu người dùng nhấn chuột trái
        if (Input.GetMouseButtonDown(0))
        {
            // Tăng giá trị biến "number" lên 1
            number++;

            // Hiển thị giá trị của biến "number" trên TextMeshProUGUI1
            TextMeshProUGUI1.text = number.ToString();

            // Lưu giá trị số nguyên vào cơ sở dữ liệu cục bộ với key "number"
            PlayerPrefs.SetInt("number", number);

            // Lấy vị trí chuột trong không gian màn hình
            Vector3 mouseposition = Input.mousePosition;

            // Chuyển vị trí chuột từ không gian màn hình sang không gian thế giới
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mouseposition);

            // Đặt vị trí của TextMeshProUGUI theo vị trí chuột
            TextMeshProUGUI.transform.position = new Vector3(worldPosition.x, worldPosition.y, 0f);

            // Hiển thị TextMeshProUGUI
            TextMeshProUGUI.gameObject.SetActive(true);
        }

        // Kiểm tra nếu người dùng nhả chuột trái
        if (Input.GetMouseButtonUp(0))
        {
            // Ẩn TextMeshProUGUI
            TextMeshProUGUI.gameObject.SetActive(false);
        }
    }
}
