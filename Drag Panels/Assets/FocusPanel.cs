using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class FocusPanel : MonoBehaviour, IPointerDownHandler {

    private RectTransform rectTransform;

	void Awake () {
        rectTransform = GetComponent<RectTransform>();	
	}

    public void OnPointerDown(PointerEventData eventData) {
        rectTransform.SetAsLastSibling();
    }
}
