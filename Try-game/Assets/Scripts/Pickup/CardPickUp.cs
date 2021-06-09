using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPickUp : MonoBehaviour
{
    public GameObject card;
    public GameObject about;
    public float TheDistance;
	public static bool isout = false;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 4)
		{
			
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 4)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				about.GetComponent<Text>().text = "You got a keycard";
				isout = true;
				//	CreakSound.Play();
			}
			about.SetActive(true);
			card.SetActive(false);
			StartCoroutine(Disappear());
		}
	}

	IEnumerator Disappear()
	{
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "I think I can get out of here";
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		about.SetActive(false);
		
	}

}
