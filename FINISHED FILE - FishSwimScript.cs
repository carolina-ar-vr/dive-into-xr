using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FishSwimScript : MonoBehaviour
{
    // Public variables
    public float swimDistMax = 6f;
    public float minSwimSpeed = 0.3f;
    public float maxSwimSpeed = 1f;
	public Quaternion rotationOffset = Quaternion.Euler(new Vector3(270, 90, 0));
	public Transform swimRange;

    // Private variables
    private float currentSwimSpeed = 0f;
    private Vector3 currentStartPos = Vector3.zero;
    private Vector3 currentGoalPos = Vector3.zero;
    private bool animationPlaying = false;
    private float animationProgress = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Starting random direction swim & updating swim position
        if (!animationPlaying)
        {
            AttemptRandomSwim();
        } else
        {
			// Variables
			float distanceLeft = (currentGoalPos - transform.position).magnitude;
			float distanceToTravel = Mathf.Min(Time.deltaTime * currentSwimSpeed, distanceLeft);
			float totalDistance = (currentGoalPos - currentStartPos).magnitude;
			Vector3 direction = (currentGoalPos - currentStartPos).normalized;

			// Moving distance
			transform.position += direction * distanceToTravel;
            if (direction !=  Vector3.zero)
			{
				transform.rotation = Quaternion.LookRotation(direction) * rotationOffset;
			}

			// Adding to progress
			animationProgress = MathF.Min(animationProgress + distanceToTravel / totalDistance, 1f);
			if (animationProgress >= 1f)
			{
				animationPlaying = false;
			}
		}
	}

	// Checking if in box
	bool CheckInBox(Vector3 position)
	{
		// Variables
		Vector3 corner1 = swimRange.position - swimRange.localScale / 2;
		Vector3 corner2 = swimRange.position + swimRange.localScale / 2;

		// Checking axes
		bool xValid = position.x > corner1.x && position.x < corner2.x;
		bool yValid = position.y > corner1.y && position.y < corner2.y;
		bool zValid = position.z > corner1.z && position.z < corner2.z;

		// Returning result
		return xValid && yValid && zValid;
	}

	// Picking random location
	Vector3 PickRandomLocation()
    {
        // Variables
        Vector3 goalPos = transform.position;
        int maxAttempts = 50;
        int attempts = 0;

        while (goalPos == transform.position || !CheckInBox(goalPos))
		{
            attempts++;
			Vector3 randomPosAdd = new Vector3(UnityEngine.Random.Range(-swimDistMax, swimDistMax), UnityEngine.Random.Range(-swimDistMax, swimDistMax), UnityEngine.Random.Range(-swimDistMax, swimDistMax));
			goalPos += randomPosAdd;

            // Checking attempts
            if (attempts > maxAttempts)
            {
				goalPos = swimRange.position;
                break;
            }
		}

        // Returning
        return goalPos;
    }

    // Attempting swim
    void AttemptRandomSwim()
    {
        // Stopping if animation already playing
        if (animationPlaying)
        {
            return;
        }

        // Picking destination
        Vector3 randomPos = PickRandomLocation();
        currentStartPos = transform.position;
        currentGoalPos = randomPos;
        animationProgress = 0f;
		currentSwimSpeed = UnityEngine.Random.Range(minSwimSpeed, maxSwimSpeed);
		animationPlaying = true;
    }

}
