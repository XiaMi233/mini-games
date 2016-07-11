using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class SimpleTouchPad : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler {

    public float smoothing;
    private Vector2 origin;
    private Vector2 direction;
    private Vector2 smoothDirection;
    private bool touched;
    private int pointerId;

    public Vector2 Direction {
        get {
            return Vector2.MoveTowards(smoothDirection, direction, smoothing);
        }

        set {
            direction = value;
        }
    }

    void Awake () {
        direction = Vector2.zero;
        touched = false;
	}
	
    public void OnPointerDown(PointerEventData eventData) {
        if (!touched) {
            origin = eventData.position;
            pointerId = eventData.pointerId;
            touched = true;
        }
    }

    public void OnDrag(PointerEventData eventData) {
        //Compare the difference between our start point and current pointer postion
        if (eventData.pointerId == pointerId) {
            Vector2 currentPosition = eventData.position;
            Vector2 directionRaw = currentPosition - origin;
            direction = directionRaw.normalized;
        }
    }

    public void OnPointerUp(PointerEventData eventData) {
        if (eventData.pointerId == pointerId) {
            direction = Vector2.zero;
        }
    }
}
