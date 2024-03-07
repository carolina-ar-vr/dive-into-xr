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
            // ADD CODE HERE

            // Moving distance
            // ADD CODE HERE

            // Adding to progress
            // ADD CODE HERE
        }
    }

	// Checking if in box
	bool CheckInBox(Vector3 position)
	{
        // Variables
        // ADD CODE HERE

        // Checking axes
        // ADD CODE HERE

        // Returning result
        // ADD CODE HERE
    }

    // Picking random location
        // ADD CODE HERE

        // Returning
            // ADD CODE HERE
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
