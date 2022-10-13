using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {
	public GameObject[] cars;
	public float maxpos=1.42f;
	public float delaytimer=0.5f;
	float timer;
	int carno;
	// Use this for initialization
	void Start () {
		timer = delaytimer;	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carpos = new Vector3 (Random.Range (-1.42f, 1.42f), transform.position.y, transform.position.z);
			carno = Random.Range (0, 8);
			Instantiate (cars[carno], carpos, transform.rotation);
			timer = delaytimer;
		}
	}
}
