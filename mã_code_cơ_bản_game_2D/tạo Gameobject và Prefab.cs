using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vị_trí_nhân_vật : MonoBehaviour
{
    float playerPosX;
    List<GameObject> minions;
    public GameObject minionPrefab;

    void Start()
    {
        minions = new List<GameObject>();
    }

    void Update()
    {
        playerPosX = transform.position.x;
        int spawnLocation = 7;

        if (playerPosX <= spawnLocation)
            notspawn();
        else{
            spawn();
            Checkminion();}
        
    }

    public void notspawn()
    {
        Debug.Log("Nhân vật ở vị trí điểm x nhỏ hơn 7");
    }

    void spawn()
    {
        if (minions == null)
            return;

        if(minions.Count >=7) return;
            int index = minions.Count + 1;
            GameObject minion = Instantiate(minionPrefab);
            minion.name = "Minion " + index;
            minion.transform.position = this.transform.position;
            minions.Add(minion);
             minion.SetActive(true);
           
        Debug.Log("Nhân vật ở vị trí điểm x lớn hơn 7");
    }
    void Checkminion(){
         if (minions.Count > 7)
        {
            minions.RemoveRange(0, 7);
        }
    }
  
}
