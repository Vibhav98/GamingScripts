using UnityEngine;
using System.Collections;

public class enemyPace : MonoBehaviour {

	public Vector3 pointB;
	public int paceDistance = 0;
	public int vertDirection = 0;
	public int horzDirection = 5;
	public int movementSpeed = 1;

	// Use this for initialization
	void Start () 
	{
		Vector3 pointA = transform.position;
		pointB.y = pointA.y + vertDirection;
		pointB.x = pointA.x + horzDirection;
		
		//while (true) 
		//{
			paceObject (transform, pointA, pointB, 3.0F);
			paceObject (transform, pointB, pointA, 3.0F);
		//}
	}
	
	void paceObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		float i = 0.0F;
		float rate = 1.0F/time;

		while (i < 1.0F)
		{
			i += Time.deltaTime * rate * movementSpeed;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			//yield;
		}
	}
}