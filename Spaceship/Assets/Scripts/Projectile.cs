using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] private Rigidbody rigidbody;

    public void Launch(Vector3 velocity) {
        rigidbody.velocity = velocity;
    }
}
