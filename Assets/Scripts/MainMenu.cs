using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
		menu = transform.Find("Menu").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void NewGame()
	{
	 	SceneManager.LoadScene("Menu");
		//menu.SetActive(!menu.activeSelf);
	}

	public void Load()
	{
		Debug.Log("Load");
	}

	public void Classes()
	{
		Debug.Log("Classes");
	}

	public void Settings()
	{
		Debug.Log("Settings");
	}

	public void Exit()
	{
		Application.Quit();
	}
}
