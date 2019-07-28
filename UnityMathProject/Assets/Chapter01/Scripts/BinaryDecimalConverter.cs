using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// 正規表現
using System.Text.RegularExpressions;

public class BinaryDecimalConverter : MonoBehaviour
{
    [SerializeField]
    private InputField inputBinary;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Text resultText;
    private int binary;

    public void InputBinary()
    {
        resultText.text = "...";

        // inputBinaryが2進数ならば
        if (IsBinary(inputBinary.text))
        {
            text.color = Color.white;
            binary = int.Parse(inputBinary.text);

            text.text = "2進数を10進数へ変換しました";

            // 2進数を10進数に変換して結果を表示
            resultText.text = BinaryDecimalConvert(binary).ToString();
        }
        // inputBinaryが2進数でなければ
        else
        {
            text.color = Color.red;
            text.text = "２～９のいずれかが含まれています";

            inputBinary.text = "";
        }
    }

    private int BinaryDecimalConvert(int binary)
    {
        int result = 0;

        // 桁の数を調べる
        int digit = 1;
        for (int i = binary; i >= 10; i /= 10)
        {
            digit++;
        }

        // 桁の数分繰り返す
        for (int i = digit; i > 0; i--)
        {
            // べき乗で桁の単位を求める
            int digitUnit = (int)Mathf.Pow(10, i - 1);
            if (digitUnit <= 0) digitUnit = 1;

            // 桁の値を求める
            // 桁で割って小数点切り捨て
            int n = binary / digitUnit;
            // 桁で割って余りを求める
            int num = n % 10;

            // 値が1ならば2のべき乗で足していく
            if (num == 1)
            {
                int value = (int)Mathf.Pow(2, i - 1);
                result += value;
            }
        }
        return result;
    }

    // バイナリ判定
    private bool IsBinary(string inputBinary)
    {
        string noBinary = "[23456789]";
        // 正規表現 inputBinaryにnoBinaryが含まれるか？
        // バイナリかを返すのでboolを!で反転させreturn
        return !(Regex.IsMatch(inputBinary, noBinary));
    }
}
