using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {

    public Camera MainCam;
    public ShipMovement MovementHandler;
    public ShipProperties Ship;
    public GameObject CannonsRight;
    public GameObject CannonsLeft;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            MoveOnMouseClick();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    private void MoveOnMouseClick()
    {
        Ray ray = MainCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            MovementHandler.Destination = hit.point;
        }
    }

    private void FireCannon()
    {
        //if right side doubletapped...
        foreach (Transform child in CannonsRight.transform)
        {
            WeaponProjectile cannonballClone = Instantiate(Ship.ProjectileOfChoice, child.transform.position, transform.rotation);
            cannonballClone.Owner = Ship.NameOfShip;
            cannonballClone.GetComponent<Rigidbody>().velocity = child.transform.forward * cannonballClone.TravelSpeed;
        }
        
    }
}
