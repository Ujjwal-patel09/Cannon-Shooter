using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;



public class astroid : MonoBehaviour
{
    score sound;// here ,score script has store an variable name sound and rest in line 22

    public GameObject player; // use to store the player or cannon gameobject.
    private float speed = 2f;
    

    private float distance;

     void Start() {
        
       sound = GameObject.Find("scoremanager").GetComponent<score>();// here sound name variable is assine with gameobject name "scoremanger"
                                                                     // and after that assine with the script score attached with scoremager
                                                                     // and rest in line 44.
        
    }
   
    void Update()
    {

        transform.position = Vector2.MoveTowards(this.transform.position,player.transform.position,speed*Time.deltaTime);

        difficulty(); // this function is use to increse difficulty of game by incresing astroid speed.and rest in line 49.
    }
     private void OnCollisionEnter2D(Collision2D col) {
        
        if(col.gameObject.tag == "bullet"){

            Destroy(this.gameObject);
            score.Score += 1;
            
            sound.sound();// here sound name variable which is asssine with score script above has a function name sound is call .
          
        }
       
    }
    void difficulty(){
        
         if(score.Score >= 5){

            speed = 3f;
         }

         if(score.Score >= 10){

           speed = 4f;

        }
        if(score.Score >= 20){

            speed = 6f;
        }
        if(score.Score >= 40){

            speed = 8f;
        }
        if(score.Score >=50){

            speed = 10f;
        }
       

    }
        
    
}
