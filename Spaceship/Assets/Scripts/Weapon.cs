using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform transformMuzzle;

    public void Fire(float velocity) {
        var projectile = Instantiate(projectilePrefab);
        projectile.transform.position = transformMuzzle.position;
        projectile.Launch(transformMuzzle.up * velocity);
    }
}
