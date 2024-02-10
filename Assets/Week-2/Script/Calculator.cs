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
        Debug.Log("AddInput method called with input: " + input);
        if (clearPrevInput)
        {
            textLabel.text = string.Empty;
            clearPrevInput = false;
        }

        textLabel.text += input;
    }

    public void SetEquationAsAdd()
    {
        Debug.Log("SetEquationAsAdd method called");
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.ADD;
    }

    public void SetEquationAsSubtract()
    {
        Debug.Log("SetEquationAsSubtract method called");
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT;
    }

    public void SetEquationAsMultiply()
    {
        Debug.Log("SetEquationAsMultiply method called");
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY;
    }

    public void SetEquationAsDivide()
    {
        Debug.Log("SetEquationAsDivide method called");
        prevInput = float.Parse(textLabel.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE;
    }

    public void Add()
    {
        Debug.Log("Add method called");
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput + currentInput;
        textLabel.text = result.ToString();

    }

    public void Subtract()
    {
        Debug.Log("Subtract method called");
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput - currentInput;
        textLabel.text = result.ToString();
    }

    public void Multiply()
    {
        Debug.Log("Multiply method called");
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput * currentInput;
        textLabel.text = result.ToString();
    }

    public void Divide()
    {
        Debug.Log("Divide method called");
        float currentInput = float.Parse(textLabel.text);
        float result = prevInput / currentInput;
        textLabel.text = result.ToString();
    }

    public void Clear()
    {
        Debug.Log("Cleared");
        textLabel.text = "0";
        clearPrevInput = true;
        prevInput = 0;
        equationType = EquationType.None;
    }

    public void Calculate()
    {
        Debug.Log("Calculate method called");

        if (equationType == EquationType.ADD)
        {
            Add();
            Debug.Log("Result after addition: " + textLabel.text);
        }
        else if (equationType == EquationType.SUBTRACT)
        {
            Subtract();
            Debug.Log("Result after subtraction: " + textLabel.text);
        }
        else if (equationType == EquationType.MULTIPLY)
        {
            Multiply();
            Debug.Log("Result after multiplication: " + textLabel.text);
        }
        else if (equationType == EquationType.DIVIDE)
        {
            Divide();
            Debug.Log("Result after division: " + textLabel.text);
        }

    }

    public void PerformCalculation()
    {
        Debug.Log("PerformCalculation called");
        Calculate();
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
