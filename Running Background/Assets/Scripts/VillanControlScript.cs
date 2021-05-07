using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillanControlScript : MonoBehaviour
{


    public GameObject bigBullet;
    Vector2 bulletPos;
    private Rigidbody2D playerRigidbody;
    public float fireRate = 2f;
    float nextFire = 0.0f;
     public Text villanHealthValue;

    public float accelerationTime = 2f;
    public float maxSpeed = 5f;

    private Vector2 movement;
 
    public float HealthHP = 100.0f;


    public void Awake(){
        playerRigidbody=GetComponent<Rigidbody2D>();
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

     movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
     playerRigidbody.AddForce(movement * maxSpeed);

     if(Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }        

        if(HealthHP<=0)
        {
          Destroy(gameObject);
        }
    }

    public void fire(){
        bulletPos = playerRigidbody.transform.position;
        bulletPos += new Vector2 (+1f,-0.43f);
        Instantiate(bigBullet,bulletPos,Quaternion.identity);
    }
    
   void OnTriggerEnter2D(Collider2D collider){
     if(collider.tag=="HeroBullet")
     {
       Destroy(collider.gameObject);
       HealthHP = HealthHP - 10;
       print("HealthHP of Villan"+HealthHP);
         villanHealthValue.text = HealthHP.ToString();

     }
   }

}

