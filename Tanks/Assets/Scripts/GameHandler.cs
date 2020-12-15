using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
    [SerializeField] private Tank tankPrefab;
    [SerializeField] private Material player1Material;
    [SerializeField] private Material player2Material;
    [SerializeField] private Material player3Material;
    [SerializeField] private Material player4Material;

    private void Start() {
        Debug.Log("GameHandler.Start");

        // Create tanks and randomly assign the player
        int player1Index = Random.Range(0, 9);
        int player2Index = Random.Range(0, 9);
        int player3Index = Random.Range(0, 9);
        int player4Index = Random.Range(0, 9);
        while (player2Index == player1Index) {
            player2Index = Random.Range(0, 9);
        }
        while (player3Index == player1Index || player3Index == player2Index) {
            player3Index = Random.Range(0, 9);
        }
        while (player4Index == player1Index || player4Index == player2Index || player4Index == player3Index) {
            player4Index = Random.Range(0, 9);
        }

        int index = 0;
        for (int x = -2; x <= 2; x += 2) {
            for (int z = -2; z <= 2; z += 2) {
                var tank = Instantiate(tankPrefab);
                tank.transform.position = new Vector3(x, 1f, z);
                if (index == player1Index) {
                    tank.AssumeControl("WASD", player1Material);
                } else if (index == player2Index) {
                    tank.AssumeControl("Arrows", player2Material);
                } else if (index == player3Index) {
                    tank.AssumeControl("Numeric", player3Material);
                } else if (index == player4Index) {
                    tank.AssumeControl("IJKL", player4Material);
                }
                index++;
            }
        }
    }

    private void Update() {
    }
}
