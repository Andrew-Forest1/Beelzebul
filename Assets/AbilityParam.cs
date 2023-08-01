using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbilityParam : MonoBehaviour
{
	public bool ready = true;
	public float manaCost = 0;
	public float cdTime = 10;
	public float damage = 10;
	public Sprite icon;
	public GameObject prefab;
	public float gameTimeAtActivation = 0;

    // Start is called before the first frame update
    void Start()
    {
		ready = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public abstract void Activate();

	public IEnumerator CoolDown()
	{
		ready = false;
		gameTimeAtActivation = Time.realtimeSinceStartup;
		yield return new WaitForSecondsRealtime(cdTime);
		ready = true;
	}
}
