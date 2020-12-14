using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
    [SerializeField] private Tank tankPrefab;

    private void Start() {
        Debug.Log("GameHandler.Start");

        // Create tanks and randomly assign the player
        int playerTankIndex = Random.Range(0, 8);
        int index = 0;
        for (int x = -2; x <= 2; x += 2) {
            for (int z = -2; z <= 2; z += 2) {
                var tank = Instantiate(tankPrefab);
                tank.transform.position = new Vector3(x, 1f, z);
                if (index++ == playerTankIndex) {
                    tank.AssumeControl();
                }
            }
        }
    }

    private void Update() {
    }
}
