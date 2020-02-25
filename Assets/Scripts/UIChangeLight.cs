using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeLight : MonoBehaviour
{
    float angel = 0f;
    public GameObject shadowlight;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shadow"))
        {
            shadowlight.SetActive(true);
        }
    }

    public void ChangeAngel()
    {
        angel -= 90;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angel));
    }
}
