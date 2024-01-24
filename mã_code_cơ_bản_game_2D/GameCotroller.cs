using System.Net.Mime;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    // tạo ra bóng kế tiếp sau lần tạo trc 
    public float spawnTime;
    // lưu giá trị điểm , lưu trữ giá trị spawnTime , kiểm tra trnagj thái trò chơi đã kết thứuc chưa
    // private do ko chấp nhận bên ngoài 
    int m_score;
    float m_spawnTime;
    bool m_isGameover;
    // Start is called before the first frame update
    [SerializeField ]UIManager m_ui;
    void Start()
    {
        m_spawnTime =0;
       
        m_ui.SetScoreText("ScoreText ");
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_isGameover){
            m_spawnTime = 0;
           
            return;
        }
        if(m_spawnTime <0){
            SpawnBall();
            m_spawnTime =spawnTime;
        }
    }
       public void SpawnBall () {
        Vector2 spawnPos = new Vector2(UnityEngine.Random.Range(-7,7),6);
        if(gameObject){
            Instantiate(gameObject,spawnPos,Quaternion.identity);
        }
       }
    public int GetScore () {
    return m_score;
    }
    public void SetScore (int value ) {
    m_score = value;
    }
   
    public void tangdiem(){
      m_score++;
      m_ui.SetScoreText("Score :"+ m_score);
    }
    
    public bool GetisGameover () {
        return m_isGameover;
        
    }
    public void SetisGameover (bool state) {
    m_isGameover = state;
    }
    
}
