using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] Slider _slidersound;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Getvolume")){
            _slidersound.value = PlayerPrefs.GetFloat("Getvolume",1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeVolume() 
    {
        AudioListener.volume = _slidersound.value;
        Save();
    }
    public void Load()
    {
        _slidersound.value = PlayerPrefs.GetFloat("Getvolume"); 
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("Getvolume",_slidersound.value);
    }
}
