using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float speed;
    public float jumpHeight = 100f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * speed,0, Input.GetAxis("Vertical") * speed));
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }
}
