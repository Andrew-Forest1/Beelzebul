using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorchedEarth : MonoBehaviour
{
	float timer = 0;

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
    }
}
