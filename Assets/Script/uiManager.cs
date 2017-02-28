using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class uiManager : MonoBehaviour {
public Button[] buttons;
public Text scoreText;
int score;	
bool gameOver;
	// Use this for initialization
	void Start () {
	gameOver = false;
	   score = 0;
	   InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	scoreText.text = "Score : " + score;
	}

	void scoreUpdate(){
		if(gameOver == false){
			score += 1;
		}
		}

	public void gameOverActivatated(){
		gameOver = true;
		foreach(Button button in buttons){
			button.gameObject.SetActive(true); //jika game over panggil tombol
		}
	}

	public void Play(){
		Application.LoadLevel("level1");
	}

	public void Pause(){
		if (Time.timeScale == 1){
			Time.timeScale = 0;
			
		}
		else if (Time.timeScale == 0){
			Time.timeScale = 1;
			
		}
	}


  public void Replay(){
  Application.LoadLevel("level1");
  }

  public void Menu(){
 	Application.LoadLevel("mainMenu");
  }

  public void Exit(){
  	Application.Quit();
  }
}
