using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTapToPlace : MonoBehaviour
{
	[SerializeField] private ARRaycastManager raycastManager;
	[SerializeField] private GameObject objectToPlace;

	List<ARRaycastHit> hitList = new List<ARRaycastHit>();

	void Update()
	{
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			if (raycastManager.Raycast(Mouse.current.position.ReadValue(), hitList, TrackableType.PlaneWithinPolygon))
			{
				Instantiate(objectToPlace, hitList[0].pose.position, hitList[0].pose.rotation);
			}
		}
	}
}
