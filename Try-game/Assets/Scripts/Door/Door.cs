using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	bool isopened = false;

	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			
			if (TheDistance <= 3 && isopened == false)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				TheDoor.GetComponent<Animation>().Play("Door Open");
				CreakSound.Play();
				isopened = true;
			}
			
		}
		if (Input.GetButtonDown("Close"))
		{
			if (TheDistance <= 3 && isopened == true)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				//ActionDisplay.SetActive(false);
				//ActionText.SetActive(false);
				TheDoor.GetComponent<Animation>().Play("Door close");
				CreakSound.Play();
				isopened = false;
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	//	this.GetComponent<BoxCollider>().enabled = true;
	}
}
