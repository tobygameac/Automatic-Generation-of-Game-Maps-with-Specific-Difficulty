﻿using UnityEngine;
using System.Collections;

public class Rotater2D : MonoBehaviour {

  public float speed = 10;

  void Update () {
    transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
  }

}
