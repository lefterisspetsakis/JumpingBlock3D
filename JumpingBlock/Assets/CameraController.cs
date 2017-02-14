using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraDistOffsety = 3;
    public float cameraDistOffsetz = 10;
    private Camera mainCamera;
    private GameObject player;

    // Use this for initialization
    void Start ()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y + cameraDistOffsety, playerInfo.z - cameraDistOffsetz);
    }
}
