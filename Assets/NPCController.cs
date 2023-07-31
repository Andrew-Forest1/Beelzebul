using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
	public GameObject target;
	public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	private void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		if (target)
		{
			//Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.fixedDeltaTime);
			if(Vector3.Distance(transform.position, target.transform.position) > 1)
			{
				transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.fixedDeltaTime);
			}
		}
	}
}
