using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Spaceship : MonoBehaviour {
    [SerializeField] private Sprite[] skins;
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private float projectileSpeed = 1;
    private int currentSkin = 0;
    private Vector3 zeroVelocity;

    private void Update() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

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

        // if (Input.GetKeyDown(KeyCode.D)) {
        //     zeroVelocity = rigidbody.velocity;
        //     Vector3 velocity = transform.right * 1;
        //     rigidbody.velocity = velocity;
        // } else if (Input.GetKeyUp(KeyCode.D)) {
        //     rigidbody.velocity = zeroVelocity;
        // }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            currentSkin = (currentSkin + 1) % skins.GetLength(0);
            this.GetComponent<SpriteRenderer>().sprite = skins[currentSkin];
        }
    }

    private void Fire() {
        foreach (var weapon in weapons) {
           weapon.Fire(projectileSpeed);
        }
    }
}
