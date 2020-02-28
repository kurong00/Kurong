using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text mytext;
    public void ChangeText(string str)
    {
        mytext.text = str;
        StartCoroutine(FadeText());
    }

    public IEnumerator FadeText()
    {
        yield return new WaitForSeconds(2);
        mytext.text = "";
    }
}
