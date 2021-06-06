using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutter : MonoBehaviour
{
	public GameObject cutter;
	public GameObject about;
	public float TheDistance;
	public static bool iscut = false;
	public GameObject secreatdoor;

	void Start()
	{
		secreatdoor.GetComponent<BoxCollider>().enabled = false;
	}
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{

		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				iscut = true;
				about.GetComponent<Text>().text = "You got a cutter";
				//	CreakSound.Play();
			}
			about.SetActive(true);
			cutter.SetActive(false);
			StartCoroutine(Disappear());
			secreatdoor.GetComponent<BoxCollider>().enabled = true;
		}
	}

	IEnumerator Disappear()
	{
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		about.SetActive(false);

	}
}
