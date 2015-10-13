using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    public float RotationSpeeed = 2f;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * RotationSpeeed);
	}
}
