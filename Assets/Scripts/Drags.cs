using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    void Update()
    {
        if (transform.localScale.x <= 10)
        {
            transform.localScale = transform.localScale + new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = transform.localScale + new Vector3(-1, -1, -1);
        }
    }
}

