﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    //Game State
    private int level;

    private enum Screen { MainMenu, Password, Win };

    Screen currentScreen;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
        print("Hello " + "World");

    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("press 1 for the local library");
        Terminal.WriteLine("press 2 for the local library");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr Bond!");
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
            if (level == 1)
            {
                print("Level 01");
            }
        }
        else if (input == "2")
        {
            print("you are a dick");
            level = 1;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Jocelyn is not Happy with YOU.");
            print("Jocelyn is not happy with you.");
        }
    }


    private void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("please enter your password: s");
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
