using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Slider slider;
    public float pr;
    public TextMeshProUGUI text;
    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {
        pr = 0;
        slider.enabled = true;
        StartCoroutine(loadgame());
        GameObject.SetActive(true);
    }

    // Update is called once per frame
    IEnumerator loadgame()
    {
        while (pr <= 20f)
        {
            slider.value = pr;
            pr += Time.deltaTime;
            yield return null;
            text.text = "loading..." + Mathf.FloorToInt(slider.value*5) + "%";
        }
        if (pr >= 19.8f) 
        {
            text.text = "loading... 100%";
            slider.enabled = false;
            GameObject.SetActive(false);    
        }
            
    }
}