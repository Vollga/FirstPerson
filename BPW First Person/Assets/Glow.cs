using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour {

	public GameObject target;
	public Material materialOff;
	public Material materialOn;
	Renderer rend;

	void Start()
	{
		rend = target.GetComponent<Renderer> ();
	}

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}

		if (collision.relativeVelocity.magnitude > 2) 
		{
			rend.material = materialOn;
		}

	}
}
