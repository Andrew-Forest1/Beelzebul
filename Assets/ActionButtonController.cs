using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButtonController : MonoBehaviour
{
	public Slider cooldownShader;
	public GameObject ability;
	public AbilityParam abilityParams;

    // Start is called before the first frame update
    void Start()
    {
		//abilityParams = ability.GetComponent<AbilityParam>();
    }

    // Update is called once per frame
    void Update()
    {
		if (ability)
		{
			if (!abilityParams.ready)
			{
				cooldownShader.value = (abilityParams.cdTime - Time.realtimeSinceStartup + abilityParams.gameTimeAtActivation) / abilityParams.cdTime;
			}
			else
			{
				cooldownShader.value = 0;
			}
		}
    }

	public void setAbility(GameObject newAbility)
	{
		ability = newAbility;
		abilityParams = newAbility.GetComponent<AbilityParam>();
	}
}
