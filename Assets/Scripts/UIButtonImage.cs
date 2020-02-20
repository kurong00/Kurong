using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonImage : MonoBehaviour
{
    public float holdTime = 1.5f;

    float timer=0;

    public Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (GetComponent<UIButtonLongPress>().isHold)
        {
            timer += Time.deltaTime;
            image.fillAmount = Mathf.Lerp(0, 1, timer / holdTime);

            if (timer >= holdTime)
            {
                timer = 0;
            }
        }
    }
}
