using UnityEngine;
using System.Collections;

public class HoverAudio : MonoBehaviour {

    public AudioSource jetSound;
    private float jetPitch;
    private const float lowPitch = .1f;
    private const float highPitch = 2.0f;
    private const float SpeedToRevs = .01f;

    Vector3 myVelocity;
    Rigidbody carRigidbody;

    
	void Awake () {
        carRigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        myVelocity = carRigidbody.velocity;
        float forwardSpeed = transform.InverseTransformDirection(myVelocity).z;
        Debug.Log(myVelocity);
        Debug.Log(transform.TransformDirection(myVelocity));
        Debug.Log(transform.InverseTransformDirection(myVelocity));
        float engineRevs = Mathf.Abs(forwardSpeed) * SpeedToRevs;
        jetSound.pitch = Mathf.Clamp(engineRevs, lowPitch, highPitch);
	}
}
