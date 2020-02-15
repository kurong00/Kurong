using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Trick : MonoBehaviour
{
    public Sprite before,after;
    void Start()
    {
        before = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        { 
            gameObject.GetComponent<SpriteRenderer>().sprite = after;
            gameObject.GetComponent<Light2D>().enabled = true;
        }
    }

    public void OnTriggerExit2D()
    { gameObject.GetComponent<SpriteRenderer>().sprite = before;
            gameObject.GetComponent<Light2D>().enabled = false;
       
    }
}
