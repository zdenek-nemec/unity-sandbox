using UnityEngine;

// Controls
// * [W] - Accelerate
// * [S] - Decelerate
// * [A] - Turn left
// * [D] - Turn right
// * [Space] - Fire
// * [X] - Reset movement
// * [P] - Switch spaceship color
[RequireComponent(typeof(Rigidbody))]
public class Spaceship : MonoBehaviour {
    [SerializeField] private Sprite[] skins;
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private float projectileSpeed = 1;
    private int currentSkin = 0;

    private void Update() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W)) {
            rigidbody.velocity += transform.up * .02f;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.velocity -= rigidbody.velocity * .005f;
            if (rigidbody.velocity.x < .02f && rigidbody.velocity.y < .02f && rigidbody.velocity.z < .02f) {
                rigidbody.velocity = Vector3.zero;
            }
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 0, -1f);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.X)) {
            Debug.Log("Spaceship.Update: Reset");
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            transform.rotation = new Quaternion(Quaternion.identity.x, Quaternion.identity.y, transform.rotation.z, transform.rotation.w);
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
