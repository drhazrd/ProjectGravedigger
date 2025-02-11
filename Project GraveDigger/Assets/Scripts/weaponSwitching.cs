using UnityEngine;

public class weaponSwitching : MonoBehaviour {


    public int selectedWeapon;
	// Use this for initialization
	void Start () {
        SelectWeapon();
		
	}
	
	// Update is called once per frame
	void Update () {

        int previousSelectedWeapon = selectedWeapon;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f || Input.GetButtonDown("Mouse ScrollWheel"))
        {
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f || Input.GetButtonDown("Mouse ScrollWheel"))
        {
            if (selectedWeapon <= 0f)
                selectedWeapon = transform.childCount-1;
            else
                selectedWeapon--;

        }
        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }

    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
