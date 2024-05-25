using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    
    void Start()
    {
        Destroy(this.gameObject,1f);// this function is use to destroy particle system prefeb which is instantiate while collision of bullet 
                                    // and astroid thhis script is attach with particle system prefeb.
    }
   
}
