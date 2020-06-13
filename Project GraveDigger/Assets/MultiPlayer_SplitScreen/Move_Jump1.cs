using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move_Jump1 : MonoBehaviour {
	
	public float Speed;
	public float JumpHeight;
	public bool P1;
	public bool P2;
	public bool P3;
	public bool P4;
	public bool OnGround;
	
	void Start () {
		
	}
	void Update (){
		if (P1)
		{
			float h = Input.GetAxis("Horizontal_p1");
			transform.Translate (Speed * h * Time.deltaTime, 0, 0);
			
			float v = Input.GetAxis("Vertical_p1");
			transform.Translate (0, 0, Speed * v * Time.deltaTime);
		}
		if (P2)
		{
			float h = Input.GetAxis("Horizontal_p2");
			transform.Translate (Speed * h * Time.deltaTime, 0, 0);
			
			float v = Input.GetAxis("Vertical_p2");
			transform.Translate (0, 0, Speed * v * Time.deltaTime);
		}
		if (P3)
		{
			float h = Input.GetAxis("Horizontal_p3");
			transform.Translate (Speed * h * Time.deltaTime, 0, 0);
			
			float v = Input.GetAxis("Vertical_p3");
			transform.Translate (0, 0, Speed * v * Time.deltaTime);
		}
		if (P4)
		{
			float h = Input.GetAxis("Horizontal_p4");
			transform.Translate (Speed * h * Time.deltaTime, 0, 0);
			
			float v = Input.GetAxis("Vertical_p4");
			transform.Translate (0, 0, Speed * v * Time.deltaTime);
		}
		
		if (Input.GetButton("Jump_p1") & P1)
		{
			if (OnGround)
			{
				transform.Translate(0, JumpHeight * Time.deltaTime, 0);
			}
		}
		
		if (Input.GetButton("Jump_p2") & P2)
		{
			if (OnGround)
			{
				transform.Translate(0, JumpHeight * Time.deltaTime, 0);
			}
		}
		
		if (Input.GetButton("Jump_p3") & P3)
		{
			if (OnGround)
			{
				transform.Translate(0, JumpHeight * Time.deltaTime, 0);
			}
		}
		
		if (Input.GetButton("Jump_p4") & P4)
		{
			if (OnGround)
			{
				transform.Translate(0, JumpHeight * Time.deltaTime, 0);
			}
		}

	}
	void OnCollisionStay(Collision col){
		if (col.gameObject.CompareTag("Ground")){
			OnGround = true;
		}
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.CompareTag("Ground")){
			OnGround = false;
		}
	}
}
