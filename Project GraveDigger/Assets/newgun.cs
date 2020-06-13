using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newgun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 10f;
    public float impactForce = 70f;
    public float fireRate = 15f;
    public int maxAmmo = 100;
    private int currentAmmo = -1;
    public float reloadTime = 1f;
    private float nextTimeToFire = 0f;
    private bool isReloading = true;

    public Camera fpsCam;

    public ParticleSystem muzzlFlash;
    public GameObject impactEffect;

    void Start()
    {
        if (currentAmmo == -1)
            currentAmmo = maxAmmo;
    }
    void Update()
    {
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }
    void Shoot()
    {

        muzzlFlash.Play();
        currentAmmo--;

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            targetscript target = hit.transform.GetComponent<targetscript>();
            if (target != null)
            {

                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime);

        currentAmmo = maxAmmo;
        isReloading = false;
    }
}