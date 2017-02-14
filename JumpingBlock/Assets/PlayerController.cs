using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        this.rb = GetComponent<Rigidbody>();
        this.rb.freezeRotation = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
