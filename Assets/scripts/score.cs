using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public  class score : MonoBehaviour
{
    public TextMeshProUGUI  text;

    public  AudioSource explosion;
    
    public static int Score = 0;

    // Update is called once per frame
    void Update()
    {
        text.text = Score.ToString();
       
    }
    public  void sound(){

        explosion.Play();
    }
}
