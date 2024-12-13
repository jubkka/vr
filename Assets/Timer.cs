using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text time;
    int count = 0;

    public IEnumerator tikTak() {
        while(true) 
        {
            count ++;
            time.text = count.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    public void TimerOn() {
        count = 0;
        StartCoroutine("tikTak");
    } 

    public void TimerOff() {
        StopCoroutine("tikTak");
    } 
}
