using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    void Start() {
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.X)) {
            transform.position = new Vector3(0, .25f, -2f);
            transform.rotation = new Quaternion(0, 0, 0, 0);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = transform.forward * 10f;
        }
    }
}
