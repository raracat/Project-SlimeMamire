using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	//生成するオブジェクト
	public GameObject prefab;

	// クリックした位置座標
	private Vector3 clickPosition;

	void Update () {
		if (Input.GetButtonDown ("Fire1")){
			//クリックの場合
			clickPosition = Input.mousePosition;
			clickPosition.z = 10;

			//タッチの場合


			GameObject slime = Instantiate(prefab, Camera.main.ScreenToWorldPoint(clickPosition), Quaternion.identity) as GameObject;
			slime.rigidbody.velocity = new Vector3(0.0f,8.0f, 10.0f);

//			Instantiate (prefab, transform.position + offset, transform.rotation);
//			prefab.rigidbody.AddForce(0, 0, 10);

//			Score.score--;
		}
	}
}
