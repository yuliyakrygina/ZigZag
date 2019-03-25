using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	Rigidbody rb;
	public float speed; 

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Start()
	{

	}

	void Update()
	{
		float inputX = Input.GetAxis("Horizonal");
		float inputY = Input.GetAxis("Vertical");

    }
}
