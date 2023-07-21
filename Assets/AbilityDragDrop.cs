using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDragDrop : MonoBehaviour
{
	private Transform dragIcon;
	private bool isDragging = false;
	private Vector3 offset;
	private ActionBarController actionBarController;

	private void Start()
	{
		dragIcon = transform.GetChild(0);
		actionBarController = GameObject.Find("Action Bar").GetComponent<ActionBarController>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if(Vector3.Distance(GetMouseWorldPosition(), transform.position) < transform.GetComponent<RectTransform>().sizeDelta.x / 2)
			{
				OnMouseDown();
			}
		}

		if (Input.GetMouseButton(0))
		{
			OnMouseDrag();
		}

		if (Input.GetMouseButtonUp(0))
		{
			OnMouseUp();
		}
	}

	public void OnMouseDown()
	{
		// Calculate the offset between the mouse position and the object's position
		offset = dragIcon.position - GetMouseWorldPosition();

		// Set the dragging flag to true
		isDragging = true;
		//else if(Input.GetMouseButtonDown(1))
		//{
		//	Debug.Log("Display " + transform.name + "discription");
		//}
	}

	private void OnMouseDrag()
	{
		// If the object is being dragged, update its position based on the mouse position
		if (isDragging)
		{
			dragIcon.position = GetMouseWorldPosition() + offset;
		}
	}

	private void OnMouseUp()
	{
		// Set the dragging flag to false
		isDragging = false;
		dragIcon.position = transform.position;
		actionBarController.OnDropIcon(transform.gameObject);
	}

	private Vector3 GetMouseWorldPosition()
	{
		// Get the position of the mouse cursor in world coordinates
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = Camera.main.nearClipPlane;

		return mousePos;
	}

	public void OnClick()
	{
		Debug.Log("Display Discription");
	}
}
