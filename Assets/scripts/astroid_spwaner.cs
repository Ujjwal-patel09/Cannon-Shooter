using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid_spwaner : MonoBehaviour
{
    public GameObject enemy; // use to store astroid prefeb.
    
    private float sptime = 2f; // this is the spwan time .
    private float rtime = 2f; // this is repeate time .

    
    void Start()
    {
        InvokeRepeating("inst",sptime,rtime);// this line is use for repeating things in game .
    }

    
    void Update()
    {
        if(score.Score >=20){
       
            rtime = 1f; // this is use for incresing difficulty of game after 20 points by decrese in repeate time ;
        }
    }
    void inst(){// this function is use in start function in this random position is set first and then instantiate astroid prefeb name enemy
                // at random position .

        Vector3 randomspwn = new Vector3 (Random.Range(-15f,+15f),7.4f,0);

        Instantiate(enemy,randomspwn,transform.rotation);
    }
}
