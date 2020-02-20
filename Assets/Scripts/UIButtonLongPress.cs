using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIButtonLongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField]
    private float holdTime = 1.5f;
    public bool isHold;

    public UnityEvent onLongPress = new UnityEvent();

    public void OnPointerDown(PointerEventData eventData)
    {
        isHold = true;
        Invoke("OnLongPress", holdTime);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHold = false;
        CancelInvoke("OnLongPress");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHold = false;
        CancelInvoke("OnLongPress");
    }

    private void OnLongPress()
    {
        isHold = true;
        onLongPress.Invoke();
    }
}