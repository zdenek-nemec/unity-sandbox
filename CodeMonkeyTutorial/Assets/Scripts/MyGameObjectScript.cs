using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MyGameObjectScript.Start");
        GameObject myGameObject = new GameObject("MyNewGameObject");
        myGameObject.AddComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
