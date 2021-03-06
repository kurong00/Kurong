﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ShadowOnTrigger : MonoBehaviour
{
    GameObject player = null;
    GameObject shadow = null;
    public GameObject cameraGate = null;
    public GameObject effect = null;
    public GameObject gate = null;

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
        gameObject.SetActive(false);
    }

    public void PlayerCanMove()
    {
        if (player)
            player.GetComponent<CharacterController2D>().CanMove = true;
    }

    public void ShowCamera()
    {
        if (cameraGate)
        { cameraGate.SetActive(true);}
    }

    public void DeleteGate()
    {
        if (gate)
        {
            StartCoroutine(DestroyGate());
        }
    }
    public IEnumerator DestroyGate()
    {
        yield return new WaitForSeconds(4);
        Destroy(gate);
        effect.GetComponent<ParticleSystem>().Play() ;
    }

    public void DeleteCamera()
    {
        if (cameraGate)
            cameraGate.SetActive(false);
    }
}
