using UnityEngine;
using System.Collections;

public class ItemDestroy: MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");

		//Unityちゃんと壁の位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんの位置に合わせて壁の位置を移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
	
	}

	//トリガーモードでオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider a) {

		if (a.gameObject.tag == "CarTag" || a.gameObject.tag == "TrafficConeTag" || a.gameObject.tag == "CoinTag") {

			//接触したオブジェクトを削除する
			Destroy (a.gameObject);

			Debug.Log ("destroy");
		}
	}
}
