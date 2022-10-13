using UnityEngine;
using System.Collections;



public class carController : MonoBehaviour {
	public UImanager ui;

	public float carspeed;
	private float maxpos=1.42f;
	bool android=false;
	Vector2 position;
	Rigidbody2D rb;

	// Use this for initialization


	void Start () {
		rb=GetComponent<Rigidbody2D>();
		#if UNITY_ANDROID

		android=true;


		#else
		android=false;

		#endif
	//	ui = GetComponent<UImanager>();
		position = transform.position;
		if (android == true) {
			Debug.Log ("android");
		} else {
			Debug.Log ("window");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (android == true) {
			//touchmove ();
		//tilt();


		} else {
			position.x += Input.GetAxis ("Horizontal") * carspeed * Time.deltaTime;

			position.x = Mathf.Clamp (position.x, -1.42f, 1.42f);
			transform.position = position;
		}
		position = transform.position;
		position.x = Mathf.Clamp (position.x, -1.42f, 1.42f);
		transform.position = position;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "enemy car") {
			//Destroy (gameObject);
			gameObject.SetActive(false);
			ui.loose ();
	
		}
	}
	void touchmove()
	{
		if (Input.touchCount > 0) 
		{
			Touch touch = Input.GetTouch (0);
			float middle = Screen.width / 2;
			if (touch.position.x < middle && touch.phase == TouchPhase.Began) {
				moveLeft ();
			} else if (touch.position.x > middle && touch.phase == TouchPhase.Began) {
				moveRight ();
			} else {
				setvelocityZero ();
			}
		}
	}

	public void moveLeft()
	{
		rb.velocity=new Vector2(-carspeed,0);
		
	}
	public void moveRight()
	{
		rb.velocity=new Vector2(carspeed,0);

	}
	public void setvelocityZero()
	{
		rb.velocity=Vector2.zero;
			
	}

	void tilt()
	{
		float x = Input.acceleration.x;
		if (x < -0.1f) {
			moveLeft ();
		} else if (x > 0.1f) {
			moveRight ();
		} else {
			setvelocityZero ();
		}
		
	}
}
