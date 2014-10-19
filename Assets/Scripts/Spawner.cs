using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform prefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1"))
		{
			Vector3 offset = new Vector3 (Mathf.Sin (Time.time * 7), 0, 0);
			Instantiate (prefab, transform.position + offset, transform.rotation);
			Score.score--;
		}
	}
}
