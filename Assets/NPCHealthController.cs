using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCHealthController : MonoBehaviour
{
	public float maxHealth = 100;
	public float health = 100;
	public Text healthText;
	public Slider healthSlider;

	// Start is called before the first frame update
	void Start()
    {
		health = maxHealth;
		healthSlider = transform.Find("Canvas").Find("Health Bar").GetComponent<Slider>();
		healthText = healthSlider.GetComponentInChildren<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TakeDamage(float damage)
	{
		if(health - damage <= 0)
		{
			Destroy(transform.gameObject);
		}
		else
		{
			health -= damage;
		}
		healthSlider.value = (float) health / (float) maxHealth;
		healthText.text = ((int)health).ToString();
	}
}
