using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAttack : MonoBehaviour
{
	public float attackSpeed = 1;
	bool attackOffCD = true;
	public float damage = 10;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public IEnumerator AttackCD()
	{
		attackOffCD = false;
		yield return new WaitForSecondsRealtime(1 / attackSpeed);
		attackOffCD = true;
	}

	public void Attack(GameObject target)
	{
		if (attackOffCD)
		{
			StartCoroutine(AttackCD());
			target.SendMessage("TakeDamage", damage);
		}
	}
}
