using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sky : MonoBehaviour
{
    public Material[] skyboxes;
    public Material Skybox;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public float speed;

    Button button;
    // Start is called before the first frame update
    void OnEnable()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(skychange);
    }

    void OnDisable()
    {
        button = GetComponent<Button>();
        button.onClick.RemoveListener(skychange);
    }

    // Update is called once per frame
    void Update()
    {
        Skybox.SetFloat("_Rotation", Skybox.GetFloat("_Rotation") + Time.deltaTime * speed);
        sky2.SetFloat("_Rotation", sky2.GetFloat("_Rotation") + Time.deltaTime * speed);
        sky3.SetFloat("_Rotation", sky3.GetFloat("_Rotation") + Time.deltaTime * speed);
        sky4.SetFloat("_Rotation", sky4.GetFloat("_Rotation") + Time.deltaTime * speed);
    }

    public void skychange()
    {
        int x = Random.Range(0, skyboxes.Length - 1);
        RenderSettings.skybox = skyboxes[x];
    }
}
