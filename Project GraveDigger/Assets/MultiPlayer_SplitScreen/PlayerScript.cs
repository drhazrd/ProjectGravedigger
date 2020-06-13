using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerScript : MonoBehaviour {

	public Camera cam;
    public Look1 mouseLook = new Look1();
    public GameObject[] Spawner;
	public GameObject[] Children;
	
	void Start () {
        mouseLook.Init(transform, cam.transform);
    }
	void Update (){
		
		cam.transform.position = new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z);
	}
	void Respawn()
	{
		int r = Random.Range (0,2);
		transform.position = Spawner[r].transform.position;
		print(this.name + "Respawn");
	}
	void OnDestroy()
	{
		Destroy (Children[0]);
	}

}
