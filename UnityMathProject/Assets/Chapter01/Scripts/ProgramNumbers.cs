using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramNumbers : MonoBehaviour
{
    [SerializeField]
    private Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        DrawTheTypeSize();
    }

    // 型の大きさをバイト数で表示
    void DrawTheTypeSize()
    {
        resultText.text =

                // 符号あり
                // byte
                //  型の大きさをバイト数で表示
                  "  byte  : " + sizeof(byte)
                //  型の最大値を表示
                + " max   : " + byte.MinValue
                //  型の最小値を表示
                + " min   : " + byte.MaxValue
                + " \n "

                // short               
                + " short  : " + sizeof(short)
                + " max   : " + short.MinValue
                + " min   : " + short.MaxValue
                + " \n "

                // int
                + " int     : " + sizeof(int)
                + " max   : " + int.MinValue
                + " min   : " + int.MaxValue
                + " \n "

                // long
                + " long  : " + sizeof(long)
                + " max   : " + long.MinValue
                + " min   : " + long.MaxValue
                + " \n "

                // 符号なし
                // sbyte
                + " sbyte  : " + sizeof(sbyte)
                + " max   : " + sbyte.MinValue
                + " min   : " + sbyte.MaxValue
                + " \n "

                // ushort               
                + " short  : " + sizeof(ushort)
                + " max   : " + ushort.MinValue
                + " min   : " + ushort.MaxValue
                + " \n "

                // uint
                + " uint     : " + sizeof(uint)
                + " max   : " + uint.MinValue
                + " min   : " + uint.MaxValue
                + " \n "

                // long
                + " ulong  : " + sizeof(ulong)
                + " max   : " + ulong.MinValue
                + " min   : " + ulong.MaxValue;

    }
}
