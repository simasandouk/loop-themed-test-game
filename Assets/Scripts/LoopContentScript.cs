using UnityEngine;
using UnityEngine.EventSystems;

public class LoopContentScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Smth nested");
        GameObject dropped = eventData.pointerDrag;
        if (dropped == null) return;

        dropped.transform.SetParent(transform.GetChild(0).GetChild(0));
    }
}
