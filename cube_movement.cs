using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movement : MonoBehaviour
{
   public float rotationSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube around its X and Y axes
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}