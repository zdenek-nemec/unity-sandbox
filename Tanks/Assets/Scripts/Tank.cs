﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
    [SerializeField] private Projectile projectilePrefab;
    private Material material = null;
    private bool controlsWasd = false;
    private bool controlsArrows = false;
    private bool controlsNumeric = false;
    private bool controlsIjkl = false;
    private int speedMultiplier = 1;

    public void AssumeControl(string controls, Material material) {
        if (controls == "WASD") {
            controlsWasd = true;
        } else if (controls == "Arrows") {
            controlsArrows = true;
        } else if (controls == "Numeric") {
            controlsNumeric = true;
        } else if (controls == "IJKL") {
            controlsIjkl = true;
        }

        this.material = material;

        foreach (Transform child in transform) {
            if (!child.name.Equals("Muzzle")) {
                child.GetComponent<MeshRenderer>().material = material;
            }
        }
    }

    private void Update() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (controlsWasd) {
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
        } else if (controlsArrows) {
            if (Input.GetKey(KeyCode.UpArrow)) {
                rigidbody.velocity = transform.forward * 3f * speedMultiplier;
            }
            if (Input.GetKey(KeyCode.DownArrow)) {
                rigidbody.velocity = transform.forward * -3f;
            }

            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Rotate(0, -1f, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Rotate(0, 1f, 0);
            }

            if (Input.GetKeyDown(KeyCode.RightShift)) {
                speedMultiplier = 2;
            } else if (Input.GetKeyUp(KeyCode.RightShift)) {
                speedMultiplier = 1;
            }

            if (Input.GetKeyDown(KeyCode.RightControl)) {
                Fire();
            }
        } else if (controlsNumeric) {
            if (Input.GetKey(KeyCode.Keypad8)) {
                rigidbody.velocity = transform.forward * 3f * speedMultiplier;
            }
            if (Input.GetKey(KeyCode.Keypad5)) {
                rigidbody.velocity = transform.forward * -3f;
            }

            if (Input.GetKey(KeyCode.Keypad4)) {
                transform.Rotate(0, -1f, 0);
            }
            if (Input.GetKey(KeyCode.Keypad6)) {
                transform.Rotate(0, 1f, 0);
            }

            if (Input.GetKeyDown(KeyCode.KeypadPlus)) {
                speedMultiplier = 2;
            } else if (Input.GetKeyUp(KeyCode.KeypadPlus)) {
                speedMultiplier = 1;
            }

            if (Input.GetKeyDown(KeyCode.Keypad0)) {
                Fire();
            }
        } else if (controlsIjkl) {
            if (Input.GetKey(KeyCode.I)) {
                rigidbody.velocity = transform.forward * 3f * speedMultiplier;
            }
            if (Input.GetKey(KeyCode.K)) {
                rigidbody.velocity = transform.forward * -3f;
            }

            if (Input.GetKey(KeyCode.J)) {
                transform.Rotate(0, -1f, 0);
            }
            if (Input.GetKey(KeyCode.L)) {
                transform.Rotate(0, 1f, 0);
            }

            if (Input.GetKeyDown(KeyCode.H)) {
                speedMultiplier = 2;
            } else if (Input.GetKeyUp(KeyCode.H)) {
                speedMultiplier = 1;
            }

            if (Input.GetKeyDown(KeyCode.N)) {
                Fire();
            }
        }
    }

    private void Fire() {
        var projectile = Instantiate(projectilePrefab);
        foreach (Transform child in transform) {
            if (child.name.Equals("Muzzle")) {
                projectile.Launch(child, this.material);
                break;
            }
        }
    }
}
