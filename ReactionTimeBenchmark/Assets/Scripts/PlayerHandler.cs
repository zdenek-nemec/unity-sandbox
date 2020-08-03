using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer sprite;
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color (1, 0, 0, 1);
    }
}
