using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnCollide : MonoBehaviour
{
    public ParticleSystem _psystem;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Awake()
    {
        _psystem = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _psystem.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _psystem.Play();
    }
}