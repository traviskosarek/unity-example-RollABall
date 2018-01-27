using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigidBody;
    private int count;

    public float Speed;
    public Text CountText;
    public Text WinText;

    private void Start()
    {
        this.rigidBody = GetComponent<Rigidbody>();
        this.count = 0;
        this.updateCountText();
        this.WinText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        this.rigidBody.AddForce(movement * this.Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            this.count++;
            this.updateCountText();
        }
    }

    private void updateCountText()
    {
        this.CountText.text = "Count: " + count.ToString();
		if(count >= 10){
            this.WinText.text = "You Win!";
        }
	}

}
