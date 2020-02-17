using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggle : MonoBehaviour
{
    Toggle toggle;
    public GameObject player, shadow,shadowCam;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { ToggleValueChanged(toggle); });
    }

    void ToggleValueChanged(Toggle toggle)
    {
        if (toggle.isOn)
        {
            player.GetComponent<CharacterController2D>().CanMove = true;
            shadow.GetComponent<CharacterController2D>().CanMove = false;
            shadowCam.SetActive(false);
        }
        else
        {
            player.GetComponent<CharacterController2D>().CanMove = false;
            shadow.GetComponent<CharacterController2D>().CanMove = true;
            shadowCam.SetActive(true);
        }
    }
}
