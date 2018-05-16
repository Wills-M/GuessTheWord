using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TapWord : MonoBehaviour {

    //public Text scoreText;
   // private int score = 0;

    // Use this for initialization
    void Start()
    {

        //GameObject temp = GameObject.FindWithTag("scoreText");

        //if (temp != null)
        //    scoreText = temp.GetComponent<Text>();
        //else
        //    Debug.Log("Can't find scoreText??");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit = new RaycastHit();
                if (Physics.Raycast(ray, out hit, 1000.0f))
                {
                    if (hit.collider.gameObject == this.gameObject)
                    {
                        ScoreKeep.score += 10;
                        Destroy(Generator.blocks[Generator.words.IndexOf(gameObject)]);
                        Destroy(gameObject);

                    }
                }
            }
        }
        //Debug.Log("SCORE: " + scorekeep.getScore());
        
    }

    void OnMouseDown()
    {

        if (String.Equals(gameObject.GetComponent<TextMesh>().text, GameObject.FindWithTag("CurrentAnswer").GetComponent<Text>().text))
        {
            ScoreKeep.score += 10;
            Destroy(Generator.blocks[Generator.words.IndexOf(gameObject)]);
            Destroy(gameObject);
            InitDef.newDef();
        }

    }


}
