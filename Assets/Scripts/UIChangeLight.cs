using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeLight : MonoBehaviour
{
    float angel = 0f;

    public void ChangeAngel()
    {
        angel += 30;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angel));
    }
}
