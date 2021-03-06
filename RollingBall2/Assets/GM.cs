using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false); // 让物体隐藏
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "YOU LOSE.";
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);  // 重新加载场景
    }

    public void Finish()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "YOU WON!!!";
    }
}
