using UnityEngine;
using TMPro;

public class SimpleCalculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField _firstValueInput;  
    [SerializeField] private TMP_InputField _secondValueInput;
    [SerializeField] private TMP_Text _resultOutput;

    public void AddNumbers()
    {
        float firstNumber = float.Parse(_firstValueInput.text);
        float secondNumber = float.Parse(_secondValueInput.text);

        float result = firstNumber + secondNumber;
        _resultOutput.text =$"{result}";
    }
    public void SubtractNumbers()
    {
        float firstNumber = float.Parse(_firstValueInput.text);
        float secondNumber = float.Parse(_secondValueInput.text);

        _resultOutput.text = (firstNumber - secondNumber).ToString();
    }
    public void MultiplyNumbers()
    {
        float firstNumber = float.Parse(_firstValueInput.text);
        float secondNumber = float.Parse(_secondValueInput.text);

        _resultOutput.text = (firstNumber * secondNumber).ToString();
    }

    public void DivideNumbers()
    {
        float firstNumber = float.Parse(_firstValueInput.text);
        float secondNumber = float.Parse(_secondValueInput.text);

        _resultOutput.text = (firstNumber / secondNumber).ToString();
    }
    public void CleanFields()
    {
        _firstValueInput.text = string.Empty;
        _secondValueInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }

}
