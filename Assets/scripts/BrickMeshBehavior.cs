using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMeshBehavior : MonoBehaviour {

	[Range(1,10)]
	public int maxLevel = 3;

	[Range(10, 40)]
	public int numBricks = 20;

	public float baseRadius = 2.7f;
	public float ringDepth = .5f;

	private int level = 1;

	private double angle;

	// Use this for initialization
	void Start () {
		angle = 2 * Math.PI / numBricks;

		if(level <= maxLevel) {
			for(int i = 0; i < level; i++) {
				this.MakeRing(i);
			}
		} else {
			// end game
		}
	}

	void MakeRing(int ringCount) {
		float radius = baseRadius + ringDepth * level;
		for(int n = 0; n < numBricks; n++) {
			double start = angle * n;
			string id = ringCount + "." + n;
			BrickBehavior brick = new BrickBehavior(id, radius, start, start + angle);
		}
	}
}
