using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBulletScript : MonoBehaviour
{

    public float xVel = 2;
    public float yVel = 0;
    private Rigidbody2D bulletRigidbody;

    Vector2 moveDirection;
    public GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindWithTag("HeroCharacter");
        moveDirection = (target.transform.position-transform.position).normalized*xVel;
        bulletRigidbody.velocity = new Vector2(moveDirection.x,moveDirection.y);
        Destroy(gameObject,6f);
        
    }
    void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.tag=="HeroCharacter"){
        Destroy(gameObject);
        PlayerControl.HeroHealth+=-20.0f;
        
    }      
    if(collision.gameObject.tag=="Steps"){
        Destroy(gameObject);
    }    
    if(collision.gameObject.tag=="Cactus"){
        Destroy(gameObject);
    }        
   
     }



}
