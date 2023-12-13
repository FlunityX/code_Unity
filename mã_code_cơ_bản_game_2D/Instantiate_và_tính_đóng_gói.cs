using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Đây là một GameObject được sử dụng để tạo ra các quả bóng trong trò chơi.

    public GameObject ball;

    //  Đây là thời gian giữa các lần tạo ra bóng mới.

    public float spawnTime;

    // int m_score: Biến này lưu trữ điểm số trong trò chơi.

    int m_score=0;

    // float m_spawnTime: Biến này lưu trữ giá trị spawnTime ban đầu.

    float m_spawnTime;

    // bool m_isGameover: Biến này kiểm tra xem trò chơi đã kết thúc chưa..

    bool m_isGameover;
    // Start is called before the first frame update
    void Start()
    {
        //Phương thức này được gọi khi game bắt đầu. Trong phương thức này, m_spawnTime được khởi tạo với giá trị ban đầu là 0.
        m_spawnTime = 0;
    }

    // Update is called once per frame

    void Update()
    {
        //Trong phương thức này, m_spawnTime được giảm đi theo thời gian bằng Time.deltaTime.

        m_spawnTime -= Time.deltaTime;

        // Nếu m_isGameover là true, m_spawnTime được đặt về 0 và phương thức kết thúc

        if (m_isGameover){

            // bạn không muốn tiếp tục tạo bóng nữa, do đó m_spawnTime được đặt thành

            // 0 để đảm bảo rằng không có thời gian chờ giữa các lần tạo bóng.

            m_spawnTime = 0;

            return;
        }

        // Nếu m_spawnTime nhỏ hơn 0, phương thức SpawnBall() được gọi để tạo ra một quả bóng mới,

        // sau đó m_spawnTime được đặt lại bằng giá trị spawnTime.

        if (m_spawnTime <0){

            SpawnBall();
            // ví dụ spawnTime = 2  thực hiện m_spawnTime =0 -> trừ còn <0 -> tạo bóng thì gán phương thức ->   m_spawnTime =spawnTime =2 rồi trừ dần 

            m_spawnTime = spawnTime;

        }
    }
       public void SpawnBall () {

        // một biến spawnPos được khởi tạo với một vị trí ngẫu nhiên trong phạm vi từ (-7, 7) trên trục x và 6 trên trục y.

        // UnityEngine.Random.Range(-7, 7) được sử dụng để lấy một số ngẫu nhiên trong khoảng từ -7 đến 7.

        Vector2 spawnPos = new Vector2(UnityEngine.Random.Range(-7,7),6);

        if(ball){

            //Hàm Instantiate() trong Unity được sử dụng để tạo ra một instance mới của một đối tượng (gọi là prefab)

            //trong không gian 3D hoặc 2D của trò chơi.

            //Quaternion.identity: Đây là tham số để xác định hướng xoay của instance mới.

            //Quaternion.identity đại diện cho hướng xoay không có sự thay đổi, nghĩa là instance sẽ không bị xoay và giữ nguyên hướng ban đầu của prefab.

            Instantiate(ball,spawnPos,Quaternion.identity);

        }

       }
    //Phương thức GetScore(), SetScore(int value):

    //GetScore() trả về giá trị của m_score.

    //SetScore(int value) thiết lập giá trị của m_score bằng giá trị đầu vào value.

    public int GetScore () {

    return m_score;
    }
    public void SetScore (int value ) {

    m_score = value;
    }
   // hàm tăng điểm 

    public void tangdiem(){

      m_score++;
    }
    //Phương thức GetisGameover(), SetisGameover(bool state):

    //GetisGameover() trả về giá trị của m_isGameover.

    //SetisGameover(bool state) thiết lập giá trị của m_isGameover bằng giá trị đầu vào state.

    public bool GetisGameover () {

        return m_isGameover;
        
    }
    public void SetisGameover (bool state) {

    m_isGameover = state;

    }
    
}
