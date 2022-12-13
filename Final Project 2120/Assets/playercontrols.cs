using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]

public class playercontrols : MonoBehaviour
{
    
    private NewControls control;
    //private InputAction move;

    //private Rigidbody rb;
    public float speed = 1f;
    
  
    private Vector2 moveVector;
    private Animator animator;
    
    private CharacterController characterController;
    private void Awake()
    {
        //rb = this.GetComponent<Rigidbody>();
        control = new NewControls();

        
    }
    private void OnEnable()
    {
        
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        control.player.move.performed += _ => playermove();
        control.player.Run.performed += _ => playerRun();
        control.player.Fire.performed += _ => playerFire();
    }

    // Update is called once per frame
    void Update()
    {

        playermove();
        playerRun();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
        if (moveVector.magnitude > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        
    }
    private void playermove()
    {
        Vector3 move = transform.right * moveVector.x + transform.forward * moveVector.y;
        characterController.Move(move * speed * Time.deltaTime);

        

    }

    private void playerRun()
    {
        Vector3 move = transform.right * moveVector.x + transform.forward * moveVector.y;
        characterController.Move(move * speed * Time.deltaTime);

        speed = 1.5f;



    }

    private void playerFire()
    {

        animator.SetTrigger("casting Trigger");


    }
}
