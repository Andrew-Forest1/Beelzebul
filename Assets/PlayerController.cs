using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool canMove = true;
	public bool canAttack = true;
	public bool canCast = true;

	DisableController disable;
	BuffController buff;
	KeyMovement movement;
	AttackController attack;

    // Start is called before the first frame update
    void Start()
    {
		disable = GetComponent<DisableController>();
		buff = GetComponent<BuffController>();
		movement = GetComponent<KeyMovement>();
		attack = GetComponent<AttackController>();
    }

    // Update is called once per frame
    void Update()
    {
		if (canMove)
		{
			movement.Move();
		}

		if (canAttack)
		{

		}

		if (canCast)
		{
			attack.Attack();
		}
    }
}
