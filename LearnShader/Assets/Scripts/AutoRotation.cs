using UnityEngine;
using System.Collections;

public class AutoRotation : MonoBehaviour {
	public float rotaSpeed = 50f;

	private Transform m_Transform;

	// Use this for initialization
	void Start () {
		m_Transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 eulerAngles = m_Transform.eulerAngles;
		eulerAngles.y += rotaSpeed * Time.deltaTime;
		eulerAngles.y %= 360;
		m_Transform.eulerAngles = eulerAngles;
	}
}
