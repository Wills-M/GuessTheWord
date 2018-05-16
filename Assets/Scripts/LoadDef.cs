using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadDef : MonoBehaviour {

    private Text Def;
    public Text DefField;

	// Use this for initialization
	void Start () {
        GameObject temp = GameObject.FindWithTag("CurrentDefinition");

        Def = temp.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        DefField.text = Def.text;
	}
}
