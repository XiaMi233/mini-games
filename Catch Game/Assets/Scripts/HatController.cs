using UnityEngine;
using System.Collections;

public class HatController : MonoBehaviour {

  public Camera cam;

  public GameObject gameController;

  float maxWidth;

  float hatWidth;

  Rigidbody2D rbody;

	void Start () {
    if (cam == null) {
      cam = Camera.main;
    }

      rbody = GetComponent<Rigidbody2D>();

      Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
      Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
      hatWidth = GetComponent<Renderer>().bounds.extents.x;

      maxWidth = targetWidth.x - hatWidth;
	}

	// Update is called once per frame
	void FixedUpdate () {
    if (gameController.GetComponent<GameController>().playing) {
      Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
      Vector3 targetPosition = new Vector3(Mathf.Clamp(rawPosition.x, -maxWidth, maxWidth), -3f, 0.0f);
      rbody.MovePosition(targetPosition);
    }
	}
}
