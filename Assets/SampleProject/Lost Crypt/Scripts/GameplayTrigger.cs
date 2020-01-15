using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class GameplayTrigger : MonoBehaviour
{
    public bool repeatable = false;
    GameObject scene1, scene2;

    private void Start()
    {
        scene1 = GameObject.Find("scene1");
        scene2 = GameObject.Find("scene2");
        scene2.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (enabled && collision.CompareTag("Player"))
        {
            GetComponent<PlayableDirector>().Play();
            if (!repeatable)
                enabled = false;
            scene2.SetActive(true);
            scene1.SetActive(false);
            
        }
    }
}
