using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{


    private NewControls control;
    Animator animator;
    Vector2 playerInputVec;
    bool isRunning;

    Vector3 playerMovement;
    public float rotateSpeed = 100;

    Transform playerTransform;

    float currentSpeed;
    float targetSpeed;
    float walkSpeed = 0.2f;
    float runSpeed = 3.5f;



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
        playerTransform = transform;

        control.player.Fire.performed += _ => playerFire();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovePlayer();
    }

    public void GetPlayerMoveInput(InputAction.CallbackContext ctx)
    {
        playerInputVec = ctx.ReadValue<Vector2>();
    }

    public void GetPlayerRunningInput(InputAction.CallbackContext ctx)
    {
        isRunning = ctx.ReadValue<float>() > 0 ? true : false;
    }


    void RotatePlayer()
    {
        if (playerInputVec.Equals(Vector2.zero))
            return;
        playerMovement.x = playerInputVec.x;
        playerMovement.z = playerInputVec.y;

        Quaternion targetRotation = Quaternion.LookRotation(playerMovement, Vector3.up);
        playerTransform.rotation = Quaternion.RotateTowards(playerTransform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }

    void MovePlayer()
    {
        targetSpeed = isRunning ? runSpeed : walkSpeed;
        targetSpeed += playerInputVec.magnitude;
        currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, 0.5f);
        animator.SetFloat("Speed", currentSpeed);
    }

    private void playerFire()
    {

        animator.SetTrigger("fire");


    }


}
