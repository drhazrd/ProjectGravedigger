using UnityEngine;

public class doortrigger : MonoBehaviour {
    public Animator anim;
    public bool Enter;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

		
	}
	
	// Update is called once per frame
    void OnTriggerEnter (Collider col) {
        if (Enter != true){
            anim.Play("door");
            Debug.Log("Opened door");
        }

    }
}
