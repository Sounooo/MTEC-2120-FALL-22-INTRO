using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Reaktion
{
   // [RequireComponent(typeof(ParticleSystem))]
    public class reaktionparticle : MonoBehaviour
    {
       // public GameObject Particle;
        public ParticleSystem ps;

        // Start is called before the first frame update
        void Start()
        {
            ps = GetComponent<ParticleSystem>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
