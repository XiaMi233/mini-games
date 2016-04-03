using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

  public GameObject Die;

	void OnTriggerEnter2D (Collider2D other) {
    Instantiate(Die, other.transform.position, Quaternion.identity);
    Destroy(other.gameObject);	
	}
}
