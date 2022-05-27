using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateDirectionalLight : MonoBehaviour
{
    private float rotationMultiplier = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotationMultiplier * Time.deltaTime);
    }
}
