using UnityEngine;
using System.Collections;
//Verly Ananda Logic
//Catch me on verlyananda@gmail.com
public class trackMove : MonoBehaviour {
public float speed;
Vector2 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	offset= new Vector2(0,Time.time * speed);//gerakan kebawah vertical
	GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
