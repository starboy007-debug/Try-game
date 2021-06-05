using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smbox : MonoBehaviour
{

	public GameObject about;
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	bool isactive = false;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			if(isactive == false)
			{
				ActionDisplay.SetActive(true);
				ActionText.SetActive(true);
			}
			
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				isactive = true;
				this.GetComponent<BoxCollider>().enabled = false;
				about.GetComponent<Text>().text = "Emergency light turned on";
				//	CreakSound.Play();
			}
			about.SetActive(true);
			StartCoroutine(Disappear());
		}
	}

	IEnumerator Disappear()
	{
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		about.SetActive(false);

	}

}
