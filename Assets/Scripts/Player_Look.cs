using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Look : MonoBehaviour {

	[SerializeField] private string mouseXinputName, mouseYInputName;
	[SerializeField] private float mouseSensitivity;

	[SerializeField] private Transform playerBody;

	private float xAxisClamp;

	private void Awake() {
		LockCursor();
		xAxisClamp = 0.0f;
	}

	private void LockCursor() {
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update () {
		CameraRotation();
	}

	private void CameraRotation() {
		float mouseX = Input.GetAxis(mouseXinputName) * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

		xAxisClamp += mouseY;

		if(xAxisClamp > 90.0f) {
			xAxisClamp = 90.0f;
			mouseY = 0.0f;
			ClampXAxisRotation(270.0f);
		}

		else if (xAxisClamp < -90.0f) {
			xAxisClamp = -90.0f;
			mouseY = 0.0f;
			ClampXAxisRotation(90.0f);
		}

		transform.Rotate(Vector3.left * mouseY);
		playerBody.Rotate(Vector3.up * mouseX);
	}

	private void ClampXAxisRotation(float value) {
		Vector3 eulerRotation = transform.eulerAngles;
		eulerRotation.x = value;
		transform.eulerAngles = eulerRotation;
	}
}
