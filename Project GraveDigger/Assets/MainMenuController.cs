using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {


    public GameObject startMenu;
    public GameObject settingsMenu;
    public GameObject selectionMenu;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame() {
        startMenu.SetActive(false);
        selectionMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void GameSettingOpen() {
        startMenu.SetActive(false);
        selectionMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void GameSettingClose() {
        startMenu.SetActive(true);
        selectionMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
    public void PlayGame() {
        SceneManager.LoadScene("Orbit");
    }
}
