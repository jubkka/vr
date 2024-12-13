using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Transform leftBorder;
    [SerializeField] private Transform rightBorder;
    [SerializeField] private float speed = 0.001f;
    private bool flag;

    void Update()
    {
        flag = transform.localPosition.x < leftBorder.localPosition.x || transform.localPosition.x > rightBorder.localPosition.x;

        if (flag) speed *= -1;

        transform.Translate(new Vector3(speed,0f,0f));
    }
}
