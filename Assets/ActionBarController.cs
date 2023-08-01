using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBarController : MonoBehaviour
{
	public GameObject[] abilityButtons;

    // Start is called before the first frame update
    void Start()
    {
		// Create a list to store all the children
		System.Collections.Generic.List<GameObject> children = new System.Collections.Generic.List<GameObject>();

		// Loop through each child of the parent
		foreach (Transform child in transform)
		{
			// Add the current child to the list
			children.Add(child.gameObject);
		}

		// Convert the list to an array and return it
		abilityButtons = children.ToArray();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public bool OnDropIcon(GameObject dropObject)
	{
		int index = 0;
		foreach(GameObject abilityButton in abilityButtons)
		{
			if(Vector3.Distance(Input.mousePosition, abilityButton.transform.position) < abilityButton.transform.GetComponent<RectTransform>().sizeDelta.x / 2)
			{
				ActionButtonController controller = abilityButton.GetComponent<ActionButtonController>();
				controller.setAbility(dropObject);
				abilityButton.transform.Find("Icon").GetComponent<Image>().sprite = controller.abilityParams.icon;
				GameObject.Find("Player").GetComponent<AbilityController>().AddAbility(dropObject, index);
				//Debug.Log(dropObject.name + "dropped on " + abilityButton.name);
				//ActionButtonController abController = abilityButton.GetComponent<ActionButtonController>();
				//abController.ability = dropObject.GetComponent<AbilityDragDrop>().ability;
				//abilityButton.GetComponent<ActionButtonController>().setAbility(abController.ability);
				break;
			}
			index += 1;
		}
		return false;
	}
}
