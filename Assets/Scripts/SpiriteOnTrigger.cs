using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SpiriteOnTrigger : MonoBehaviour
{
    bool nevermeet = true;
    GameObject player = null;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (nevermeet && collision.CompareTag("Player"))
        {
            Flowchart.BroadcastFungusMessage("FairyStory");
            nevermeet = false;
            player = collision.gameObject;
            player.GetComponent<CharacterController2D>().CanMove = false;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    public void PlayerCanMove()
    {
        if(player)
            player.GetComponent<CharacterController2D>().CanMove = true;
    }
}
