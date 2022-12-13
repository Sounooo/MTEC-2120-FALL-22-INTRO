using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]

public class skyboxcontroller : MonoBehaviour
{
    private NewControls control;
    public Material[] skyboxes;
    public Material Skybox;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public float speed;

    Button button;
    private void Awake()
    {
        control = new NewControls();
    }
     void OnEnable()
    {
        control.Enable();

      
    }

    void OnDisable()
    {
        control.Disable();
     
    }

    // Start is called before the first frame update


    void Start()
    {
        
        
       // Skybox = RenderSettings.skybox;
        control.Skychange.SKY2.performed += _ => SkychangeSKY2();
    }
    private void SkychangeSKY2()
    {
        int x = Random.Range(0, skyboxes.Length - 1);
        RenderSettings.skybox = skyboxes[x];
        //RenderSettings.skybox = sky2;


        // Update is called once per frame
        void Update()
        {
            Skybox.SetFloat("_Rotation", Skybox.GetFloat("_Rotation") + Time.deltaTime * speed);
            sky2.SetFloat("_Rotation", sky2.GetFloat("_Rotation") + Time.deltaTime * speed);
            sky3.SetFloat("_Rotation", sky3.GetFloat("_Rotation") + Time.deltaTime * speed);
            sky4.SetFloat("_Rotation", sky4.GetFloat("_Rotation") + Time.deltaTime * speed);

        }
    }

}
