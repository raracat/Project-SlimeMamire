using UnityEngine;
using System.Collections;

public class ScoreCircle : MonoBehaviour {

	private void Start()
	{
		iTween.MoveTo(gameObject, iTween.Hash(
			"x", 0.8f,
			"easeType", "easeInOutQuad", 
			"looptype","pingPong",
			"time", 3
			));
	}

	void OnCollisionEnter (Collision collider)
	{

		Destroy (collider.gameObject, 0.5f);
		Score.score += 3;
	}
}
