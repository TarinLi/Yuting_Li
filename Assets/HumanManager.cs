using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
 public GameObject human;
 public float value;
 public Vector3 sizeChange;

 public void MoveLeft()
 {
 value = value + 0.3f;
human.transform.position = new Vector3(value+10f,2.5f,12.5f);
 }
public void MoveRight()
 {
 value = value - 0.3f;
human.transform.position = new Vector3(value+10f,2.5f,12.5f);
 }
public void MoveForward()
 {
 value = value + 0.3f;
human.transform.position = new Vector3(10f,2.5f,value+12.5f);
 }
public void MoveBack()
 {
 value = value - 0.3f;
human.transform.position = new Vector3(10f,2.5f,value+12.5f);
 }
  public void RotateRight()
 {
     human.transform.Rotate(0f,30f,0f);
 }
public void RotateLeft()
 {
     human.transform.Rotate(0f,-30f,0f);
 }
 public void Grow()
{
human.transform.localScale = human.transform.localScale + sizeChange;
}
public void ResetHuman()
{
    human.transform.position = new Vector3(10f, 2.5f ,12.5f);
    human.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
    human.transform.localScale = new Vector3(1f, 1f, 1f);
}
}

