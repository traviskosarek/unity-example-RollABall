using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 offset;
    public GameObject Player;

    // Use this for initialization
    void Start () {
        this.offset = this.transform.position - Player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = Player.transform.position + this.offset;
    }
}
