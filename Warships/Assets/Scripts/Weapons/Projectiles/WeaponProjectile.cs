using UnityEngine;

public class WeaponProjectile : MonoBehaviour
{
    public float Damage;

    public float TravelSpeed;

    public float timeTillCleanup;

    public string Owner;


    public void Start()
    {
        Destroy(gameObject, timeTillCleanup);

    }
    public void Update()
    {
        
    }

    private void OnHit()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(Constants.SHIP_LAYER_NAME))
        {
            ShipProperties ship = collision.gameObject.GetComponentInParent<ShipProperties>();
            if (ship != null && ship.NameOfShip != Owner)
            {
                ship.ChangeHealth(-Damage);
                Destroy(gameObject);

            }
        }

    }
}