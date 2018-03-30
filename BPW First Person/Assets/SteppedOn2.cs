using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppedOn2 : MonoBehaviour {

	public GameObject[] Trapdoors;
	public GameObject[] lines;
	public Material colourOn;

	Rigidbody[] rigid;
	MeshRenderer[] lrend;


	void Start () {
		rigid = new Rigidbody[Trapdoors.Length];
		for (int i = 0; i < Trapdoors.Length; i++)
		{
			rigid[i] = Trapdoors [i].GetComponent <Rigidbody> ();
		}
		lrend = new MeshRenderer[lines.Length];
		for (int i = 0; i < lines.Length; i++) 
		{
			lrend[i] = lines[i].GetComponent <MeshRenderer> ();
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		for (int i = 0; i < rigid.Length; i++)
		{
			rigid [i].freezeRotation = false;
		}
		for (int i = 0; i < lrend.Length; i++) 
		{
			lrend[i].material = colourOn;
		}
	}
}
