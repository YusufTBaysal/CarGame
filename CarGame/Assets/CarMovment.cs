using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CarMovment : MonoBehaviour
{
    public float speed = 5f;
    public GameObject panel;

    private bool hasCollided = false;

    public Text text;
    public int count = 0;

    private Coroutine countingCoroutine; // Coroutine referansý ekledik

    public GameObject leftWall;

    private void Start()
    {
        text.text = "Score : " + count;
        countingCoroutine = StartCoroutine(CountUpTo100());
    }

    private void Update()
    {
        if (!hasCollided)
        {
            // Yukarý-aþaðý hareket
            float vertical = Input.GetAxis("Vertical");
            Vector3 moveVertical = new Vector3(0, vertical, 0);
            transform.Translate(moveVertical * speed * Time.deltaTime);

            // Saða-sola hareket
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 moveHorizontal = new Vector3(horizontal, 0, 0);
            transform.Translate(moveHorizontal * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            BoxCollider2D leftWallCollider = leftWall.GetComponent<BoxCollider2D>();
            leftWallCollider.enabled = false;
            hasCollided = true;
            panel.SetActive(true);
            if (countingCoroutine != null)
            {
                StopCoroutine(countingCoroutine);
            }
        }
    }

    IEnumerator CountUpTo100()
    {
        while (count < 9999)
        {
            count++;
            text.text = "Score : " + count;
            yield return new WaitForSeconds(1f / 60f); // 1 saniye / 100 (saniyede 100 kez sayacak)
        }
    }


}
