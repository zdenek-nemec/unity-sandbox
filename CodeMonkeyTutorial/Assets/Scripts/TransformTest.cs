using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        Debug.Log(transform);
        transform.position = new Vector3(1, 0, 0);

        Transform childTransform = transform.Find("ChildTransform");
        Debug.Log(childTransform.localPosition);
        Debug.Log(childTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0.01f, 0, 0);
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, .1f);
    }
}
