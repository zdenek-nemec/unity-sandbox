using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
