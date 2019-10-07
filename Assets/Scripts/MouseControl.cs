using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary1
{
    public float xMin, xMax, zMin, zMax;
}

public class MouseControl : MonoBehaviour
{
    public float speed;
    public Boundary1 boundary;

	public GameObject bullet;
	public Transform BulletSpawn;
	public float fireRate = 0.5F;

	private float nextFire = 0.5F;
	private float myTime = 0.0F;

    void Update()
    {
		myTime = myTime + Time.deltaTime;

		if (Input.GetButton("Jump") && myTime > nextFire)
		{
			nextFire = myTime + fireRate;
			Instantiate(bullet, BulletSpawn.position, BulletSpawn.rotation);

			// create code here that animates the newProjectile

			nextFire = nextFire - myTime;
			myTime = 0.0F;
		}
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = movement * speed;


        rigidbody.position = new Vector3
            (
                Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp (rigidbody.position.z,boundary.zMin, boundary.zMax)
            );
    }

}
