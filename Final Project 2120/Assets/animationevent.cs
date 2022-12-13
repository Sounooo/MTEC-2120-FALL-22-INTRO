using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;

public class animationevent : MonoBehaviour
{
    public GameObject spray;
    public GameObject spray2;
    Spray sprayParticle;
    Spray sprayParticle2;
    // Start is called before the first frame update
    void Start()
    {
        sprayParticle = spray.GetComponent<Spray>();
        sprayParticle2 = spray2.GetComponent<Spray>();
        //sprayParticle.throttle = 0.0f;
        //sprayParticle2.throttle = 0.0f;
    }

    public void Spray(float duration)
    {
        //Debug.Log("spray paticle");
        StartCoroutine(SprayForDuration(duration));
    }

    IEnumerator SprayForDuration(float duration)
    {
        sprayParticle.lifeRandomness = 1.0f;
        sprayParticle.throttle = 0.5f;
        //sprayParticle2.throttle = 0.5f;



        //sprayParticle2.directionSpread = 0.4f;


        //Debug.Log("spray paticle" + duration);
        yield return new WaitForSeconds(duration);
        sprayParticle.lifeRandomness = 0.0f;
        sprayParticle.throttle = 0.0f;


       // sprayParticle2.directionSpread = 0.0f;
        //sprayParticle2.throttle = 0.0f;



    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
