using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorchedEarthParams : AbilityParam
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
		Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pos.z = 0;
		Instantiate(prefab, pos, transform.rotation);
		StartCoroutine(CoolDown());
	}
}
