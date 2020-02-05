using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ShadowOnTrigger : MonoBehaviour
{
    GameObject player = null;
    GameObject shadow = null;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player = collision.gameObject;
            player.GetComponent<CharacterController2D>().CanMove = false;
            if(gameObject.name== "key_first") Flowchart.BroadcastFungusMessage("ShadowStory");
            else if (gameObject.name == "key_last") Flowchart.BroadcastFungusMessage("GetShadowStory");
        }
    }
    public void CreateShadow()
    {
        shadow = Instantiate(Resources.Load("Shadow", typeof(GameObject))) as GameObject;
        shadow.transform.parent = gameObject.transform;
        shadow.transform.localPosition = new Vector3(-1, -1, 0);
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    public void PlayerCanMove()
    {
        if (player)
            player.GetComponent<CharacterController2D>().CanMove = true;
    }
}
