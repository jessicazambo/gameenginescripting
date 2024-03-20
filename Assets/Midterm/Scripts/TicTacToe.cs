using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UI;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text button1 = null;
    public Text button2 = null;
    public Text button3 = null;
    public Text button4 = null;
    public Text button5 = null;
    public Text button6 = null;
    public Text button7 = null;
    public Text button8 = null;
    public Text button9 = null;

    public Text newgamebutton = null;
    public Text message = null;

    public Text teamx;
    public Text teamo;

    public void Score()
    {

        if (button1.text == "X" && button2.text == "X" && button3.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button1.text == "X" && button4.text == "X" && button7.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button1.text == "X" && button5.text == "X" && button9.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button3.text == "X" && button5.text == "X" && button7.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button2.text == "X" && button5.text == "X" && button8.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button3.text == "X" && button6.text == "X" && button9.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button4.text == "X" && button5.text == "X" && button6.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }

        if (button7.text == "X" && button8.text == "X" && button9.text == "X")
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
        }




        if (button1.text == "O" && button2.text == "O" && button3.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button1.text == "O" && button4.text == "O" && button7.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button1.text == "O" && button5.text == "O" && button9.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button3.text == "O" && button5.text == "O" && button7.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button2.text == "O" && button5.text == "O" && button8.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button3.text == "O" && button6.text == "O" && button9.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button4.text == "O" && button5.text == "O" && button6.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }

        if (button7.text == "O" && button8.text == "O" && button9.text == "O")
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
        }



        if (button1.text != "" &&
        button2.text != "" &&
        button3.text != "" &&
        button4.text != "" &&
        button5.text != "" &&
        button6.text != "" &&
        button7.text != "" &&
        button8.text != "" &&
        button9.text != "")
        {
            message.text = "It's a tie!";
        }

    }

    public void text1_Click()
    {
        if (checker == false)
        {
            button1.text = "X";
            checker = true;
        }

        else
        {
            button1.text = "O";
            checker = false;
        }

        Score();
    }

    public void text2_Click()
    {
        if (checker == false)
        {
            button2.text = "X";
            checker = true;
        }

        else
        {
            button2.text = "O";
            checker = false;
        }

        Score();
    }

    public void text3_Click()
    {
        if (checker == false)
        {
            button3.text = "X";
            checker = true;
        }

        else
        {
            button3.text = "O";
            checker = false;
        }

        Score();
    }

    public void text4_Click()
    {
        if (checker == false)
        {
            button4.text = "X";
            checker = true;
        }

        else
        {
            button4.text = "O";
            checker = false;
        }

        Score();
    }

    public void text5_Click()
    {
        if (checker == false)
        {
            button5.text = "X";
            checker = true;
        }

        else
        {
            button5.text = "O";
            checker = false;
        }

        Score();
    }

    public void text6_Click()
    {
        if (checker == false)
        {
            button6.text = "X";
            checker = true;
        }

        else
        {
            button6.text = "O";
            checker = false;
        }

        Score();
    }

    public void text7_Click()
    {
        if (checker == false)
        {
            button7.text = "X";
            checker = true;
        }

        else
        {
            button7.text = "O";
            checker = false;
        }

        Score();
    }
    public void text8_Click()
    {
        if (checker == false)
        {
            button8.text = "X";
            checker = true;
        }

        else
        {
            button8.text = "O";
            checker = false;
        }

        Score();
    }

    public void text9_Click()
    {
        if (checker == false)
        {
            button9.text = "X";
            checker = true;
        }

        else
        {
            button9.text = "O";
            checker = false;
        }

        Score();
    }

    public void newgamebutton_Click()
    {
        button1.text = "";
        button2.text = "";
        button3.text = "";
        button4.text = "";
        button5.text = "";
        button6.text = "";
        button7.text = "";
        button8.text = "";
        button9.text = "";
        message.text = "";
    }
}
