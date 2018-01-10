using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavior : MonoBehaviour {

	[Range(1f, 10f)]
	public float speed = 1f;

	private Vector2 direction;
	private Vector2 position;

	// Use this for initialization
	void Start () {
		direction = new Vector2(0,-1);
		position = new Vector2(0,1);
		transform.position = position;
	}
	
	// Update is called once per frame
	void Update () {
		float d = direction.magnitude;
		if(d != 0 && speed != 0) { // Otherwise the object is not moving
			float scalar = speed / d;
			transform.Translate(direction * Time.deltaTime * scalar);
		}
		// Debug.Log(direction);
		// Debug.Log(d + " , " + speed);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject other = collider.gameObject;
		switch(other.name) {
			case "Planet":
				Debug.Log("hit planet");
				speed = 0;
				other.GetComponent<PlanetBehavior>().Explode();
				break;
			case "Player":
				Debug.Log("hit player");
				direction = -direction; // not working :(
				break;
			default:
				break;
		}
	}
}
