using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppedOn : MonoBehaviour {

	public GameObject door;
	public GameObject[] lines;
	public Material colourOn;

	MeshRenderer drend;
	BoxCollider collision;
	MeshRenderer[] lrend;


	void Start () {
		drend = door.GetComponent <MeshRenderer> ();
		collision = door.GetComponent <BoxCollider> ();
		lrend = new MeshRenderer[lines.Length];
		for (int i = 0; i < lines.Length; i++) 
		{
			lrend[i] = lines[i].GetComponent <MeshRenderer> ();
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		drend.enabled = false;
		collision.enabled = false;
		for (int i = 0; i < lrend.Length; i++) 
		{
			lrend[i].material = colourOn;
		}
	}
}
