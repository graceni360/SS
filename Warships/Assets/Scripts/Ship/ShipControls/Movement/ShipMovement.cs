using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

    public ShipProperties Ship;
    public Vector3 Destination;
    public bool CanMove = true;
    public float atDestinationRange = 3f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (CanMove && !isAtDestination())
        {
            moveToDestination(Destination);
        }
    }

    private void turnToPoint(Vector3 destination)
    {
        //look at the destination... only want to change x and z.
        
        Vector3 directionToFace = destination - transform.position;
        directionToFace.y = 0;

        Quaternion rotation = Quaternion.LookRotation(directionToFace);

        //turns the object over time
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Ship.TurnSpeed * Time.deltaTime);
    }

    private void moveToDestination(Vector3 destination)
    {
        turnToPoint(destination);

        //move towards the destination
        transform.Translate(Vector3.forward * Time.deltaTime * Ship.MoveSpeed);
    }

    private bool isAtDestination()
    {
        return (Vector3.Distance(transform.position, Destination) < atDestinationRange);
    }
    
}
