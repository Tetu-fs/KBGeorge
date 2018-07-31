using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IkuseiAction : MonoBehaviour {

	public GameObject turnTextSceneObject;
	public GameObject kingyoObject;
	private Text turnTextObject;
	private int turnNumber = 4;

	// Use this for initialization
	void Start () {
		turnTextObject = turnTextSceneObject.GetComponent<Text> ();
		turnNumber = 4;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EsaButtonClick() {
		kingyoObject.transform.localScale = new Vector3(
			kingyoObject.transform.localScale.x + 0.015f,
			kingyoObject.transform.localScale.y + 0.015f,
			kingyoObject.transform.localScale.z);
		TurnSusumuyo();
	}
	public void KaimonoButtonClick() {
		kingyoObject.transform.localScale = new Vector3(
			kingyoObject.transform.localScale.x - 0.015f,
			kingyoObject.transform.localScale.y - 0.015f,
			kingyoObject.transform.localScale.z);
		TurnSusumuyo();
	}

	public void TurnSusumuyo() {
		turnNumber--;
		if (turnNumber <= 0) {
			// 結果シーンへ移動する
			SceneManager.LoadScene ("Result");
		}
		turnTextObject.text = turnNumber.ToString() + "ターン";
	}
}
