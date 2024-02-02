using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public TextMeshProUGUI label;

    public void PrintMessage(string msg)
    {
        label.text = msg;
    }

    //public int number (4 bytes);
    //public float numberdecimal (4 bytes);
    //public double longerdecimal (8 bytes);
    //public long bignumber (int just 8 bytes);

    public void Add(int number)
    {
        label.text = (number + 10).ToString();
    }
    //change + sign to whatever function
}
