using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Rigidbody rdbody;

	// Use this for initialization
	void Start () {
        rdbody = GetComponent<Rigidbody>();
        rdbody.velocity = new Vector3(-10.0f, 9.0f, 0.0f);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
