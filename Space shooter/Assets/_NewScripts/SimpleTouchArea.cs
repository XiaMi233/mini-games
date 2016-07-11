using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class SimpleTouchArea : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private bool touched;
    private bool canfire;

    public bool Canfire {
        get {
            return canfire;
        }

        set {
            canfire = value;
        }
    }

    void Awake() {
        touched = false;
    }

    public void OnPointerDown(PointerEventData eventData) {
        if (!touched) {
            touched = true;
            canfire = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData) {
        touched = false;
        canfire = false;
    }
}
