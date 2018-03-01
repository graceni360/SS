using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipProperties : MonoBehaviour {

    public float MaxHealth;

    public float Health;

    public float TurnSpeed;

    public float MoveSpeed;

    public int NumberOfCannonBalls;

    public string NameOfShip;

    public float BaseAttackPower;

    public WeaponProjectile ProjectileOfChoice;

    public GameObject HealthBarImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void tagChildren()
    {
    }

    private float calculatePercentageHealth()
    {
        return Health / MaxHealth;
    }

    public void ChangeHealth(float change)
    {
        if (Health + change > 0)
        {
            Health += change;
        }
        else
        {
            Health = 0;
        }

        updateHealthBar();
    }

    private void updateHealthBar()
    {
        HealthBarImage.transform.localScale = new Vector3(
            calculatePercentageHealth(),
            HealthBarImage.transform.localScale.y,
            HealthBarImage.transform.localScale.z);
    }
}
