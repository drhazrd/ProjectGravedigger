using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Look1 : MonoBehaviour {
	
	
	public float LookSensativity;
	public float XRot;
	public float YRot;
		
	public bool Player;
	public bool P1;
	public bool P2;
	public bool P3;
	public bool P4;
	
	void Start () {
		
	}
	void Update (){
		if (P1){
			if (Player){
				XRot -= Input.GetAxis("MouseY_p1") * LookSensativity * Time.deltaTime;
			}
			YRot += Input.GetAxis("MouseX_p1") * LookSensativity * Time.deltaTime;
		}
		else if (P2){
			if (Player){
				XRot -= Input.GetAxis("MouseY_p2") * LookSensativity * Time.deltaTime;
			}
			YRot += Input.GetAxis("MouseX_p2") * LookSensativity * Time.deltaTime;
		}
		else if (P3){
			if (Player){
				XRot -= Input.GetAxis("MouseY_p3") * LookSensativity * Time.deltaTime;
			}
			YRot += Input.GetAxis("MouseX_p3") * LookSensativity * Time.deltaTime;
		}
		else if (P4){
			if (Player){
				XRot -= Input.GetAxis("MouseY_p4") * LookSensativity * Time.deltaTime;
			}
			YRot += Input.GetAxis("MouseX_p4") * LookSensativity * Time.deltaTime;
		}
		
		transform.rotation = Quaternion.Euler (XRot, YRot, 0);
	}
    private void RotateView()
    {
        //avoids the mouse looking if the game is effectively paused
        if (Mathf.Abs(Time.timeScale) < float.Epsilon) return;

        // get the rotation before it's changed
        float oldYRotation = transform.eulerAngles.y;

      /*  Player.mouseLook_p1.LookRotation(transform, cam_p1.transform);

        if (m_IsGrounded || advancedSettings.airControl)
        {
            // Rotate the rigidbody velocity to match the new direction that the character is looking
            Quaternion velRotation = Quaternion.AngleAxis(transform.eulerAngles.y - oldYRotation, Vector3.up);
            m_RigidBody_p1.velocity = velRotation * m_RigidBody_p1.velocity;
        }*/
    }
     public void Init(Transform character, Transform camera)
    {
       /* m_CharacterTargetRot = character.localRotation;
        m_CameraTargetRot = camera.localRotation;*/
    }
}
