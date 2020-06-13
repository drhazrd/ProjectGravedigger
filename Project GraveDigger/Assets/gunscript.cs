using UnityEngine;

public class gunscript : MonoBehaviour {
    public float damage;
    public float range;
    public Camera fpscam;


    // Use this for initialization
	
	// Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1")) { Shoot(); }
    }void Shoot (){
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit,range)){
            Debug.Log(hit.transform.name);
            targetscript target = hit.transform.GetComponent<targetscript>();
            if (target != null){
                target.TakeDamage(damage);
            }
        }
    }
}
