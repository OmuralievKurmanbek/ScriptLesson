using UnityEngine;
using TMPro;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private TMP_InputField firstInput;
    [SerializeField] private TMP_InputField secondInput;
    [SerializeField] private TMP_Text resultText;

    public void Compare()
    {
        if (!float.TryParse(firstInput.text, out float a) || !float.TryParse(secondInput.text, out float b))
        {
            resultText.text = "Введите корректные числа";
            return;
        }

        if (a > b)
            resultText.text = a.ToString();
        else if (b > a)
            resultText.text = b.ToString();
        else
            resultText.text = "Равны";
    }
}
