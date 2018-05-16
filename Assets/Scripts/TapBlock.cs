using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class TapBlock : MonoBehaviour {
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public string[] terms, defs;
    public TextAsset f;

	// Use this for initialization
	void Start () {
        //loads dictionary
        string holder, term = "", def;
        f = Resources.Load("dictionary") as TextAsset;

        if (f == null)
            Debug.Log("CAn'T FIND MY DICT");
        

        StringReader input = new StringReader(f.text);

        do
        {
            holder = input.ReadLine();

            if (holder != null)
                term = holder;

            holder = input.ReadLine();

            if (holder != null)
            {
                def = holder;
                dict.Add(term, def);
            }


        } while (holder != null);

        terms = new string[dict.Count];
        defs = new string[dict.Count];

        int i = 0;

        foreach (KeyValuePair<string, string> k in dict)
        {
            terms[i] = k.Key;
            defs[i] = k.Value;
            i++;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit != null && hit.transform.gameObject == this.gameObject)// && hit.collider != null) 
            {
                //Destroy(gameObject);
            }

        }
	}

    void OnMouseDown()
    {
        //Destroy(gameObject);
    }
}
