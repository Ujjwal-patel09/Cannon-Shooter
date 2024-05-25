using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bullet; // use to store bullet prefeb.
    public Transform spawner; // use to store the spawner position .

    

    void Start()
    {
        
        spawner = GetComponent<Transform>();
    }


     public void binst(){ // this fuction is use for instantiate bullet from spwaner position and this is accessesable by ui button form 
                          // otside the script therefore it is become public void .

            Instantiate(bullet,spawner.transform.position,spawner.transform.rotation);
    }
       
       
    


}
