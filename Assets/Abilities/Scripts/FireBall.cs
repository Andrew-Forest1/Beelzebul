using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
	public float speed = 10;
	public float range = 20;
	public float damage = 15;

    // Start is called before the first frame update
    void Start()
    {
		Destroy(transform.gameObject, range / speed);
	}

    // Update is called once per frame
    void Update()
    {
		transform.position += transform.right * speed * Time.deltaTime;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.layer == 10)
		{
			collision.gameObject.SendMessage("TakeDamage", damage);
		}
		
		Destroy(transform.gameObject);
		
	}
}
