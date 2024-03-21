using System;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    bool checker;
    int plusone;

    public Text[] buttons = new Text[9];
    public Text message;
    public Text teamx;
    public Text teamo;

    public Color winColor = Color.magenta;

    public void Start()
    {
        checker = true;
    }

    public void Score()
    {
        if (CheckForWin("X"))
        {
            message.text = "Congratulations Team X!";
            plusone = int.Parse(teamx.text);
            teamx.text = Convert.ToString(plusone + 1);
            HighlightWinningLetters("X");
        }
        else if (CheckForWin("O"))
        {
            message.text = "Congratulations Team O!";
            plusone = int.Parse(teamo.text);
            teamo.text = Convert.ToString(plusone + 1);
            HighlightWinningLetters("O");
        }
        else if (CheckForTie())
        {
            message.text = "It's a tie!";
        }
    }

    bool CheckForWin(string symbol)
    {
        return
            (buttons[0].text == symbol && buttons[1].text == symbol && buttons[2].text == symbol) ||
            (buttons[3].text == symbol && buttons[4].text == symbol && buttons[5].text == symbol) ||
            (buttons[6].text == symbol && buttons[7].text == symbol && buttons[8].text == symbol) ||
            (buttons[0].text == symbol && buttons[3].text == symbol && buttons[6].text == symbol) ||
            (buttons[1].text == symbol && buttons[4].text == symbol && buttons[7].text == symbol) ||
            (buttons[2].text == symbol && buttons[5].text == symbol && buttons[8].text == symbol) ||
            (buttons[0].text == symbol && buttons[4].text == symbol && buttons[8].text == symbol) ||
            (buttons[2].text == symbol && buttons[4].text == symbol && buttons[6].text == symbol);
    }

    bool CheckForTie()
    {
        foreach (Text button in buttons)
        {
            if (button.text == "")
                return false;
        }
        return true;
    }

    void HighlightWinningLetters(string symbol)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].text == symbol)
            {
                buttons[i].color = winColor;
            }
        }
    }

    public void ButtonClicked(int index)
    {
        if (!string.IsNullOrEmpty(message.text))
            return;

        if (buttons[index].text == "")
        {
            buttons[index].text = checker ? "X" : "O";
            checker = !checker;
        }

        Score();
    }


    public void NewGame()
    {
        foreach (Text button in buttons)
        {
            button.text = "";
            button.color = Color.black;
        }
        message.text = "";
    }
}
