using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGamepadTest : MonoBehaviour
{
	
	public bool isButton;
	public string buttonName;

	[Space]

	public bool isJoystick;
	public string joystickPreface = "Right";

	[Space]

	public bool isBumper;
	public string bumperName = "BumpereR2";

	private Vector3 startPos;
	private Transform thisTransform;
	private MeshRenderer mr;

	
	// Use this for initialization
	void Start ()
	{
		thisTransform = transform;
		startPos = thisTransform.position;
		mr = thisTransform.GetComponent<MeshRenderer> ();	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isButton)
		{
			mr.enabled = Input.GetButton ( buttonName );
		}
		else if (isJoystick)
		{
			Vector3 inputDirection = Vector3.zero;
			inputDirection.x = Input.GetAxis ( joystickPreface + "JoystickHorizontal" );
			inputDirection.z = Input.GetAxis ( joystickPreface + "JoystickVertical" );
			thisTransform.position = startPos + inputDirection;

		}
		else if (isBumper)
		{
			if( Input.GetAxis ( bumperName ) != 0 )
				Debug.Log ( name + " : " + Input.GetAxis ( bumperName ) );
		}
	}
}
