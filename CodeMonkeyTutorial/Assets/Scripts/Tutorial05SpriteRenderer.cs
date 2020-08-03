using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial05SpriteRenderer : MonoBehaviour {
    public Sprite protoShip;

    void Start() {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = protoShip;
        spriteRenderer.color = new Color(1, 0, 0, 0.5f);
        spriteRenderer.sortingOrder = 10;
        spriteRenderer.sortingLayerName = "Over";

        GameObject protoShipGameObject = new GameObject("NewProtoShip", typeof(SpriteRenderer));
        SpriteRenderer protoShipSpriteRenderer = protoShipGameObject.GetComponent<SpriteRenderer>();
        protoShipSpriteRenderer.sprite = protoShip;
        protoShipSpriteRenderer.sortingOrder = 20;
        protoShipSpriteRenderer.sortingLayerName = "Over";
    }

    void Update() {
    }
}
