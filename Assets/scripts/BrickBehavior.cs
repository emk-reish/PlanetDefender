using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehavior : MonoBehaviour {

	string brickID = "";

	public BrickBehavior(string id, float distance, double startAngle, double endAngle) {
		brickID = id;
		this.CreateBrickInGame(distance, startAngle, endAngle);
	}

	void CreateBrickInGame(float d, double a, double x) {
		Vector2[] vertices; 


		Mesh mesh = GetComponent<MeshFilter>().mesh;

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
