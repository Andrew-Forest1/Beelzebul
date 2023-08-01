using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOnHit : MonoBehaviour
{
	public float swordDamage = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Sword Hit");
		if(collision.gameObject)
		{
			//collision.gameObject.GetComponent<NPCHealthController>().TakeDamage();
			collision.gameObject.SendMessage("TakeDamage", swordDamage);
		}
	}
}
	