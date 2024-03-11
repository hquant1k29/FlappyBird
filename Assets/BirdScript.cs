using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public Collider2D birdCollider;
    public float strengthFlight;
    public LogicScore bird;
    public bool check = true;
    public float safeZone = -8;

    void Start()
    {
        gameObject.name = "BirdHUST";

    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space) && check){
        myRigidbody.velocity = Vector2.up * strengthFlight;
        if(transform.position.y < safeZone) {
            check = false;
        }
    }
    }
    public void Checker(bool check){
       bird.gameOver();  
    }

    private void OnCollisionEnter2D(Collision2D collider){
        myRigidbody.gravityScale = 5;
        check = false;
        birdCollider.enabled = false;
        bird.gameOver();
    }
}
