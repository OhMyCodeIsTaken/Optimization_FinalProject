using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class StringsManager : MonoBehaviour
{
    StringBuilder stringBuilder = new StringBuilder();

    private System.Random _rand = new System.Random();
    [SerializeField] private int _maxRandomNumber;

    private List<string> _letterStrings = new List<string>();
    private List<string> _numberStrings = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        InitNumberStrings();
        InitLetterStrings();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CombineStringsWithOperator();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CombineStringsWithStringBuilder();
        }
    }

    private void CombineStringsWithOperator()
    {
        for (int i = 0; i < 5000; i++)
        {
            string combinedString = _letterStrings[i] + _numberStrings[i];
        }
    }

    private void CombineStringsWithStringBuilder()
    {
        for (int i = 0; i < 5000; i++)
        {
            stringBuilder.Clear();
            stringBuilder.Append(_letterStrings[i]);
            stringBuilder.Append(_numberStrings[i]);
        }
    }

    private void InitNumberStrings()
    {
        for (int i = 0; i < 5000; i++)
        {
            _numberStrings.Add(_rand.Next(0, _maxRandomNumber + 1).ToString());
        }
    }

    private void InitLetterStrings()
    {
        for (int i = 0; i < 5000; i++)
        {
            string randomLetterString = string.Empty;
            // randomLettersString will be comprised of 1 random letter
            randomLetterString += GetRandomLetter();

            _letterStrings.Add(randomLetterString);
        }    
    }

    private char GetRandomLetter()
    {
        // This method returns a random lowercase letter (a to z)
        int num = _rand.Next(0, 26);
        char randomLetter = (char)('a' + num);
        return randomLetter;
    }

}
