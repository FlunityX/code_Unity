using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camerashake : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachinevirtualCamera;
    public float shaketimer;


    public static camerashake instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Another instance of camerashake already exists. Destroying this one.");
            Destroy(gameObject);
            return;
        }

        instance = this;
        cinemachinevirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Start()
    {
        cinemachinevirtualCamera =GetComponent<CinemachineVirtualCamera>();
    }


    public void shakecamera(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
            cinemachinevirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        shaketimer = time;
    }

    private void Update()
    {

            if (shaketimer > 0)
            {
                shaketimer -= Time.deltaTime;
                if(shaketimer <=0)
                {
                    CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
                        cinemachinevirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                    cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
                    shaketimer = 0;
                }
        }
    }
}
