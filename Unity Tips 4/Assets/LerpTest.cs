using UnityEngine;
using System.Collections;

public class LerpTest : MonoBehaviour {

    public float destination = 2.0f;

	// Update is called once per frame
	void Update () {
        //float newPositionX = Mathf.Lerp(transform.position.x, destination, Time.deltaTime);
        //transform.position = new Vector3(newPositionX, 0, 0);
        //Debug.Log(Time.deltaTime);
        Debug.Log(Time.time);
        float translation = Time.deltaTime * 10;
        transform.Translate(0, 0, translation);
    }
}
