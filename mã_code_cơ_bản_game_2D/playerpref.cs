using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    public float so;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) {
            so++;
            _text.text = "click =" + so;
        }
        if(so >= 10) {
            PlayerPrefs.SetFloat("highscore", so);
        }
        float sodaluu = PlayerPrefs.GetFloat("highscore");
        Debug.Log("đã lưu trữ " + sodaluu);
    }
}
