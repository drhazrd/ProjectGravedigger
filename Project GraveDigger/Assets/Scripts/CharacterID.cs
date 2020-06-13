using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterID : MonoBehaviour {

    public bool Player1, Player2;
    public string PlayerNum = null;
    string AxisX = "Horizontal";
    string AxisY = "Vertical";
    string LookAxisX = "MouseX";
    string LookAxisY = "MouseY";


    // Use this for initialization
    void Start()
    {
        if (Player1 == true && Player2 == false)
        {
            PlayerNum = "_p1";
        }
        else if (Player2 == true && Player1 == false)
        {
            PlayerNum = "_p2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
