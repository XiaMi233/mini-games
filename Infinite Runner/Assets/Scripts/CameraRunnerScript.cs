using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;

	private Transform m_transform;

	void Start () {
		m_transform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {
		m_transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}
