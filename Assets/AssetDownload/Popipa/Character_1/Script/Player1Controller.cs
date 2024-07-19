using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player1Controller : MonoBehaviour
{
	Vector3 point;

	[SerializeField] private GameObject dialogPoint;

	public Vector3 getPoint()
	{
		return point = dialogPoint.transform.position;
	}
}



