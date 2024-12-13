using UnityEngine;
using UnityEngine.UI;

public class HitTarget : MonoBehaviour
{
    [SerializeField] private Text count;

    public void Hit() 
    {
        Debug.Log("Hit!");
        int currentCount = int.Parse(count.text) + 1;

        count.text = currentCount.ToString();
    }
}
