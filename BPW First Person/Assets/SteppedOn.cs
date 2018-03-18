using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppedOn : MonoBehaviour {

	public GameObject target;
	MeshRenderer renderer;
	BoxCollider collision;

	void Start () {
	//	renderer = target.GetComponent (MeshRenderer);
	//	BoxCollider = target.GetComponent (BoxCollider);
	}
	
	void OnCollisionEnter(Collider other)
	{
		Destroy (target);
	}
}
