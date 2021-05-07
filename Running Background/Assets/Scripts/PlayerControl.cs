using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public float moveSpeed = 1f;
    public GameObject bulletToRight;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public static float HeroHealth = 100.0f;
    public Text heroHealthText;

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
        //check if key pressed and apply forces

        if(playerRigidbody!=null){
            ApplyInput();


        }else{
            //Debug.LogWarning('RigidBody Not Found');
        }


        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
    }


   
    public void ApplyInput(){
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * moveSpeed *Time.deltaTime;
        float yForce = yInput * moveSpeed *Time.deltaTime;
        Vector2 force = new Vector2(xForce,yForce);
        playerRigidbody.AddForce(force);
        //Debug.Log(xForce);

    }

    public void fire(){
        bulletPos = playerRigidbody.transform.position;
        //Debug.Log(bulletPos);
        bulletPos += new Vector2 (+1f,-0.43f);
        Instantiate(bulletToRight,bulletPos,Quaternion.identity);
    }
     
   
    public void setHealthText(){
        heroHealthText.text = "Player Health :" + HeroHealth.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            setHealthText();
    }

    






}
