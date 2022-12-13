using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    
   // public Transform cam;
    public float pLerp = 0.02f;
    public float rLerp = 0.01f;

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

        transform.position = Vector3.Lerp(transform.position, transform.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, rLerp);
    }
}
