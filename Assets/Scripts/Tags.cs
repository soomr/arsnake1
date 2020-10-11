using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags
{
    // Start is called before the first frame update
        public static string WAll = "Wall";
        public static string FRUIT = "Fruit";
        public static string BOMB = "Bomb";
        public static string TAIL = "TAIL-";
}

    // Update is called once per frame
    public class Metrics{
    	public static float NODE = .01f;
    }
    public enum PlayerDirection {
    	LEFT = 0,
    	UP = 1,
    	RIGHT = 2,
    	DOWN = 3,
    	COUNT = 4
    }

