﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        float force = 3;

        if(collision.gameObject.tag == "Ventilator")
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force);
        }
    }

}
