using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]
public class particlecontrol : MonoBehaviour
{
    private MapAction control;

    private void Awake()
    {
        control = new MapAction();
    }
    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
    //public GameObject Particle;
    [SerializeField] ParticleSystem Particle = null;
    [SerializeField] ParticleSystem Particle2 = null;
    [SerializeField] ParticleSystem Particle3 = null;
    [SerializeField] ParticleSystem Particle4 = null;
    [SerializeField] ParticleSystem Particle5 = null;
    // Start is called before the first frame update
    void Start()
    {
        control.Player.Effect1.performed += _ => PlayerEffect1();
        control.Player.Effect2.performed += _ => PlayerEffect2();
        control.Player.Effect3.performed += _ => PlayerEffect3();
        control.Player.Effect4.performed += _ => PlayerEffect4();
        control.Player.Effect5.performed += _ => PlayerEffect5();
    }

    private void PlayerEffect1()
    {
        Particle.Play();
    }

    private void PlayerEffect2()
    {
        Particle2.Play();
    }

    private void PlayerEffect3()
    {
        Particle3.Play();
    }

    private void PlayerEffect4()
    {
        Particle4.Play();
    }

    private void PlayerEffect5()
    {
        Particle5.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
