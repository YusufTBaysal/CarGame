using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovment : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float backgroundLength = 22f;

    public List<Transform> arkaplanNesneleri;

    private void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        if(transform.position.x < -backgroundLength)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
    }
}
