using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {
  HUDScript hud;

  void Start() {
    hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == "Player") {
      hud.IncreaseScore(10);
      this.gameObject.SetActive(false);
    }
  }
}
