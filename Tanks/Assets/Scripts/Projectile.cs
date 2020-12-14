using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] private Rigidbody rigidbody;

    public void Launch(Transform muzzle, Material material) {
        transform.position = muzzle.position;
        transform.rotation = muzzle.rotation;
        rigidbody.velocity = transform.forward * 10f;
        transform.GetComponent<MeshRenderer>().material = material;
    }
}
