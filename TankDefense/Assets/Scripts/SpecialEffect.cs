﻿using UnityEngine;
using System.Collections;

public class SpecialEffect : MonoBehaviour {

    public static SpecialEffect Instance;

    public ParticleSystem smokeEffect;
    public ParticleSystem fireEffect;


    void Awake()
    { 
        if (Instance != null)
        {
            Debug.LogError("Existem multiplas instancias do script SpecialEffect");
        }

        Instance = this;
    }

    public void Explosion(Vector3 position)
    {
        //position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.Log("position");
        Instantiate(smokeEffect, position);
        Debug.Log("to aqui");
        Instantiate(fireEffect, position);
    }

    private ParticleSystem Instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab, position, transform.rotation) as ParticleSystem;

        Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);

        return prefab;
    }
	
}
