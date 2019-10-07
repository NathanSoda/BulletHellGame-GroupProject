using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
	public Transform[] Waypoints;
	public float speed;
	public int currWaypoint;
	public bool Patrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;

	void Update()
	{
		if (currWaypoint < Waypoints.Length)
		{
			Target = Waypoints[currWaypoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;

			if (MoveDirection.magnitude < 1)
			{
				currWaypoint++;
			}
			else
			{
				Velocity = MoveDirection.normalized * speed;
			}
		}
		else
		{
			if (Patrol)
			{
				currWaypoint = 0;
			}
			else
			{
				Velocity = Vector3.zero;
			}
		}
		GetComponent<Rigidbody>().velocity = Velocity;
		{
			transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

		}
    }
}
