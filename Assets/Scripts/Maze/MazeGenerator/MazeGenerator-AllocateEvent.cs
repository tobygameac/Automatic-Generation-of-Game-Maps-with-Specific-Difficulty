﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class MazeGenerator : MonoBehaviour {

  public int[] randomEventCount;
  public GameObject[] randomEventPrefabs;

  private GameObject randomEvents;

  private void initialRandomEvent () {
    randomEvents = new GameObject();
    randomEvents.name = "randomEvents";
    for (int i = 0; i < randomEventCount.Length; i++) {
      allocateRandomEvent(i, randomEventCount[i]);
    }
  }

  public Vector3 getNewEventPosition () {
    int randomH = random.Next(MAZE_H);
    Point point = getRandomAvailableBlock(randomH);
    int r = point.r;
    int c = point.c;
    Point offset = getOffset(randomH);
    int realR = (r + offset.r) * BLOCK_SIZE;
    int realC = (c + offset.c) * BLOCK_SIZE;
    float baseY = getBaseY(randomH);
    return new Vector3(realC + (random.Next(10) - 10) / 100.0f, baseY + 1.25f + (random.Next(10) - 10) / 100.0f, realR + (random.Next(10) - 10) / 100.0f);
  }

  public void allocateRandomEvent (int number) {
    int randomEventIndex = random.Next(randomEventPrefabs.Length);
    for (int i = 0; i < number; i++) {
      Vector3 randomEventPosition = getNewEventPosition();
      GameObject randomEvent = Instantiate(randomEventPrefabs[randomEventIndex], randomEventPosition, randomEventPrefabs[randomEventIndex].transform.rotation) as GameObject;
      randomEvent.transform.parent = randomEvents.transform;
    }
  }

  public void allocateRandomEvent (int randomEventIndex, int number) {
    for (int i = 0; i < number; i++) {
      Vector3 randomEventPosition = getNewEventPosition();
      GameObject randomEvent = Instantiate(randomEventPrefabs[randomEventIndex], randomEventPosition, randomEventPrefabs[randomEventIndex].transform.rotation) as GameObject;
      randomEvent.transform.parent = randomEvents.transform;
    }
  }

}