// Khai báo các namespace mà script sẽ sử dụng
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Khai báo class "dialog" để điều khiển hộp thoại trong trò chơi
public class dialog : MonoBehaviour
{
    // Tham chiếu đến TextMeshProUGUI component được gắn với UI element để hiển thị văn bản
    public TextMeshProUGUI textcomponent;

    // Một mảng các chuỗi đại diện cho các dòng văn bản trong hộp thoại
    public string[] line;

    // Chỉ số của dòng văn bản hiện tại trong mảng "line"
    public int index;

    // Tốc độ hiển thị văn bản, quy định thời gian chờ giữa việc hiển thị mỗi ký tự
    public float textspeed;

    // Tham chiếu đến GameObject chứa hộp thoại, được sử dụng để bật/tắt hộp thoại
    public GameObject panel;

    // Phương thức này được gọi khi game bắt đầu
    void Start()
    {
        // Đặt văn bản của text component thành chuỗi trống
        textcomponent.text = string.Empty;

        // Bắt đầu hiển thị hộp thoại
        startdialog();
    }

    // Phương thức này được gọi mỗi frame
    void Update()
    {
        // Kiểm tra nếu người dùng nhấn phím Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Kiểm tra nếu văn bản đang hiển thị là dòng cuối cùng của hộp thoại
            if (textcomponent.text == line[index])
            {
                // Chuyển sang dòng văn bản tiếp theo
                nextLine();
            }
            else
            {
                // Dừng tất cả các coroutine hiện tại và hiển thị ngay lập tức dòng văn bản tiếp theo
                StopAllCoroutines();
                textcomponent.text = line[index];
            }
        }
    }

    // Phương thức này bắt đầu hiển thị hộp thoại
    void startdialog()
    {
        // Đặt chỉ số của dòng văn bản về 0
        index = 0;

        // Bắt đầu coroutine để hiển thị từng ký tự trong dòng văn bản
        StartCoroutine(TypeLine());
    }

    // Coroutine để hiển thị từng ký tự trong dòng văn bản
    IEnumerator TypeLine()
    {
        foreach (char c in line[index].ToCharArray())
        {
            // Thêm ký tự vào văn bản và chờ một khoảng thời gian trước khi hiển thị ký tự tiếp theo
            textcomponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    // Phương thức này chuyển sang dòng văn bản tiếp theo
    void nextLine()
    {
        // Kiểm tra nếu vẫn còn dòng văn bản trong hộp thoại
        if (index < line.Length - 1)
        {
            // Tăng chỉ số của dòng văn bản lên 1
            index++;

            // Đặt văn bản của text component thành chuỗi trống và bắt đầu coroutine để hiển thị dòng văn bản mới
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            // Nếu không còn dòng văn bản nào, tắt panel chứa hộp thoại
            panel.SetActive(false);
        }
    }
}
