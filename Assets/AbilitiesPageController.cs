using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesPageController : MonoBehaviour
{
	public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			BackToMenu();
		}
    }

	public void BackToMenu()
	{
		menu.SetActive(true);
		transform.gameObject.SetActive(false);
	}
}
