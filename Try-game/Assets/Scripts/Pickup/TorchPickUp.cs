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
				about.GetComponent<Text>().text = "You got a torch";
				//	CreakSound.Play();
			}
			about.SetActive(true);
			torch1.SetActive(false);
			torch2.SetActive(true);
			skeleton.SetActive(true);
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
