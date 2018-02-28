using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : WeaponProjectile {
    private float timeOfCreation;

    private void Start()
    {
        timeOfCreation = Time.time;
    }
    private void Update()
    {
        if (timeOfCreation + secondsTillCleanup < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
