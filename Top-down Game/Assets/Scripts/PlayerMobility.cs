using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

  public float speed;

  Transform tf;
  Rigidbody2D rd;
  Animator anim;

  void Start() {
    tf = GetComponent<Transform>();
    rd = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      anim.SetTrigger("Attack");
    }
  }

	void FixedUpdate () {
    var mousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Quaternion rot = Quaternion.LookRotation(tf.position - mousePostion, Vector3.forward);

    tf.rotation = rot;
    tf.eulerAngles = new Vector3(0, 0, tf.eulerAngles.z);
    rd.angularVelocity = 0;

    float input = Input.GetAxis("Vertical");
    rd.AddForce(tf.up * speed * input);
	}
}
