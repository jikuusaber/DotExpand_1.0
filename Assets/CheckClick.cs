using UnityEngine;
using System.Collections;

public class CheckClick : MonoBehaviour {

	//private Animator expand;

	// Use this for initialization
	void Start () {
		Debug.Log ("GameObject initialized");
		//expand = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		animation ["Expand"].wrapMode = WrapMode.PingPong;
		animation.Play ("Expand");
		Debug.Log ("MouseClick detected");
	}
}
