using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public float lowerheigth;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        OutOfBound();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }

    public void OutOfBound()
    {
        if(transform.position. y < lowerheigth)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
    }

}
