using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{
	public GameObject[] abilities = new GameObject[0];
	public GameObject buttonPrefab;
		

	// Start is called before the first frame update
	void Start()
    {
        foreach(GameObject ability in abilities)
		{
			GameObject newButton = Instantiate(buttonPrefab, transform);
			newButton.transform.GetChild(0).GetComponent<Image>().sprite = ability.GetComponent<AbilityParam>().icon;
			newButton.transform.GetChild(1).GetComponent<Image>().sprite = ability.GetComponent<AbilityParam>().icon;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
