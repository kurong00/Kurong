using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollow : MonoBehaviour
{
    [SerializeField]
    GameObject worldPos;
    [SerializeField]
    RectTransform rectTrans;
    public Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(worldPos.transform.position);
        rectTrans.position = screenPos + offset;
    }
}
