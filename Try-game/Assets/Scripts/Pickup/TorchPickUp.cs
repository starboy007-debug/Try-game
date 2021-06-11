using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorchPickUp : MonoBehaviour
{
    public GameObject torch1;
    public GameObject torch2;
	public GameObject about;
	public GameObject skeleton;
	public float TheDistance;
	public GameObject padcut;
	public GameObject skel;
	public GameObject emer;
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
				about.GetComponent<Text>().text = "You got a torch";
				//	CreakSound.Play();
			}
			about.SetActive(true);
			torch1.SetActive(false);
			torch2.SetActive(true);
			skeleton.SetActive(true);
			skel.GetComponent<BoxCollider>().enabled = true;
			StartCoroutine(Disappear());
		}
	}

	IEnumerator Disappear()
	{
		yield return new WaitForSeconds(2f);
		emer.SetActive(false);
		RenderSettings.ambientIntensity = 0.2f;
		about.GetComponent<Text>().text = "";
		about.SetActive(false);
		yield return new WaitForSeconds(12f);
		padcut.SetActive(true);

	}

}
