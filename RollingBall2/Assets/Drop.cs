using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GM").GetComponent<GM>().GameOver();
    }
}
