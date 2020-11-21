using UnityEngine;

public class Weapon : MonoBehaviour {
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform transformMuzzle;

    public void Fire(float velocity) {
        var projectile = Instantiate(projectilePrefab);
        projectile.transform.position = transformMuzzle.position;
        projectile.transform.rotation = transformMuzzle.rotation;
        projectile.Launch(transformMuzzle.up * velocity);
    }
}
