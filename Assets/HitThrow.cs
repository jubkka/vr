using UnityEngine;
using UnityEngine.UI;

public class HitThrow : MonoBehaviour
{
    [SerializeField] private Text text;

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "ball") return;
        if (other.transform.position.y < transform.position.y) return;

        int number = int.Parse(text.text);
        number++;

        text.text = number.ToString();
    }
}
