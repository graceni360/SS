using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSomething : MonoBehaviour {

    public WeaponProjectile Projectile;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    public void FireCannon()
    {
         WeaponProjectile cannonballClone = (WeaponProjectile)Instantiate(Projectile, transform.position, transform.rotation);
         cannonballClone.GetComponent<Rigidbody>().velocity = transform.forward * cannonballClone.TravelSpeed;
    }
}
