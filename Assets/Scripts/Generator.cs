using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Generator : MonoBehaviour {
    public GameObject TextBlock;                
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public Transform[] textSpawn;
    public GameObject block;
    public GameObject wordTemplate;
    public TextAsset f;

    public static GameObject[] blocks = new GameObject[300];
    public static ArrayList words = new ArrayList();
    int count = 0;

    public ArrayList dict = new ArrayList();
    public string[] terms;

    void Start()
    {
        //loads dictionary
        string holder, term = "";

        StringReader input = new StringReader(f.text);

        do
        {
            holder = input.ReadLine();

            if (holder != null)
            {
                term = holder;
                dict.Add(term);
            }

            holder = input.ReadLine();


        } while (holder != null);

        terms = new string[dict.Count];
        
        int c = 0;
        foreach(System.Object o in dict)
        {
            terms[c] = o.ToString();
            c++;
        }


        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);

    }


    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
        int termIndex = UnityEngine.Random.Range(0, terms.Length);
        
        wordTemplate.GetComponent<TextMesh>().text = terms[termIndex];

        blocks[count] = (GameObject) Instantiate(block, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        words.Add(Instantiate(wordTemplate, textSpawn[spawnPointIndex].position, textSpawn[spawnPointIndex].rotation));

        count++;
    }
}
