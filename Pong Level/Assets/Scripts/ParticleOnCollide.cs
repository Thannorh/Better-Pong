using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnCollide : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }
    public class ParticleStarter : MonoBehaviour
    {

        private ParticleSystem _psystem;

        void Awake()
        {
            _psystem = GetComponent<ParticleSystem>();
        }

        void OnTriggerEnter(Collider col)
        {


            _psystem.Play();

        }
    }
}
  
