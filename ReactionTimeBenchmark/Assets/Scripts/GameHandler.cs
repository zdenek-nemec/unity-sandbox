using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
    private GameObject boxGameObject;
    private float startTime, eventTime, clickTime;
    private bool eventTriggered;
    private bool gameOver;

    [SerializeField] private Sprite whitePixel;

    private void Start() {
        Debug.Log("GameHandler.Start");
        eventTriggered = false;
        gameOver = false;
        CreateBox();
        StartCoroutine(ExampleCoroutine());
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            clickTime = Time.time;
            Debug.Log("GameHandler.Update: Left mouse button pressed at " + clickTime);
            if (eventTriggered == true && gameOver == false) {
                float reactionTime = clickTime - eventTime;
                Debug.Log("GameHandler.Update: Reaction time: " + reactionTime + "s");
                gameOver = true;
            }
        }
    }

    private void CreateBox() {
        boxGameObject = new GameObject("Box", typeof(SpriteRenderer));
        boxGameObject.transform.localScale = new Vector3(16f, 9f, 1f);
        SpriteRenderer boxSpriteRenderer = boxGameObject.GetComponent<SpriteRenderer>();
        boxSpriteRenderer.sprite = whitePixel;
        boxSpriteRenderer.color = Color.blue;
    }

    private IEnumerator ExampleCoroutine() {
        startTime = Time.time;
        Debug.Log("GameHandler.ExampleCoroutine: Started at " + startTime);
        yield return new WaitForSeconds(2);

        SpriteRenderer boxSpriteRenderer = boxGameObject.GetComponent<SpriteRenderer>();
        boxSpriteRenderer.color = Color.red;
        eventTime = Time.time;
        Debug.Log("GameHandler.ExampleCoroutine: Event at " + eventTime);
        eventTriggered = true;
    }
}
