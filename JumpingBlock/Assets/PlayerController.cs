using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Quaternion addRot;
	// Use this for initialization
	void Start ()
    {
        this.rb = GetComponent<Rigidbody>();
        this.addRot = Quaternion.identity;
    }
	
	// Update is called once per frame
	void Update ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
