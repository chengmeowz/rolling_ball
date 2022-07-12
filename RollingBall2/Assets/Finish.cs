using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GM").GetComponent<GM>().Finish();
    }
}
