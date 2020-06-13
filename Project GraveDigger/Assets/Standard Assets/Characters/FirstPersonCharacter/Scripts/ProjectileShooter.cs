using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {
    private AudioSource mAudioSrc;
    GameObject Prefab;
	void Start () {
        Prefab = Resources.Load("projectile") as GameObject;

        mAudioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            mAudioSrc.Play();
            GameObject projectile = Instantiate(Prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 100;
            
        }

	}
}
