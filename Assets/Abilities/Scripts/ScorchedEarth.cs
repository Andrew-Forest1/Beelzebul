using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorchedEarth : MonoBehaviour
{
	float timer = 0;
	float damage = 10;

    // Start is called before the first frame update
    void Start()
    {
		timer = Time.realtimeSinceStartup;
		Destroy(transform.gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup - timer < 1)
		{
			transform.localScale += new Vector3(3 * Time.deltaTime, 3 * Time.deltaTime, 0);
		}

		Burn();
    }

	void Burn()
	{
		// Define the direction in which to cast the circle (e.g., forward)
		Vector2 direction = transform.right; // Assuming your object is facing right

		float radius = transform.localScale.x / 2;

		// Perform the circle cast
		RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, radius, direction);

		foreach(RaycastHit2D hit in hits)
		{
			// Check if the circle cast hit something
			if (hit.collider.gameObject.layer == 10)
			{
				// Do something with the detected object
				hit.collider.gameObject.SendMessage("TakeDamage", damage * Time.deltaTime);
			}
		}
	}
}
