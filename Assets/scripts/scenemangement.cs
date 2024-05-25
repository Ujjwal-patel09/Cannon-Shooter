using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemangement : MonoBehaviour
{
  public void  play() {

    SceneManager.LoadScene(1);
  }

  public void restart(){

    SceneManager.LoadScene(1);
    score.Score = 0;
  }

  public void exit(){
    SceneManager.LoadScene(0);
    score.Score = 0;
  }

  public void quitgame(){

    Application.Quit();
  }
}
