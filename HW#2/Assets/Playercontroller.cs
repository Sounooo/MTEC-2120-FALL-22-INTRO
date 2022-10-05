using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]
public class Playercontroller : MonoBehaviour
{
    private PlayerAction control;

    private void Awake()
    {
        control = new PlayerAction();
    }
    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
    public GameObject Bullet;
    //public float jumpForce = 10;
    //Rigidbody rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        control.Player.Fire.performed += _ => PlayerFire();
        //rigid = GetComponent<Rigidbody>();
    }

    private void PlayerFire()
    {
        GameObject g = Instantiate(Bullet, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void onJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump is called.");
        rigid.AddForce(Vector3.up * jumpForce);
   }
   */ 
}

