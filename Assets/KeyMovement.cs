using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour
{
	public float speed = 5;
	public Animator anime;
    // Start is called before the first frame update

    void Start()
    {
		anime = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
  //  void Update()
  //  {
		////Vector2 lookpos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		////float angle = Vector2.Angle(transform.position, lookpos);
		////transform.rotation = Quaternion.Euler(Vector3.forward * angle);

		//Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

		//// Calculate the direction from the object's position to the mouse position
		//Vector3 direction = mousePos - transform.position;

		//// Calculate the angle between the object's forward direction and the direction to the mouse
		//float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

		//// Rotate the object to face the mouse position
		//transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		//if (Input.GetKey(KeyCode.W))
		//{
		//	transform.Translate(Vector2.right * speed * Time.deltaTime);
		//}
  //  }

	public void Move()
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

		// Calculate the direction from the object's position to the mouse position
		Vector3 direction = mousePos - transform.position;

		// Calculate the angle between the object's forward direction and the direction to the mouse
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

		// Rotate the object to face the mouse position
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
		{
			anime.SetBool("Moving", true);
		}
		else if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
		{
			anime.SetBool("Moving", false);
		}
		

		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.left * speed * Time.deltaTime * .5f);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime * .85f);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime * .85f);
		}
	}
}
