using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavelAnd : MonoBehaviour {
	public string level;
    public static LavelAnd rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }

    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Main() 
    {
        Time.timeScale = 1;
        Destroy(SoundPlayer.regit.gameObject);
        SceneManager.LoadScene("StartScene");
    }
    public void Next()
    {
        SceneManager.LoadScene(level);
    }
}
