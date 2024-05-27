using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target; // Reference to the capsule (player)
	public Vector3 offset = new Vector3(0f, 1f, -5f); // Adjust the camera position relative to the capsule

	private void Update()
	{
		// Calculate the desired camera position
		Vector3 desiredPosition = target.position + offset;

		// Smoothly move the camera towards the desired position
		transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);
	}
}