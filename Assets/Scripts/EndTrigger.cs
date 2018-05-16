using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour {

    private int count;

    void OnTriggerStay(Collider other)
    {
        count++;
        if(count == 28)
            Application.LoadLevel("ResultScreen");
    }

    void OnTriggerExit(Collider other)
    {
        count = 0;
    }
}
