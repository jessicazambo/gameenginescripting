using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TextMeshProUGUI textLabel;

    private float prevInput = 0f;
    private bool clearPrevInput = false;
    private EquationType equationType = EquationType.None;

    private void Start()
    {
        Clear();
    }

    public void AddInput(string input)
    {
        if (clearPrevInput)
        {
            textLabel.text = string.Empty;
            clearPrevInput = false;
        }

        textLabel.text += input;
    }

    public void SetEquationAsAdd()
    {
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.ADD;
    }

    public void SetEquationAsSubtract()
    {
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT;
    }

    public void SetEquationAsMultiply()
    {
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY;
    }

    public void SetEquationAsDivide()
    {
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE;
    }

    public void Add()
    {
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput + currentInput;
        textLabel.text = result.ToString();
    }

    public void Subtract()
    {
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput - currentInput;
        textLabel.text = result.ToString();
    }

    public void Multiply()
    {
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput * currentInput;
        textLabel.text = result.ToString();
    }

    public void Divide()
    {
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput / currentInput;
        textLabel.text = result.ToString();
    }

    public void Clear()
    {
        textLabel.text = "0";
        clearPrevInput = true;
        prevInput = 0;
        equationType = EquationType.None;
    }

    public void Calculate()
    {
        if (equationType == EquationType.ADD) Add();
        else if (equationType == EquationType.SUBTRACT) Subtract();
        else if (equationType == EquationType.MULTIPLY) Multiply();
        else if (equationType == EquationType.DIVIDE) Divide();
    }

    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
