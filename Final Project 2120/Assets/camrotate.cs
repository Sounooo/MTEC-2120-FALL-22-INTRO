using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrotate : MonoBehaviour
{
    public Vector2 trun;
    public float sensitivity = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trun.y += Input.GetAxis("Mouse Y") * sensitivity;
        trun.x += Input.GetAxis("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(-trun.y, trun.x, 0);
    }
}
