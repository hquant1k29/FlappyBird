using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float VelocityPipe  = 5;
    private float DestroyZone = -20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * VelocityPipe) * Time.deltaTime;
        if(transform.position.x < DestroyZone) {
            Debug.Log("Delete" + gameObject.name);
            Destroy(gameObject);
        }
    }
}
