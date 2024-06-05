using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class DragItem : DuyMonoBehavior, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Canvas parentCanvas;
    Vector3 Offset = Vector3.zero;

    protected override void loadComponents()
    {
        base.loadComponents();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePos = InputManager.Instance.MouseWorldPos;
        mousePos.z = 0;

        transform.parent.position = mousePos;
    }

    /*public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform,
            eventData.position, parentCanvas.worldCamera, out pos);
        Offset = transform.parent.position - parentCanvas.transform.TransformPoint(pos);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 movePos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform, eventData.position, parentCanvas.worldCamera, out movePos);
        transform.parent.position = parentCanvas.transform.TransformPoint(movePos) + Offset;
    }*/

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
    }
}
