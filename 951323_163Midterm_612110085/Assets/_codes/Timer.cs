using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 30;
    public Text textTime;
    // Start is called before the first frame update
    void Start()
    {
        textTime.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textTime.text = Mathf.Round(timeStart).ToString();
    }
}
