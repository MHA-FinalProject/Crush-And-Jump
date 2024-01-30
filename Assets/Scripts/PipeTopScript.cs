using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTopScript : MonoBehaviour
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

    //The function is automatically called when the game object collides with a 2D element
    private void OnTriggerEnter2D(Collider2D collision)
    {

            logic.addScore(); 

    }
}