using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameStrikeParams : AbilityParam
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public override void Activate()
	{
		Instantiate(prefab, transform.position, transform.rotation);
		StartCoroutine(CoolDown());
	}
}
