using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public AnimationCurve curve;

    Vector3 startPosition;
    Vector3 targetPosition;
    float timer = 0.0f;
    float duration = 3f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = Vector3.zero;
        targetPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float percent = timer / duration;
        transform.position = Vector3.Lerp(startPosition, targetPosition, curve.Evaluate(percent));
    }

    public void Move(Vector3 movePosition)
    {
        timer = 0.0f;
        startPosition = transform.position;
        targetPosition = movePosition;
    }
}
