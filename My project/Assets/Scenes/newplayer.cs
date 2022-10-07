using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newplayer : MonoBehaviour
{
    public GameObject bullet;
    public float projectilForce = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fire(InputAction.CallbackContext context)
    {
        GameObject go = Instantiate(bullet);
        go.GetComponent<Rigidbody>().AddForce(transform.forward);
    }
}
