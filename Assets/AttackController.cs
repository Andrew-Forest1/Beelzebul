using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
	public float attackSpeed = 1;
	bool attackOffCD = true;

    // Start is called before the first frame update
    void Start()
    {
		attackOffCD = true;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Attack()
	{
		if (attackOffCD)
		{
			if (Input.GetMouseButton(0))
			{
				Debug.Log("Attack 1");
				StartCoroutine(AttackCD());
			}

			else if (Input.GetMouseButton(1))
			{
				Debug.Log("Attack 2");
				StartCoroutine(AttackCD());
			}
		}
	}

	public IEnumerator AttackCD()
	{
		attackOffCD = false;
		yield return new WaitForSecondsRealtime(1 / attackSpeed);
		attackOffCD = true;
	}
}
