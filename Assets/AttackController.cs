using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
	public float attackSpeed = 1;
	bool attackOffCD = true;
	public Animator anime;
	public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
		attackOffCD = true;
		anime = transform.GetComponent<Animator>();
		player = transform.GetComponent<PlayerController>();
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
				anime.SetInteger("Attack", 2);
				StartCoroutine(AttackCD());
				player.canMove = false;
			}

			else if (Input.GetMouseButton(1))
			{
				anime.SetInteger("Attack", 1);
				StartCoroutine(AttackCD());
				player.canMove = false;
			}
		}
	}

	public IEnumerator AttackCD()
	{
		attackOffCD = false;
		yield return new WaitForSecondsRealtime(1 / attackSpeed);
		attackOffCD = true;
	}

	public void AttackEnd()
	{
		anime.SetInteger("Attack", 0);
		player.canMove = true;
	}
}
