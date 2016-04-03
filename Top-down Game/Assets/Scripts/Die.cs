using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	void Start () {
    Invoke("Dead", 1f);
	}
	
	void Dead () {
    Destroy(gameObject);
	}
}
