using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
    void Update() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W)) {
            rigidbody.velocity = transform.right * -3f;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.velocity = transform.right * 3f;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, -1f, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 1f, 0);
        }
    }
}
