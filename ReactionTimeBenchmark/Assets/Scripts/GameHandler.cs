using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameHandler.Start(): Started");

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("GameHandler.Update(): Started");

        SpriteRenderer sprite;
        sprite = GetComponentInChildren<SpriteRenderer>();
        if (Input.GetKeyDown(KeyCode.C)) {
            Debug.Log("GameHandler.Update(): C pressed");
        sprite.color = new Color (1, 0, 0, 1);
        }
        // Debug.Log("GameHandler.Update(): Finished");
    }
}
