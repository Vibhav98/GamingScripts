using UnityEngine;
using System.Collections;

public class endLevel : MonoBehaviour {
	
	public static bool isEndLevel = false;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			isEndLevel = true;
			setCheckpoint.checkpointEnabled = false;
			Debug.Log("endLevel: Player Hit End Level Trigger.");
		}
	}
}
