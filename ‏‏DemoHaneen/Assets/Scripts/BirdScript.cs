using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{ 
    public Rigidbody2D myridgidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
 //   public int level = 0; //just for testing

    // Start is called before the first frame update - runs once on start
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame - runs constantly while running
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myridgidBody.velocity = Vector2.up * 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
 /*   //just for testing
    public void increaseLevel()
    {
        level++;
    }*/
}
