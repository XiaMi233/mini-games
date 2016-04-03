using UnityEngine;
using System.Collections;

public class EnemyMobility : MonoBehaviour {

  public float speed;
  public Transform player;

  Transform tf;
  Rigidbody2D rd;

	void Start () {
    tf = GetComponent<Transform>();
    rd = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
    float z = Mathf.Atan2(player.position.y - tf.position.y, 
      player.position.x - tf.position.x) * Mathf.Rad2Deg - 90;

    tf.eulerAngles = new Vector3(0, 0, z);

    rd.AddForce(tf.up * speed);
	}
}
