using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {
    void Start() {
        Debug.Log("SpaceshipMovement.Start()");
    }

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("SpaceshipMovement.Update(): W pressed");
            transform.position = transform.position + new Vector3(0, .02f, 0);
        } else if (Input.GetKey(KeyCode.A)) {
            Debug.Log("SpaceshipMovement.Update(): A pressed");
            transform.position = transform.position + new Vector3(-.02f, 0, 0);
        } else if (Input.GetKey(KeyCode.S)) {
            Debug.Log("SpaceshipMovement.Update(): S pressed");
            transform.position = transform.position + new Vector3(0, -.02f, 0);
        } else if (Input.GetKey(KeyCode.D)) {
            Debug.Log("SpaceshipMovement.Update(): D pressed");
            transform.position = transform.position + new Vector3(.02f, 0, 0);
        }
    }
}
