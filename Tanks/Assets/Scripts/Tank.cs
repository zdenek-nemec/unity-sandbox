using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
    [SerializeField] private Material playerMaterial;
    [SerializeField] private Projectile projectilePrefab;
    private bool controls = false;
    private int speedMultiplier = 1;

    public void AssumeControl() {
        controls = true;
        foreach (Transform child in transform) {
            if (!child.name.Equals("Muzzle")) {
                child.GetComponent<MeshRenderer>().material = playerMaterial;
            }
        }
    }

    public void ReleaseControl() {
        controls = false;
    }

    private void Update() {
        if (!controls) {
            return;
        }

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W)) {
            rigidbody.velocity = transform.forward * 3f * speedMultiplier;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.velocity = transform.forward * -3f;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, -1f, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speedMultiplier = 2;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            speedMultiplier = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }
    }

    private void Fire() {
        var projectile = Instantiate(projectilePrefab);
        foreach (Transform child in transform) {
            if (child.name.Equals("Muzzle")) {
                projectile.Launch(child, playerMaterial);
                break;
            }
        }
    }
}
