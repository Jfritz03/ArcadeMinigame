using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour
{
    public float horizontalInput;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Rotate");
        transform.Rotate(Vector3.up, horizontalInput * rotatespeed * Time.deltaTime);
    }
}
