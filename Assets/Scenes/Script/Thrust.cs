using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    Rigidbody rb;
    public GameObject victim;
    public GameObject anothervictim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject == victim)
        {
            Destroy(victim);
        }

        if(myCollision.gameObject == anothervictim){
            Destroy(anothervictim);
        }
    }
}
