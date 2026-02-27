using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float bgWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        bgWidth = GetComponent<BoxCollider>().size.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = transform.position.x - startPos.x;
        //Debug.Log(distance);
        if (Mathf.Abs(distance) > bgWidth/2)
        {
            transform.position = startPos;
        }
    }
}
