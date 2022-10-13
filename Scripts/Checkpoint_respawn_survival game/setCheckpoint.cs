using UnityEngine;
using System.Collections;

public class setCheckpoint : MonoBehaviour {

	public static bool checkpointEnabled = false;

	public static GameObject initSpawn;
	public static GameObject checkpoint;
	public static GameObject respawn;

	void Start ()
	{
		initSpawn = GameObject.FindWithTag("Spawn");
		checkpoint = GameObject.FindWithTag("Checkpoint");
		respawn = initSpawn;
	}

	void Update ()
	{
		if (checkpointEnabled)
		{
			respawn = checkpoint;
		}
		
		if (endLevel.isEndLevel)
		{
			respawn = initSpawn;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			checkpointEnabled = true;
			Debug.Log("setCheckpoint: Player Hit Checkpoint.");
		}
	}
}
