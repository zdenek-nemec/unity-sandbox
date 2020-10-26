using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {
    void Start() {
        Debug.Log("SpaceshipMovement.Start()");
        // TODO: Move spaceship to mid-bottom
    }

    void Update() {
        // Debug.Log("SpaceshipMovement.Update()");

        // Movement
        if (Input.GetKey(KeyCode.W)) {
            transform.position = transform.position + new Vector3(0, .02f, 0);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position = transform.position + new Vector3(-.02f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position = transform.position + new Vector3(0, -.02f, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position = transform.position + new Vector3(.02f, 0, 0);
        }

        // Fire
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("SpaceshipMovement.Update(): Space pressed");
        }
    }
}