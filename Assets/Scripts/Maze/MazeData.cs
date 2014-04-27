﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class MazeData {

  public static bool isDebugging = true;

  private static System.Random random = new System.Random(); // Only need one random seed

  private static int MAX_DIFFICULTY = 5;
  private static int MAX_R = 100;
  private static int MAX_C = 100;

  private static List<List<List<List<string>>>> mazeData = new List<List<List<List<string>>>>();
  private static bool initialed = false; // Only initial once

  public static string getRandomMazeData (int R, int C, int difficulty) {

    initial();
    
    if (difficulty >= 0 && difficulty <= MAX_DIFFICULTY && R >= 0 && R <= MAX_R && C >= 0 && C <= MAX_C && mazeData[difficulty][R][C].Count > 0) {
      
      return mazeData[difficulty][R][C][random.Next(mazeData[difficulty][R][C].Count)];

    } else {

      if (isDebugging) {
        Debug.Log("Do not have any data of " + R + " * " + C + "with difficulty = " + difficulty + " maze.");
      }

      return null;
    }
  }

  private static void initial () {
    if (initialed) {
      return;
    }

    initialed = true;

    for (int difficulty = 0; difficulty <= MAX_DIFFICULTY; difficulty++) {
      mazeData.Add(new List<List<List<string>>>());
      for (int r = 0; r <= MAX_R; r++) {
        mazeData[difficulty].Add(new List<List<string>>());
        for (int c = 0; c <= MAX_C; c++) {
          mazeData[difficulty][r].Add(new List<string>());
        }
      }
    }

mazeData[0][10][10].Add("7 7 000000000000010001111110011110010010000011111100001111001100000010101110000110111110011111010010000100101010001101010100001111111110000000000000");
mazeData[0][10][10].Add("7 2 000000000000001010111110001001000100001001011110010100110110000100101000011111101010001011101110010111001010000101100110011110111100000000000000");
mazeData[0][10][10].Add("9 3 000000000000001001110010010001011010001111111110000100101010010110011000010101101110011101000010010111101100000100100010010011111110000000000000");
mazeData[0][10][10].Add("1 3 000000000000010111110010000101011110010101000110011100100000000100110100000111010010000101001010010001110110000001011100000111101010000000000000");
mazeData[0][10][10].Add("2 5 000000000000010101111000011111001010000110001110011100101010000101101100000100011100000111000110010101110100011110010100010101111000000000000000");
mazeData[0][10][10].Add("4 8 000000000000001011110000001001000000010101110110001011101000001010101000001110111000011010110100000110100010001011111110000100001010000000000000");
mazeData[0][10][10].Add("5 2 000000000000000000101110011111011010000100000010001101110110001011000000001010101010011110111010010011001010001101001110000111111010000000000000");
mazeData[0][10][10].Add("6 10 000000000000010110001000011101111100010100001100001100010110000101011110010110010010010101111010000111000000001011110110010000000110000000000000");
mazeData[0][10][10].Add("8 8 000000000000010010001110000010111000011110011100000111111100001100100110001010101010011010010100001011001010001001011010011111110000000000000000");
mazeData[0][10][10].Add("10 4 000000000000011110000100000111010000000100010100010100110100011111011000010100011110010110110000001011101100000101000000001111110110000000000000");
mazeData[0][10][10].Add("8 7 000000000000011000111110010100001000011000001100000101011110001111011110000011010110011111110010000000010110001101110010011101010010000000000000");
mazeData[0][10][10].Add("5 3 000000000000010000101010010101001010001011111010001010111010001111001110011000000110001111110010011001001010010101010000010000110110000000000000");
mazeData[0][10][10].Add("6 1 000000000000010000001100001111110010010010110000010111010000000110111110010100000010010111111110011100010100001001010100001011111000000000000000");
mazeData[0][10][10].Add("3 10 000000000000000111001010001001111100000101000010001101111110000011010010011111100110011010000100010011011100010010001100010010111010000000000000");
mazeData[0][10][10].Add("3 8 000000000000010110011110010101000100010011001110011111111000010001101110001001011000001100011000010010110010001111111000000000101110000000000000");
mazeData[0][10][10].Add("7 1 000000000000000111111000010001100000011111110000010010011000010001001000010000101110011111110000000101100000011101111000000100100000000000000000");
mazeData[0][10][10].Add("2 6 000000000000011000100010011011100100000110110100011100011110000110000000000111101100011110100010010110111010011110101110010000100010000000000000");
mazeData[0][10][10].Add("3 3 000000000000000101111010011110010010010100110110010110100010000111101110011111111110001000101010000000101010001110110010000100100010000000000000");
mazeData[0][10][10].Add("3 10 000000000000010000000000000000011110011111101010000010111010000010110010011001000110001011010010011101111110000101011110011111101100000000000000");
mazeData[0][10][10].Add("10 1 000000000000011110001000000111110100001000101010000110110010001011011010010111111110010111101010011100011000000101000000011111100100000000000000");
mazeData[0][10][10].Add("10 4 000000000000011001011110000101111000011110010000010000011100011101010000010100111000001110010000011011010110010101010010010111111000000000000000");
mazeData[0][10][10].Add("8 7 000000000000001010101110011111011000010000010110011100111000010111011110010001110000001111011100000100010000010010010100011000001000000000000000");
mazeData[0][10][10].Add("6 1 000000000000010011111100001101010010001101110100001111010100000100110010010111111010010100010010011101110100010011100010000111111000000000000000");
mazeData[0][10][10].Add("3 5 000000000000000100111010000100000010001011111110000101000010001011101000000110100100010100101010011111101010000011111110001111100010000000000000");
mazeData[0][10][10].Add("1 1 000000000000010011111010011110100000010111101010010111011010000111111000011111010110000101000010011110111000000101011010011110110110000000000000");
mazeData[0][10][10].Add("8 9 000000000000011111010100001100101000011001101000010001111110010011100010011111000010010000101110011100100110010101010100011111110100000000000000");
mazeData[0][10][10].Add("5 7 000000000000010010001010011011100100010010000110010111100100010000110100011111110000010001100000010111110000010001101010010111001110000000000000");
mazeData[0][10][10].Add("3 2 000000000000000000100010001111101000011110101010001001101100010100111010000010001110011010000010000111111110001110010010000110010010000000000000");
mazeData[0][10][10].Add("10 7 000000000000000110111100001100010000011010110000000010010110001111110010000011101110010001111010001010000010010110010110010101111110000000000000");
mazeData[0][10][10].Add("2 5 000000000000000100001000011111010110010000001000011000010000010100010100010110010110011111110100010100001000011110010000010111111110000000000000");
mazeData[0][10][10].Add("5 6 000000000000000101110100010111000000011011001000010001000000011111111010010110111110000110110010011101000010000100011010001111011100000000000000");
mazeData[0][10][10].Add("4 4 000000000000001000111110010001001000011010111110001010001100010111101110010001111110000110011010001010110110000111111010011000000010000000000000");
mazeData[0][10][10].Add("8 4 000000000000000011111110000001101000011101110100001001010000011001011100001110110010000010100010000110111100000100101110011111100100000000000000");
mazeData[0][10][10].Add("4 9 000000000000000111001110010100111100000111010000000100011110010111010000010001111100010011000010000011100010001001111100001000100010000000000000");
mazeData[0][10][10].Add("10 5 000000000000010111110000010001001010011101100000010111110100010111000100001011111100000101111110010001011010000101000110011101000010000000000000");
mazeData[0][10][10].Add("8 6 000000000000011111110000010101011100011001110000010001100000010111110000011001101010010111001110011111101010000011111000011111000110000000000000");
mazeData[0][10][10].Add("6 6 000000000000000111110100010101011100011111111010010111011100010010101100000111101000010000100000010010111010000100101000010100101010000000000000");
mazeData[0][10][10].Add("4 3 000000000000010010011010010110100110010010000000011111111110010101110100011101001110000101001010000110001010010101100110001011011010000000000000");
mazeData[0][10][10].Add("5 3 000000000000011101111110011000100000011000100010010100101100011101100000010101101010010111111000000101101110000101000010001000010010000000000000");
mazeData[0][10][10].Add("6 8 000000000000000111100010000010111010011010011110001101011010001100010110000000011010000111110010011101010000001001100010001010101100000000000000");
mazeData[0][10][10].Add("3 2 000000000000000001010110000000010110011111010100000101110010011110000100001111111000001010101110001100011000001001011000001011111000000000000000");
mazeData[0][10][10].Add("7 4 000000000000001110111000000100001000000111111000000110101100011001111100010101010100001011010100000111101000000100111000011110101010000000000000");
mazeData[0][10][10].Add("7 9 000000000000010100011100011111100110010001001000010001001010000111001110001011100110011000110100010000110100001111011100010011110010000000000000");
mazeData[0][10][10].Add("9 8 000000000000010101001000011110010100010011001010010001110010011101111010010000111110010010111010000100000010001101111110010110010000000000000000");
mazeData[0][10][10].Add("10 5 000000000000000111111110011111110100000100100100010011110000011111010010010100111110010001001110000001001010000010101110001111111100000000000000");
mazeData[0][10][10].Add("2 8 000000000000010111101010010001001000000011111100011011111100000110111100001110101010010010011110000110101110000010000010011111100010000000000000");
mazeData[0][10][10].Add("1 9 000000000000000111011100000110101010000010101000011101111100010011000010011010111100010111101000011110100110010010010100001111010010000000000000");
mazeData[0][10][10].Add("2 3 000000000000001111100000010100110100000101111110010000100010001000101010001000100110001011111010001000001000011111111000000001010010000000000000");
mazeData[0][10][10].Add("1 5 000000000000010111000010010001011100011111110110001010000100001010000110000110011100000010000110010010100010001111001110000011110010000000000000");
mazeData[0][10][10].Add("3 4 000000000000000111100010011010001000011111100110001101111110001011001000010101001000000101010110000111011000001101010000011111111100000000000000");
mazeData[0][10][10].Add("7 3 000000000000011110011100000100001000001100100000001010101100011101110000000111001010010111010010011110010100010011111100001111000100000000000000");
mazeData[0][10][10].Add("3 1 000000000000010011001010011111001010010010101110000010101010001111111110010100111110011100010100010011010010010110001110011001000110000000000000");
mazeData[0][10][10].Add("1 2 000000000000011110010010000101111100001111011100010010010010000010111100001011000010001111111000000100010110010100010110001111001010000000000000");
mazeData[0][10][10].Add("6 7 000000000000000111110010011101000000001000100000011111111100000010000000010010010010001111110010000010011110000101110000000101010110000000000000");
mazeData[0][10][10].Add("10 1 000000000000001011111100001111010010001001010100001111111000001010101110001110011000001000000010011111000100001000110110011101110100000000000000");
mazeData[0][10][10].Add("10 4 000000000000010101111100001110010000010111010000000011110100011010010000000110110100010111101000000001111010010001010010010111111110000000000000");
mazeData[0][10][10].Add("8 8 000000000000010111010100001010100100001111111100001010001010011001011110001010001010001110111100000100111010011011101010001100001000000000000000");
mazeData[0][10][10].Add("2 4 000000000000011001101110011111111000010100110000011000111100010001000110010010100110010010010010011111100110010000100010000011101110000000000000");
mazeData[0][10][10].Add("4 4 000000000000000101010010011101000110010101111010000111100110011110101100000100100110010110111110000100111010010001010010001001111010000000000000");
mazeData[0][10][10].Add("2 6 000000000000011000000110001111100100001110000000011011111110011111010100011010010100010010010000010110101000001010101110001111000000000000000000");
mazeData[0][10][10].Add("8 7 000000000000010010011110011010001000010110011000000010001110000110001000000011101110001110111100011010011010010100101000011111001000000000000000");
mazeData[0][10][10].Add("1 2 000000000000011111111010001010010010011110011110000000100010001000011110000111011010010100010110001100010010000100011000010011111000000000000000");
mazeData[0][10][10].Add("10 7 000000000000001111100100010101010000010101010010011101011010001110101110000101011010011110110010000011101110010101011000001000010100000000000000");
mazeData[0][10][10].Add("4 10 000000000000010111010010010001000010000001111110000000111010001111111010000010001110000100111110001000110110000011100100010100011110000000000000");
mazeData[0][10][10].Add("4 10 000000000000000001101010011101110000000111110010000001011010010001001110010011101010000010011010001111101000000101001010000011110100000000000000");
mazeData[0][10][10].Add("9 6 000000000000011111010000001001101010001111011010001001101000011111111010011011101000011001001000010111100110010000111100000111101000000000000000");
mazeData[0][10][10].Add("10 9 000000000000001100010010000000001010011111010110011111011010001000010010010111111110000001010010000111100110011101111010000001101110000000000000");
mazeData[0][10][10].Add("9 1 000000000000010001110010001001111100001110101000010100100100001010111110001010100000011111101010011000110010011000011110001110000010000000000000");
mazeData[0][10][10].Add("1 5 000000000000011111111010000110101010011101101110000111101000001011110100010101100110010001010100001001010100010011111110001111011000000000000000");
mazeData[0][10][10].Add("4 7 000000000000001010111110010011101000010001111100011110010100010100010010010111111110001100010010011000110010000111001000010111000000000000000000");
mazeData[0][10][10].Add("7 9 000000000000001101111000001000100100001111110110000010101000010110100100000011000100010001011110010111101100000101110100011110011110000000000000");
mazeData[0][10][10].Add("10 5 000000000000011100100100001100011100001110110010010101001010010111010010011101010000010011001100011101101100010001001110010111111110000000000000");
mazeData[0][10][10].Add("6 3 000000000000000111111110010000001000000001011110000101001110010011101010010110111110001100000010010111000010011010010100001111001100000000000000");
mazeData[0][10][10].Add("1 8 000000000000001000011000011111110110000010000110001111110110010011000100010111111000000110001010010100111010010101001010011110011110000000000000");
mazeData[0][10][10].Add("2 4 000000000000011010111110000010001010000111000010010111111110011011001100000010010100001110110000000010010010011111110010000101010010000000000000");
mazeData[0][10][10].Add("5 7 000000000000011111101000010101000100010011101110011100111000000010010010010001111100000111000110001001101110001001100010011111001110000000000000");
mazeData[0][10][10].Add("3 3 000000000000000100110000011101000100000100011010000111110100000101011100010111110010001010100010010111111110010100100110010101111000000000000000");
mazeData[0][10][10].Add("9 2 000000000000000010011010010010011110011111001100010011101010001010100010001010110110001000111110001110001010001011111000001000100000000000000000");
mazeData[0][10][10].Add("9 3 000000000000010110001010011100001010010111100110001110111010011000111110011110011010010011001010010000101010011110110010010000010000000000000000");
mazeData[0][10][10].Add("8 7 000000000000010111111110000001101000001001000010000011001000001010001000010011111000001011110100011110111110000000100110010011111000000000000000");
mazeData[0][10][10].Add("7 7 000000000000001001111110000010010000010100011110010110010100011111110010001001110100011100011010011100000010001000111000011000101100000000000000");
mazeData[0][10][10].Add("9 1 000000000000010111011110000111101000011101011010000011111110011111101010010010001010011101010010000100101110011111101010010000001010000000000000");
mazeData[0][10][10].Add("6 2 000000000000011100011010011111111110011101001010001111010100000001011110011111010010010111110110010111101010010001010000001111111110000000000000");
mazeData[0][10][10].Add("6 1 000000000000010111111010011000010000010011110010011110001000001000111010011001001010011111111110000100001100010100010000010100011100000000000000");
mazeData[0][10][10].Add("9 1 000000000000010000111110000100010010000010001110001101110010000010001110001000110010010011111110011111010010011000111100011110110010000000000000");
mazeData[0][10][10].Add("2 10 000000000000000100110010011010001110010111101010011100101000010000101100011100001010010110111010000111101110010001110010001100101010000000000000");
mazeData[0][10][10].Add("3 10 000000000000010111111000001000101110010110110110010011111000011100011010010111110000010001011000001011110110000100011110010101111100000000000000");
mazeData[0][10][10].Add("5 3 000000000000010111101000000001010100010101110100011010100110010111110110011010010100010010111110010110010110011110110010010101010010000000000000");
mazeData[0][10][10].Add("8 4 000000000000011011011110010001110100011011011110011111000110011001011110010110100100011101110110010111010100011001010100010101000000000000000000");
mazeData[0][10][10].Add("8 10 000000000000001001110010010110011110000000011010001111100110001100110010000011011110001110100010001111111110010001001000001001011110000000000000");
mazeData[0][10][10].Add("9 9 000000000000000000100110011000101110001101111110010001010010010101010110000001001010011001001110000111010010000101111100011110000000000000000000");
mazeData[0][10][10].Add("10 6 000000000000001011011010011101111000010110000000010110000000000011111100000010101110011010000100011110111100010100010100010101111000000000000000");
mazeData[0][10][10].Add("2 8 000000000000000010100110010001111000011011100010011110110010010110011110011010011010010110011000010010001110000110001110010010111110000000000000");
mazeData[0][10][10].Add("9 1 000000000000000111100100010001010010011101100110010101011100010011100110010110110100011010011100001110010100011100110000011111010100000000000000");
mazeData[0][10][10].Add("4 6 000000000000010100010000010100101010010010101010011111101110010011101010011000111000000111011110000100111010001010100010001001110110000000000000");
mazeData[0][10][10].Add("5 3 000000000000011111110010000011000110011011101010000001010110011111011000001001010010011111110000000011110000011111011000001001011110000000000000");
mazeData[0][10][10].Add("1 9 000000000000010101111110010100101000011011101110010110101000011010011100011010001010001000011000011001110100001111000010010000001010000000000000");
mazeData[0][10][10].Add("3 3 000000000000011111110110001001010100011101011100000010110110010010011100010101010000010100111010011011110110001100100110010011111010000000000000");
mazeData[0][10][10].Add("1 5 000000000000000101000110010001111010000001001100000001101010011101001010011011100110010110111010000100101110011100110000000111011100000000000000");
mazeData[0][10][10].Add("10 6 000000000000011110101010010100101010011000110110011111111110001010010110001111010010000000100010010101011110000111110100000100110100000000000000");


mazeData[1][10][10].Add("3 9 000000000000000101111100010000010000001111011100010100010000010111111110011101000100010001000000011110001010000100010100011111010100000000000000");
mazeData[1][10][10].Add("1 7 000000000000001001110100001111000100001001111100001000010100001110001100001011100100001010000100011010011100001011100100001010000100000000000000");
mazeData[1][10][10].Add("6 1 000000000000001111111010000010100010010010100000010001110100011101010100010111011110010101010000000101010000011100011100000111010010000000000000");
mazeData[1][10][10].Add("3 6 000000000000010000111100011111001010010100111010010110101010010100101110000111101010011101000110000001000010000111110010010000000000000000000000");
mazeData[1][10][10].Add("3 9 000000000000000011110010001000100010000011111110000100101010000111101010010100100000010101100100011001000100010111111110011100010000000000000000");
mazeData[1][10][10].Add("8 9 000000000000010001010010011100010110010001011010010101010110011111110010010000010110010001111010000000001110010111111010000001000010000000000000");
mazeData[1][10][10].Add("8 2 000000000000010100111110000110001000010000111010010101101010011111001110010001001010010001111000011110101010010100101010010101000000000000000000");
mazeData[1][10][10].Add("2 8 000000000000000011111110000101001000010101001000001100101110000100101000010111111110010101000000000101111110011001001010000000101010000000000000");
mazeData[1][10][10].Add("3 8 000000000000001000001010001010000010001101001110001001000010011111000010000001011110000101101010011101001000000101011110011111110000000000000000");
mazeData[1][10][10].Add("3 8 000000000000001111010100010100010100011111011100010001110100011100010000010010011110010001010100001001010100000101111010011111000000000000000000");
mazeData[1][10][10].Add("3 7 000000000000011111010010010101010010010101111110011001000010010001110010011001001110001110000010011001111110010110010100010101111000000000000000");
mazeData[1][10][10].Add("8 2 000000000000001000000000010011111010010000100010011111111110010010010010010110011100000100110010011100100010000101111110000100001010000000000000");
mazeData[1][10][10].Add("7 3 000000000000011111110000001010101010001010101000000110111110001010100000000110101000010100001000000111111000010101001000000101001010000000000000");
mazeData[1][10][10].Add("3 5 000000000000010001110100011111000100010101111100011111010100010001000100011101011110010001000010010001110010011101001110010001010010000000000000");
mazeData[1][10][10].Add("8 7 000000000000001010111100001000001010011111001000000010111010010011101000010010101110000010101000001110011110000010100000001111110000000000000000");
mazeData[1][10][10].Add("1 10 000000000000001000100010001000100010010011100110011000100010011100111110010100101010001010101010001000011000001000101000011111111110000000000000");
mazeData[1][10][10].Add("2 8 000000000000011111111110001010101000001111101110001000101000001001101110000001001000000111001000001110101110001000001000011110001010000000000000");
mazeData[1][10][10].Add("10 3 000000000000001111101000010100110100011111010100010000011100010001010110000111111010000000000010010111111110000001001010000111101010000000000000");
mazeData[1][10][10].Add("2 9 000000000000010010000010011001111100000100010010000101011010011111001110000001001010000001111110001111000010010010001110001111100010000000000000");
mazeData[1][10][10].Add("6 2 000000000000001001000010011011000010000100101110010101010010010100101010011111000110010000000010010111111110011101010010010001010010000000000000");
mazeData[1][10][10].Add("1 7 000000000000001111111000000010100010001110100000000010111110011110100100000101010100011111001000000001001000000111111000011000001000000000000000");
mazeData[1][10][10].Add("3 2 000000000000011111110100001001000010001001111000000000100000011111111100001010010010001000010010000001011110011001010010010111111100000000000000");
mazeData[1][10][10].Add("1 7 000000000000000001111000001100010100001010010100010101111100010100000100010111111100000100100100000101001100001001001000000111111110000000000000");
mazeData[1][10][10].Add("6 5 000000000000000001001000011111111110001000000000001111111110000101001000011101110000000101011110000101001000011110111110000000000000000000000000");
mazeData[1][10][10].Add("4 5 000000000000000100100000010011111110000110000100010101001100010101010000011111010100010001010100010111011110000001010000001011111100000000000000");
mazeData[1][10][10].Add("4 3 000000000000010101110100011111000100010001111100011100010100010000010000011100100110010000000000011111000100000100011010011111000110000000000000");
mazeData[1][10][10].Add("7 9 000000000000001000100100001000100100011111111100000010100100001110100110010010000010001001001110001001000010011111111110000000001010000000000000");
mazeData[1][10][10].Add("2 5 000000000000011101111100000111010000000010111110001110000100010011110100010001001010011111101010010101111110011101000100010101011110000000000000");
mazeData[1][10][10].Add("10 9 000000000000011100100010000111111010011100000110000100111010000101001110010111111010010100010110000111110010000101010000011111111100000000000000");
mazeData[1][10][10].Add("9 7 000000000000010111111010010010100110011110010100010010100010000010001000011111100000000100001000011101000010000101010000011111111100000000000000");
mazeData[1][10][10].Add("9 6 000000000000000000011110011111110100000100100100001011101010001000101010011000111110001000100100001111100100000100101000011111111110000000000000");
mazeData[1][10][10].Add("3 3 000000000000011111110000000101000010011101111000000101000000000111110100010100001000010100000000011111000000010000100100010110011110000000000000");
mazeData[1][10][10].Add("2 4 000000000000011100111100000111001010010100111000010100001010011110001010010011111110010001000010000101010110010000010100010001111110000000000000");
mazeData[1][10][10].Add("8 10 000000000000001111111110000010101000010010101000010001011100011111110110010100001010011110001110010110101010010000001010000001010000000000000000");
mazeData[1][10][10].Add("8 1 000000000000000101001100010001110000010001000100011101110100010010011100010100000100011111111100010000100100010010100100001111111000000000000000");
mazeData[1][10][10].Add("8 2 000000000000001110010010000011100010011110001110001001000010001111111110001000010100011010011100001010010100011111010100000000101010000000000000");
mazeData[1][10][10].Add("5 3 000000000000000101001100000001110010000101000010001101111110010101010010011111000010010001010100010001010010011101111100010001000000000000000000");
mazeData[1][10][10].Add("8 4 000000000000000000000100001111110000011001000100010001010100011101111110010001000000011101010010010110101010010010101110001111111010000000000000");
mazeData[1][10][10].Add("9 3 000000000000010001111100011111010000010101010000010101000000001001111110001001001000011001111110001011100000001110100000001001111000000000000000");
mazeData[1][10][10].Add("9 10 000000000000011111111100001001010010001001000010000101110110010001001010010111111110011000100010010100111010011111100010010000111000000000000000");
mazeData[1][10][10].Add("8 7 000000000000010101111000000100100010011110101010000011111110000010000010011110111100000010010000010011111100000010000010010111101000000000000000");
mazeData[1][10][10].Add("9 3 000000000000011111000010000100000010011111111010000001000110001011010010001001001110010011000010010011111110011110101010010100100100000000000000");
mazeData[1][10][10].Add("9 2 000000000000001111111110000010101000010010101100000000000100000010011100001001110100010100010100010100010010011111111100010001000010000000000000");
mazeData[1][10][10].Add("5 7 000000000000001001111100001000010000011010011010001010010100001011110100011010011100010010000100011101111100010010100010011111111000000000000000");
mazeData[1][10][10].Add("5 4 000000000000011111111100000100010000000111010010000100000010001111001110001000100010011000001110010111110010011101001010010011111110000000000000");
mazeData[1][10][10].Add("8 3 000000000000001010001010010100001110011111101010010010001110011101001010010001011010011111110000000100011100000100010010011111010110000000000000");
mazeData[1][10][10].Add("8 6 000000000000000111110010011001000010000111111110000100001010010110001000000101111110011100100000000100111010011000100100001100101110000000000000");
mazeData[1][10][10].Add("6 7 000000000000000011010000010000010000010101011100001001010010010111110000000000010000011111111110000101000100000101011100001000100100000000000000");
mazeData[1][10][10].Add("10 3 000000000000011110101000001000101010001111111010001010001110001010010010010000001110000001100010000010100110010010100100011111111110000000000000");
mazeData[1][10][10].Add("1 6 000000000000011111111100000101010010000101010010001010011110011010110010010011100110010101000010000101001110011111010010000001111100000000000000");
mazeData[1][10][10].Add("9 6 000000000000001000001010010000101010001100101110011011101010011000101110000011101010000100111000011111101010000000101000000011110100000000000000");
mazeData[1][10][10].Add("1 7 000000000000001111111110010010010010001001010010010000101110010100010010011111001110010000010010010001111110011111000100010101110100000000000000");
mazeData[1][10][10].Add("1 6 000000000000010000111000001011100000001000111110001111100100001010110100001010010010010101111110011111000010010001001110010001010010000000000000");
mazeData[1][10][10].Add("4 4 000000000000011111110000000101000100010001010100010111111100010100000100011110011100010100100100011000011100010010000100011001011110000000000000");
mazeData[1][10][10].Add("9 5 000000000000000001100000011110001010000100001010011100011110000111100010000101001110010101110010000001000110011111010010000101111110000000000000");
mazeData[1][10][10].Add("4 7 000000000000000000000010011111111010000100100110001100110010000100011110011110001010000000111010011000001000010111111110001001000000000000000000");
mazeData[1][10][10].Add("4 3 000000000000001111111100000101010000010111001010000101110110010110000100010100100010011110100000010010111110001110101000010011111110000000000000");
mazeData[1][10][10].Add("4 2 000000000000010011111000001000100100001111111110001001010000001001011010000100010010000000111110011110100010000100101000011111111110000000000000");
mazeData[1][10][10].Add("6 8 000000000000000001111110001110010100000000010100011111110010001001010010001101011110010100010010011100110010010011101000010000111110000000000000");
mazeData[1][10][10].Add("4 7 000000000000010011111100011100100010010010100010010001111110011111001010010010001010011011100100010010000000000111111100011100010010000000000000");
mazeData[1][10][10].Add("5 3 000000000000000100001000000000111000011111001000000100101110010110101000010100111100000100100010011111100010000001111110010111001010000000000000");
mazeData[1][10][10].Add("8 8 000000000000000010111110010010010100001111110100010000010000011111110000010010010010010011010010000001101010001100101000001011111110000000000000");
mazeData[1][10][10].Add("7 7 000000000000011111111000001010101110011010110000010000010010011100011100010111010000010100110010000111010000010100111100001111000000000000000000");
mazeData[1][10][10].Add("4 5 000000000000011111111110001010100100001010101100000001001010000101111110010101001010010111001010011110100000010010001110001111100000000000000000");
mazeData[1][10][10].Add("1 7 000000000000010011111010000100100000000101100110011111011110000001100010000010111110010010101010010111101010010000100100001011111000000000000000");
mazeData[1][10][10].Add("1 6 000000000000001111100100000010010010001110101010010010100110000011110010001110001110000011111010000110101010010100101100001111001000000000000000");
mazeData[1][10][10].Add("7 2 000000000000010001111100011100010010010010011100011010110000001111100100001001000100001101111100001001010100001001010110000111100100000000000000");
mazeData[1][10][10].Add("10 2 000000000000001000001010001100101010011100101110000100111010000000010010000111111100001001000010001111111100001000001000011110111110000000000000");
mazeData[1][10][10].Add("7 7 000000000000010101111100011100010010010100010000011111111100010000100010011000111100010011110010010000010010000111111110010001000010000000000000");
mazeData[1][10][10].Add("1 9 000000000000000101000100000111111100010100010100010101110100000000010000010111111010001001001010010111011110000001000100000111110100000000000000");
mazeData[1][10][10].Add("6 1 000000000000010000000000010001111100011000010000010100010000011101011110010101010000011111111100010000000010011010100010001111111000000000000000");
mazeData[1][10][10].Add("10 10 000000000000011111110010001001001110001011011010000001010010001101111100000010100000000010100000000011111110001010001000011010111110000000000000");
mazeData[1][10][10].Add("5 5 000000000000011111110000010101011100010101010010011010010010010001110110010100010010001001011110000101010010001011111010011100000100000000000000");
mazeData[1][10][10].Add("6 9 000000000000001111100010010010010110010010010000011111111110010100000100010101111110001000010000010001110010000010010010000011010110000000000000");
mazeData[1][10][10].Add("10 2 000000000000010010001000001010000000000011101000001010001000000111111010011100101010000100101100011101001000000101010100011111111000000000000000");
mazeData[1][10][10].Add("7 7 000000000000011111110000000101000000001100000010001011111000001110100010001010100110001010111010000100100100000100100100011111111110000000000000");
mazeData[1][10][10].Add("8 5 000000000000011111000100000100000110011111111110000000101010001011101010000000100010011111110000000101010100010101010100000010111110000000000000");
mazeData[1][10][10].Add("3 9 000000000000001111000000010100111110001111100100000000100100011111101000000100101010011100111000000100101010011100101000000101000100000000000000");
mazeData[1][10][10].Add("6 5 000000000000011111111010000100100010010110111110000100101010000111001010001101010100011001000100010100000110010100100100011111111110000000000000");
mazeData[1][10][10].Add("4 1 000000000000001111111110010010010100011110110100010010010110010010010100011000001110010111111010010001001010000111111100001000000000000000000000");
mazeData[1][10][10].Add("2 6 000000000000000000111110011111101000000100001010011100010000000101110010010100010000011111111100010001000010011101100100010001011100000000000000");
mazeData[1][10][10].Add("2 6 000000000000000111000000000001111110001001010100010101010110010000000100000111111100000001010100000111011100000100010100011111010100000000000000");
mazeData[1][10][10].Add("1 4 000000000000011111001010000100101010000100001110000111101010001101011010001000001000001111111000001001001010001001001010011110100010000000000000");
mazeData[1][10][10].Add("4 7 000000000000000111100100011001010000000111011010011001010010000101111110010101000010010111010010011101001000010100100100010100000010000000000000");
mazeData[1][10][10].Add("1 9 000000000000010011111110010010100100010010100100011110001010010000001010011111111110001010001010001111011010001000001000011110011110000000000000");
mazeData[1][10][10].Add("1 10 000000000000000010011110010000000100010111111100011101010100001001010100011100101000010100100100010110111010010010100010001111111100000000000000");
mazeData[1][10][10].Add("6 5 000000000000011111111000000100101110011101001000000101001110011111001000000001001010000001110000011001000100010001000010011110101000000000000000");
mazeData[1][10][10].Add("4 1 000000000000011111000100000100000100000100011100011111110100000000101100011111100100001010100100000010111000001000100110000100100100000000000000");
mazeData[1][10][10].Add("9 3 000000000000011111101100000101010010010101010010001011111110010010000010010111110010011101000100010111111010010100010100001111011110000000000000");
mazeData[1][10][10].Add("7 9 000000000000010100011110011111000100010000000100010000111100011111100100010100100100010100100110000010000100000010100100001111111110000000000000");
mazeData[1][10][10].Add("10 8 000000000000000010000010010011111100010010010000011111111110010000000100011111101100010101001000010101001110001000001000000101101000000000000000");
mazeData[1][10][10].Add("1 1 000000000000010001110010010000011110011111110010010010001110010011000010000010111110001111001010000000001010001011111000000000100000000000000000");
mazeData[1][10][10].Add("3 10 000000000000010101111010000100001010010111111110010010100010010010001110011011110010010101001010011001110100001001001110011111110110000000000000");
mazeData[1][10][10].Add("7 10 000000000000010001111010010111010010011100011110010000010010010111110010001001010100011111101010000010101010000010111110001100100010000000000000");
mazeData[1][10][10].Add("5 6 000000000000010011110000011101000100010111001000010101001010001101111010000101001110011100000100000101111100000100010100001001111110000000000000");
mazeData[1][10][10].Add("6 1 000000000000011111111010000010100010010100101110011100111010010011100010011100111100010000010010011111110000010101010100001001001000000000000000");
mazeData[1][10][10].Add("6 8 000000000000000111111110010001001000000000111010001111101010000010001010010111011110010101100010011100111000010100100110010101111000000000000000");
mazeData[1][10][10].Add("9 1 000000000000000111110010001001011010000101101110000101001010011111001010000001001100000101101000010010101000010010100100011111111010000000000000");
mazeData[1][10][10].Add("10 2 000000000000011100101000001100101000010010111110000010100000010011110010001010001010010010000000001110100100000010100100001111111110000000000000");
mazeData[1][10][10].Add("6 7 000000000000010000001000011101111010010011001010010010011110011110000010010101111110010100001000000011111110000100100000010101111000000000000000");

  }

}
