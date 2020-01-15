using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SpiriteOnTrigger : MonoBehaviour
{
    bool nevermeet = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (nevermeet && collision.CompareTag("Player"))
        {
            Flowchart.BroadcastFungusMessage("FairyStory");
            nevermeet = false;
        }
    }
}
