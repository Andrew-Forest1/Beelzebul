using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		foreach(GameObject abilityButton in abilityButtons)
		{
			if(Vector3.Distance(Input.mousePosition, abilityButton.transform.position) < abilityButton.transform.GetComponent<RectTransform>().sizeDelta.x / 2)
			{
				Debug.Log(dropObject.name + "dropped on " + abilityButton.name);
				break;
			}
		}
		return false;
	}
}
