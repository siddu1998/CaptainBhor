using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] elements;
    private Vector2 spawn_location;
    private int index;

    public float fireRate = 2f;
    float nextFire = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            index = Random.Range(1, elements.Length);
            spawn_location = new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f));
            Instantiate(elements[index],spawn_location,Quaternion.identity);
        }       

        
    }
}
