using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float xVel = 5;
    public float yVel = 0;
    private Rigidbody2D bulletRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = new Vector2(xVel,yVel);
        Destroy(gameObject,3f);
        
    }


    void OnCollisionEnter2D(Collision2D collision){
   Destroy(collision.gameObject);
     }


}
