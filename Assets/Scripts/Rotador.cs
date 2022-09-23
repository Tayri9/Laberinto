using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{

    [SerializeField]
    float rotacionY;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0.0f);
    }
}
