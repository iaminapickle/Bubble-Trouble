using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrail : MonoBehaviour
{
    [SerializeField] private GameObject arrowHead;
    private Vector2 start;
    private float distance;
    private float height = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        start = arrowHead.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(start, arrowHead.transform.position);
        gameObject.transform.localScale = new Vector2(1, distance / height);
    }
}
