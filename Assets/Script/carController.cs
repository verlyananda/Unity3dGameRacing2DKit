using UnityEngine;
using System.Collections;
//Verly Ananda Logic
//Catch me on verlyananda@gmail.com
public class carController : MonoBehaviour {
public float carSpeed;//speed belok
public float maxPos = 2.1f;//batas maximal posisition pada x
Vector3 position;
public uiManager ui;
public AudioManager am;
Rigidbody2D rb;
bool currntPlatformAndroid = false;
	// Use this for initialization
	void Awake(){
	rb = GetComponent<Rigidbody2D> ();

		#if UNITY_ANDROID
				currntPlatformAndroid = true;
		#else
				currentPlatformAndroid = false;
		#endif

	
	am.carSound.Play();
	}

	void Start () {
	//ui = GetComponent<uiManager> ();

	position = transform.position;
	if(currntPlatformAndroid == true){
		Debug.Log("Android");
	}else{
		Debug.Log("Windows");
	}
	}
	
	// Update is called once per frame
	void Update () {


		if (currntPlatformAndroid == true) {
			//android specific code
			//TouchMove ();
			
		}

		else {

			position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
			position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);

			transform.position = position;
		}

		position = transform.position;
		position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);
		transform.position = position;

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car"){
			Destroy (gameObject);
			ui.gameOverActivatated(); 
			am.carSound.Stop();

		}
	}


	//EVENT
	public void MoveLeft(){
		rb.velocity = new Vector2 (-carSpeed, 0);
	}
	
	public void MoveRight(){
		
		rb.velocity = new Vector2 (carSpeed, 0);
	}
	
	public void SetVelocityZero(){
		rb.velocity = Vector2.zero;
	}

}
