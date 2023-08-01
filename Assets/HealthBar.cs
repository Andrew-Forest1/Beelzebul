using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public float maxHealth = 100;
	public float health = 100;
	public Text healthText;
	public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//if (Input.GetKeyDown(KeyCode.UpArrow))
		//{
		//	if(health < maxHealth)
		//	{
		//		health += 10;
		//	}
		//}

		//else if (Input.GetKeyDown(KeyCode.DownArrow))
		//{
		//	if (health > 0)
		//	{
		//		health -= 10;
		//	}
		//}


    }

	public void UpDateHealth(float newHealth)
	{
		health = newHealth;
		healthSlider.value = health / maxHealth;
		healthText.text =  ((int)health).ToString() + " / " + ((int)maxHealth).ToString();
	}
}
