using UnityEngine;
using System.Collections;

/*	
 * Checks the players position agianst enabled boundries.
 * If the player is outside of the boundries they 
 * will be sent to the last checkpoint
 */

public class playerOutOfBounds : MonoBehaviour {

	public GameObject player;

	public bool X_boundEnabled = true;
	public bool Y_boundEnabled = true;
	public bool Z_boundEnabled = true;

	public int X_bound = 0;
	public int Y_bound = -10;
	public int Z_bound = 0;

	void Update () 
	{
		// Checks X bounds
		if (X_boundEnabled && player.transform.position.x <= X_bound)
		{
			player.transform.position = setCheckpoint.respawn.transform.position;
		}

		// Checks Y bounds
		if (Y_boundEnabled && player.transform.position.y <= Y_bound)
		{
			player.transform.position = setCheckpoint.respawn.transform.position;
		}

		// Checks Z bounds
		if (Z_boundEnabled && player.transform.position.z <= Z_bound)
		{
			player.transform.position = setCheckpoint.respawn.transform.position;
		}
	}
}
