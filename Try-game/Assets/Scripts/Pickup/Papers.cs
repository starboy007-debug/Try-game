using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Papers : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject Paper;
	public GameObject about;
	public GameObject box;
//	public AudioSource CreakSound;

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
			if (TheDistance <= 3)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Paper.SetActive(true);
			//	CreakSound.Play();
			}
			Paper.SetActive(true);
			StartCoroutine(Disappear());
		}
	}

    IEnumerator Disappear()
	{
		yield return new WaitForSeconds(2f);
		Paper.SetActive(false);
		yield return new WaitForSeconds(1f);
		about.SetActive(true);
		RenderSettings.ambientIntensity = 0.2f;
		yield return new WaitForSeconds(1f);
		about.GetComponent<Text>().text = "Turn on the emergency light";
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		box.GetComponent<BoxCollider>().enabled = true;
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
		
		//Paper.SetActive(false);
		//this.GetComponent<BoxCollider>().enabled = true;
	}
}
