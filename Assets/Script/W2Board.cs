using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;
    Vector3 initPos;
    public Transform[]hazard;
    public AudioSource ufoSource { get; private set; }
    public AudioSource ufo;
    public GameObject colorcChangeTile;
    
    

    

    
    

    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;
        ufoSource = GetComponent<AudioSource>();
        
        
        



    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        { player.transform.position += new Vector3(0, 0, -1); }
        if (Input.GetKeyDown(KeyCode.A))
        { player.transform.position += new Vector3(-1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.UpArrow))

        {
            player.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))

        { player.transform.position += new Vector3(0, 0, -1); }
        if (Input.GetKeyDown(KeyCode.LeftArrow))

        { player.transform.position += new Vector3(-1, 0, 0); }
       


        for( int i = 0; i  <hazard.Length; i++)
        {
            if (hazard[i].position == player.transform.position)
            {

                player.transform.position = initPos; ufoSource.Play();

            }


        }

        if (colorcChangeTile.transform.position == player.transform.position)
        {
            colorcChangeTile.GetComponent<Renderer>().material.color = Color.blue;
        }




    }



}








