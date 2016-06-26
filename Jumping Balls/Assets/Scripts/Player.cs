using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    protected float jumpSpeed = 12.0f;

    private Rigidbody rdbody;

    [SerializeField]
    private bool isLanding = false;

	// Use this for initialization
	void Start () {
        rdbody = GetComponent<Rigidbody>();
        isLanding = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isLanding) {
            if (Input.GetMouseButtonDown(0)) {
                isLanding = false;
                rdbody.velocity = Vector3.up * this.jumpSpeed;
            }
        }	
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Floor") {
            isLanding = true;
        }
    }
}
