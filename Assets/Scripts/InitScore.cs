using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InitScore : MonoBehaviour {
    public Text s;
	// Use this for initialization
	void Start () {
        s.text = ScoreKeep.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
