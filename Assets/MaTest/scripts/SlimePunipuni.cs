using UnityEngine;
using System.Collections;

public class SlimePunipuni : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.ScaleTo(gameObject, iTween.Hash(
			"x", 1.1f, 
			"y", 0.8f,
			"z", 1.1f,
			"time", 1.0f,
			"easeType", 
			"easeInOutExpo", 
			"loopType", 
			"pingPong"
			));
		//iTween.ScaleTo(gameObject, iTween.Hash("y", 1.5, "time", 1.0f, "looptype", iTween.LoopType.loop));
		//iTween.ScaleTo(gameObject, iTween.Hash("z", 1.5, "time", 1.0f, "looptype", iTween.LoopType.loop));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
