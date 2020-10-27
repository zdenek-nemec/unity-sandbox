using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private float projectileSpeed = 1;

    private void Update() {
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

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }
    }

    private void Fire() {
        foreach (var weapon in weapons) {
           weapon.Fire(projectileSpeed);
        }
    }
}
