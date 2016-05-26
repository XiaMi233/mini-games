using UnityEngine;
using System.Collections;

public class ProjectileFollow : MonoBehaviour {

    public Transform projectile;
    public Transform farLeft;
    public Transform farRight;

    private Transform _transfrom;
    void Awake() {
        _transfrom = GetComponent<Transform>();
    }

	void Update () {
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(projectile.position.x, farLeft.position.x, farRight.position.x);
        _transfrom.position = newPosition;
	}
}
