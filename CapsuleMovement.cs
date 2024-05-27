using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
	private CharacterController controller;
	public float moveSpeed = 5f; // Adjust the movement speed

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		// Get cursor input
		float horizontalInput = Input.GetAxis("Mouse X");
		float verticalInput = Input.GetAxis("Mouse Y");

		// Calculate movement direction
		Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= moveSpeed;

		// Apply movement to the capsule
		controller.Move(moveDirection * Time.deltaTime);
	}
}