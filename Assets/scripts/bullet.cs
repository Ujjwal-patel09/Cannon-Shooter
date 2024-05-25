using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject particles; // to store particle system
 
    
    private float bspeed = 500f;
    
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
      
    }

    void FixedUpdate() {
        rb.velocity = bspeed*Time.fixedDeltaTime*transform.up; // this is for the movement of bullet.
        
    }

    private void OnBecameInvisible() { // this function is use when any object go outside the scene boundries and become invisible

        Destroy(this.gameObject);
        
        
    }
    private void OnCollisionEnter2D(Collision2D col) {
        
        if(col.gameObject.tag == "astroid"){

            Destroy(this.gameObject);
            Instantiate(particles,transform.position,transform.rotation); // this line is use for instantiate particle system in game 
                                                                          // when bullet collide with astroid.in this "particles are save
                                                                          // as gameobject in variables .
    
    
        }
    }
}
