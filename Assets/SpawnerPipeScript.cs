using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pipe;
    public float PipeRate = 2;
    private float timer = 0;
    public float HightPipe = 5;
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < PipeRate){
            timer = timer + Time.deltaTime;
        }
        else {
            Spawner();
            timer = 0;
        }
        
    }
    void Spawner(){
        float lowestPipe = -HightPipe + transform.position.y;
        float highestPipe = HightPipe + transform.position.y;
        GameObject x = GameObject.Instantiate(Pipe,new Vector3(transform.position.x,Random.Range(lowestPipe,highestPipe)),transform.rotation);
        
    }

}
