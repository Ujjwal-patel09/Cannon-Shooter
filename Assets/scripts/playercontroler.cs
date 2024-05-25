using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroler : MonoBehaviour
{
    private float speed = 170f;
    private bool moveleft;
    private bool moveright;


    // Start is called before the first frame update
    void Start()
    {
        moveleft = false;
        moveright = false;

    }

    // Update is called once per frame
    void Update()
    {
       movearound();

       if(score.Score >=20){
        speed = 220f;
       }
        
    }
    // this function is used by  ui button onclick property
    public void PointerDownLeft(){
        moveleft = true;
    }
    public void PointerupLeft(){
        moveleft = false;
    }

    public void POinterDownRight(){
        moveright = true;
    }
    public void Pointerupright(){
        moveright = false;
    }

    private void movearound(){

        if(moveleft == true){

            transform.Rotate(0,0,speed*Time.fixedDeltaTime);
        }
        else if(moveright == true){

             transform.Rotate(0,0,-speed*Time.fixedDeltaTime);
        }
        else if(moveleft == false){
             transform.Rotate(0,0,0);

        }
         else if(moveright == false){
             transform.Rotate(0,0,0);

        }

    }
    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.tag == "astroid"){

            SceneManager.LoadScene(2);
           
        }
    }
}
