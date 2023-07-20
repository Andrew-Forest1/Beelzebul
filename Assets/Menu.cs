using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject menu;
	public GameObject abilitiesPage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			menu.SetActive(!menu.activeSelf);
		}
    }

	public void Resume()
	{
		menu.SetActive(!menu.activeSelf);
	}

	public void Character()
	{
		Debug.Log("Character");
	}

	public void Attributes()
	{
		abilitiesPage.SetActive(true);
		menu.SetActive(false);
	}

	public void Abilities()
	{
		abilitiesPage.SetActive(true);
		menu.SetActive(false);
	}

	public void Settings()
	{
		Debug.Log("Settings");
	}

	public void Exit()
	{
		Debug.Log("Exit");
	}
}
