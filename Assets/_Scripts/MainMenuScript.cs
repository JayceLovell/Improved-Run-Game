﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//refernce to the UI namespace
using UnityEngine.UI;
/**
 * StudentID: 300833478
 * Date: 07/11/2016
 */
public class MainMenuScript : MonoBehaviour {
    private GameObject _gameManagerObject;
    private GameController _gamemanager;
    // PUBLIC INSTANCE VARIABLES
    public AudioSource MainMenuSound;

    [Header("Text")]
    public Text VersionLabel;

    [Header("Buttons")]
    public Button StartButton;
    public Button ExitButton;
    // Use this for initialization
    void Start () {
        VersionLabel.text = "Version: " + Application.version;
        Cursor.visible = true;
        this._gameManagerObject = GameObject.Find("Game Manager");
        this._gameManager = this._gameManagerObject.GetComponent<GameController>() as GameController;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    // PUBLIC METHODS
    public void Start_Game()
    {
        MainMenuSound.Stop();
        SceneManager.LoadScene("Main");
    }
    public void Close_Game()
    {
        Application.Quit();
    }
}
