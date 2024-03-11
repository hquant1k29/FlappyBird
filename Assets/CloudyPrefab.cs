using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudyPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public float cloudSpeed = 5;
    public Rigidbody2D rigid;
    private float destroyZone = -20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = cloudSpeed * Vector2.left;
        if(transform.position.x < destroyZone) {
            Destroy(gameObject);
        }
        //transform.position = transform.position + Vector3.left * cloudSpeed * Time.deltaTime;
    }
}
