using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class InitDef : MonoBehaviour {

    public Text Def;
    public Text Ans;
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public static string[] defs, terms;
    private TextAsset f;
    public static int a;

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

        int t = UnityEngine.Random.Range(0, defs.Length);

        Def.text = defs[t];

        Ans.text = terms[t];
	}

    void Update()
    {
        Def.text = defs[a];
        Ans.text = terms[a];
    }

    public static void newDef()
    {
        int t = UnityEngine.Random.Range(0, defs.Length);

        a = t;
    }
}
