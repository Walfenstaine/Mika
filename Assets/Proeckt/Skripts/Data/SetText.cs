using UnityEngine;
using UnityEngine.UI;


public class SetText: MonoBehaviour
{
    public Data data;
    [SerializeField] private Language language;

    float timer = 0;
    private void Start()
    {
        Text myText = GetComponent<Text>();
        if (data.language == "ru")
        {
            myText.text = language.ru;
        }
        else
        {
            myText.text = language.en;
        }
    }
    private void FixedUpdate()
    {
        if (timer < Time.time) 
        {
            Start();
            timer = Time.time + 0.5f;
        }
    }
}
