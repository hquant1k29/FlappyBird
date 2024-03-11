using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCloudy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloudy;
    private float timer = 0;
    public float cloudyRate = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < cloudyRate) {
            timer = timer + Time.deltaTime;
        }
        else {
             Spawner1();
             timer = 0;
        }
    }
    public void Spawner1(){
         float lowestCloudy = transform.position.y - 3;
         float highestCloudy = transform.position.y + 3;
        GameObject.Instantiate(cloudy,new Vector3(transform.position.x,Random.Range(lowestCloudy,highestCloudy) ,0),transform.rotation);
    }
}
