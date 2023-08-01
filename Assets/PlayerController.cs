using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool canMove = true;
	public bool canAttack = true;
	public bool canCast = true;
	public bool menuOpen = false;

	public float health = 100;
	public float mana = 100;
	public GameObject HealthBar;
	HealthBar healthBar;

	DisableController disable;
	BuffController buff;
	KeyMovement movement;
	AttackController attack;
	AbilityController abilities;

    // Start is called before the first frame update
    void Start()
    {
		canMove = true;
		canAttack = true;
		canCast = true;
		menuOpen = false;

		disable = GetComponent<DisableController>();
		buff = GetComponent<BuffController>();
		movement = GetComponent<KeyMovement>();
		attack = GetComponent<AttackController>();
		abilities = GetComponent<AbilityController>();

		healthBar = HealthBar.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
		if (menuOpen)
		{

		}
		else
		{
			if (canMove)
			{
				movement.Move();
			}

			if (canAttack)
			{
				attack.Attack();
			}

			if (canCast)
			{
				abilities.Cast();
			}
		}
    }

	public void TakeDamage(float damage)
	{
		health -= damage;
		healthBar.UpDateHealth(health);
	}
}
