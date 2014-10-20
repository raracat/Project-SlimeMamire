using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score;

	void Awake ()
	{
		score = 100;
	}

		
	// Update is called once per frame
	void Update () {
		guiText.text = score.ToString ();
	}
}
