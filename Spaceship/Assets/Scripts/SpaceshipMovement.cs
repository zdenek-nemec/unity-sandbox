using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {
    void Start() {
        Debug.Log("SpaceshipMovement.Start()");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("SpaceshipMovement.Update(): W pressed");
            transform.position = transform.position + new Vector3(0, .1f, 0);
        } else if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("SpaceshipMovement.Update(): A pressed");
            transform.position = transform.position + new Vector3(-.1f, 0, 0);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("SpaceshipMovement.Update(): S pressed");
            transform.position = transform.position + new Vector3(0, -.1f, 0);
        } else if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("SpaceshipMovement.Update(): D pressed");
            transform.position = transform.position + new Vector3(.1f, 0, 0);
        }
    }
}
