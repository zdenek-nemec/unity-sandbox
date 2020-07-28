﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial06Component : MonoBehaviour {
    [SerializeField] private int health;  // Private variable that whows in Unity inspector
    [SerializeField] private bool myBool;
    [SerializeField] private string myString;

    public enum MyEnum {
        Red,
        Green,
        Blue
    }

    [SerializeField] private MyEnum myEnum;

    // Awake is called when component is initialised
    private void Awake() {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    private void Start() {
        Debug.Log("Start");
    }

    // Update is called once per frame
    private void Update() {
        Debug.Log("Update");
    }

    // LateUpdate is called after the update
    private void LateUpdate() {
        Debug.Log("LateUpdate");
    }

    // FixedUpdate is called after fixed time
    private void FixedUpdate() {
        Debug.Log("FixedUpdate");
    }

    // OnEnable is called when game object or component is enabled
    private void OnEnable() {
        Debug.Log("OnEnable");
    }

    // OnDisable is called when game object or component is disabled
    private void OnDisable() {
        Debug.Log("OnDisable");
    }
}
