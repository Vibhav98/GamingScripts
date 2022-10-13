using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UImanager : MonoBehaviour {
	public Text scoretext;
	int score;
	bool gameOver;
	public Button[] buttons;
	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);

	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "SCORE: " + score;
	}
	public void play()
	{
		Application.LoadLevel ("level 1");
	}
	public void pause ()
	{
		if (Time.timeScale==1)
		{
			Time.timeScale = 0;
		}
		else if (Time.timeScale==0)
		{
			Time.timeScale = 1;
		}
}
	public void quit()
	{
		Application.Quit ();
	}
	void scoreUpdate()
	{
		if(!gameOver)
		{
		score += 1;
	}
}
	public void loose()
	{
		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);
		}
	}


	public void menu()
	{
		Application.LoadLevel ("menu 2");
	}
}