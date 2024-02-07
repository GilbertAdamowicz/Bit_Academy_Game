using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public float damage = 10f;
    public float firingRate = 15f;
    public float impactForce = 100f;
    public Camera FPSCam;
    private float nextTimetoFire = 0f;


    public float range = 100f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimetoFire)
        {
            nextTimetoFire = Time.time +1f / firingRate;
            Shoot();
        }

    }
    void Shoot()
    {
    RaycastHit hit;
    if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, range))
    {
        Debug.Log(hit.transform.name);
        
        // Apply impact force if there's a rigidbody
        if (hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(-hit.normal * impactForce);
        }
        
        // Correctly get the Target component from the hit object
        Target target = hit.transform.GetComponent<Target>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }
    }


}
