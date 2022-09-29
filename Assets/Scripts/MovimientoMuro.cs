using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMuro : MonoBehaviour
{
    [SerializeField]
    Vector3 posicionA;

    [SerializeField]
    Vector3 posicionB;

    Vector3 posicionMuro;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        posicionMuro = gameObject.GetComponent<Transform>().position;
        
        if(posicionMuro != posicionA)
        {
            transform.position += new Vector3(0.0f, 0.0f, -0.1f) * Time.deltaTime;
        }
        
        Debug.Log(posicionMuro);
    }
    
}
