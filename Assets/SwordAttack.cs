using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
	public float swingSpeed = 10;
	Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
		rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		rb.velocity = transform.up * swingSpeed;
    }
}
