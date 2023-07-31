using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{
	public GameObject[] abilities = new GameObject[0];
	AbilityParam[] abilitiesParams;
	public GameObject buttonPrefab;
	public GameObject HUD;
	PlayerController player;	

	// Start is called before the first frame update
	void Start()
    {
		//      foreach(GameObject ability in abilities)
		//{
		//	GameObject newButton = Instantiate(buttonPrefab, transform);
		//	newButton.transform.GetChild(0).GetComponent<Image>().sprite = ability.GetComponent<AbilityParam>().icon;
		//	newButton.transform.GetChild(1).GetComponent<Image>().sprite = ability.GetComponent<AbilityParam>().icon;
		//}
		abilitiesParams = new AbilityParam[abilities.Length];
		player = transform.GetComponent<PlayerController>();

		for(int i = 0; i < abilities.Length; i++)
		{
			HUD.transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = abilities[i].GetComponent<AbilityParam>().icon;
			HUD.transform.GetChild(i).GetComponent<ActionButtonController>().ability = abilities[i];
			HUD.transform.GetChild(i).GetComponent<ActionButtonController>().abilityParams = abilities[i].GetComponent<AbilityParam>();
			abilitiesParams[i] = abilities[i].transform.GetComponent<AbilityParam>();
		}
    }

    public void Cast()
    {
		
        if(Input.GetKeyDown(KeyCode.Alpha1) && abilitiesParams[0].ready)
		{
			abilitiesParams[0].Activate();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && abilitiesParams[1].ready)
		{
			abilitiesParams[1].Activate();
		}
	}
}
