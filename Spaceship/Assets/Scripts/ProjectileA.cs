using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileA : MonoBehaviour {
    [SerializeField] private Rigidbody rigidbody;

    public void Launch(Vector3 velocity) {
        rigidbody.velocity = velocity;
    }
}
