using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	Rigidbody m_Rigidbody;

	void Start()
	{
		// 自分のRigidbodyを取ってくる
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		// 十字キーで首を左右に回す
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
		}

		// 矢印キーで移動する
		float x = 0.0f;
		float z = 0.0f;

		if (Input.GetKey(KeyCode.RightArrow))
		{
			x += 1.0f;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			x -= 1.0f;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			z += 1.0f;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			z -= 1.0f;
		}

		m_Rigidbody.velocity = z * transform.forward + x * transform.right;
	}
}