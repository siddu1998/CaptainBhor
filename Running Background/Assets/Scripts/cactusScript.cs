using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        print(collision.gameObject.tag);
        if(collision.gameObject.tag == "HeroCharacter"){
            PlayerControl.HeroHealth+=-1.0f;
        }
        
        
        
    }
}
