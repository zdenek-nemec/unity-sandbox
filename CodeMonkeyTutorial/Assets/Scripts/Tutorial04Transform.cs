using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial04Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform healthBarTransform = transform.Find("HealthBar");
        healthBarTransform.localPosition = new Vector3(0, -5f, 0);

        GameObject childGameObject = new GameObject("ChildGameObject");
        childGameObject.transform.SetParent(transform);

        childGameObject.transform.SetAsFirstSibling();
        healthBarTransform.SetAsLastSibling();

        // foreach (Transform child in transform) {
        //     Debug.Log(child);
        // }

        for (int i = 0; i < transform.childCount; i++) {
            Debug.Log(transform.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(.01f, 0, 0);
    }
}
