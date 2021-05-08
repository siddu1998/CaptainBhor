using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementProperties : MonoBehaviour
{   
    public int numberOfElectrons;


    // Start
    void Start()
    {
       StartCoroutine(SelfDestruct());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator SelfDestruct()
      {
          yield return new WaitForSeconds(7f);
          PlayerControl.HeroHealth+=-1.0f;
          Destroy(gameObject);
      }

     void OnTriggerEnter2D(Collider2D collider){
     if(collider.tag=="HeroBullet")
     {
       Destroy(collider.gameObject);
       numberOfElectrons +=1;
       if(numberOfElectrons==8){
           Destroy(gameObject);
       }

     }
   }
}
