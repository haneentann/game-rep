using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScrpipt : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(2);
            Debug.Log("Bird Collision");
        }
        else
        {
            Debug.Log("Collision is null");
        }
    }
}
