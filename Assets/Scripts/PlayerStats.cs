using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    // Kartojuosi keiciam inspektoriuj koda paliekam.
    public static int Money;
    public int startMoney = 400;
    public static int Lives;
    public int startLives = 20;
    public static int Rounds;

    // BUTINA nusirodyt starte, kitaip neveiks!!!! Yra ir kitu analogisku situaciju kituose scriptuose.
    void Start()
    {
        Money = startMoney;
        Lives = startLives;
        Rounds = 0;
    }


}
