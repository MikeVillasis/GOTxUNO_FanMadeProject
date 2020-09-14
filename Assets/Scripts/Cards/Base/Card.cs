using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
//Base Card Class: not to be instantiated.
public abstract class Card : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private Color HouseColor;
    [SerializeField] private Image CardImage;
    [SerializeField] private GameObject CustomToolTip;

    //All Cards must have a Drag Event
    public virtual void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    //All Cards must have a Drop Event
    public virtual void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    private void OnMouseOver()
    {
        Debug.Log("I'm hovering over the card");
    }

    private void OnMouseExit()
    {
        Debug.Log("I'm no longer hovering over the card");
    }
    private void OnGUI()
    {
        
    }

}
