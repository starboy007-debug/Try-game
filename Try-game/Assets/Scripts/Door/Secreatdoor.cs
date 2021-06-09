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
		yield return new WaitForSeconds(11f);
		card.SetActive(true);
	}
	
}
