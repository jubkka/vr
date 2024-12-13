using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject targets;
    [SerializeField] private Text count;
    [SerializeField] private int duration = 60;

    public bool isStarted = false;

    private void Update()
    {
        int time = int.Parse(timer.GetComponentInChildren<Text>().text); 

        if (time >= duration) Off();
    }

    public void On() 
    {
        if (isStarted) Off();

        isStarted = true;

        timer.GetComponentInChildren<Timer>().TimerOn();
        targets.SetActive(true);
        count.text = "0";
    }  

    private void Off() 
    {
        isStarted = false;

        timer.GetComponentInChildren<Timer>().TimerOff();
        targets.SetActive(false);
    }
}
