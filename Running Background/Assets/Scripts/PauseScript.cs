using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update

   bool isPaused = false;
   public void pauseGame(){
       if(isPaused)
       {
           Time.timeScale = 1;
           isPaused=false;
       }
       else{
           Time.timeScale = 0;
           isPaused = true;
       }
   }
}
