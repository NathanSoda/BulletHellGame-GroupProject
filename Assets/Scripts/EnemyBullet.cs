using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
	public GameObject Shot;
	public Transform BulletSpawn;
	public float fireRate;

	private float nextFire;

	void Update()
    {
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Shot, BulletSpawn.position, BulletSpawn.rotation);
		}
	}
}
