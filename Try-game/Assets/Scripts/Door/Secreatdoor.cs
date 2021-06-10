using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Secreatdoor : MonoBehaviour
{
	public float TheDistance;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	public GameObject cutter;
	public GameObject locker;
	bool isopened = false;
	public GameObject card;
	public GameObject about;
	public GameObject rope;
	public GameObject ghost;
	public GameObject dark;

	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}
	void OnTriggerEnter()
	{
		this.GetComponent<BoxCollider>().enabled = false;
		cutter.GetComponent<Animator>().enabled = true;
		StartCoroutine(Secreat());
		
	}

	IEnumerator Secreat()
	{
		yield return new WaitForSeconds(1f);
		locker.SetActive(false);
		yield return new WaitForSeconds(1f);
		cutter.GetComponent<Animator>().enabled = false;
		TheDoor.GetComponent<Animation>().Play("Door Open");
		CreakSound.Play();
		yield return new WaitForSeconds(10f);
		dark.SetActive(true);
		yield return new WaitForSeconds(1f);
		ghost.SetActive(false);
		rope.SetActive(false);
		dark.SetActive(false);
		about.GetComponent<Text>().text = "Find a keycard";
		yield return new WaitForSeconds(2f);
		about.GetComponent<Text>().text = "";
		card.SetActive(true);
	}
	
}
