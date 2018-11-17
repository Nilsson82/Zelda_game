﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementModel : MonoBehaviour {

  public float Speed;

  private Vector3 m_MovementDirection;

	// Use this for initialization
	void Start ()
  {
		
	}
	
	// Update is called once per frame
	void Update ()
  {
    UpdateMovement();	
	}

  void UpdateMovement()
  {
    // Check if Character not moving.
    if (m_MovementDirection == Vector3.zero)
    {
      return;
    }

    //If character walk in two direction at same time normal walking distance.
    m_MovementDirection.Normalize();

    transform.position += m_MovementDirection * Speed * Time.deltaTime;

  }

  public void SetDirection(Vector2 direction)
  {
    m_MovementDirection = new Vector3(direction.x, direction.y, 0);
  }

  public Vector3 GetDirection()
  {
    return m_MovementDirection;
  }

  public bool IsMoving()
  {
    return m_MovementDirection != Vector3.zero;
  }
}
