using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardClass
{
    public class Board : MonoBehaviour
    {

        //public Square[] squares;
        public static Square[] squares = new Square[40];

        // Use this for initialization
        void Start()
        {
            //Square newSquare0 = gameObject.AddComponent<Square>();
            
            Square newSquare0 = new Square("START");
            Square newSquare1 = new Square("OLD KENT ROAD", 60, 30, 30, 50, 2);
            Square newSquare2 = new Square("COMMUNITY CHEST");
            Square newSquare3 = new Square("WHITECHAPEL ROAD", 60, 30, 30, 50, 4);
            Square newSquare4 = new Square("INCOME TAX", 200);
            Square newSquare5 = new Square("KINGS CROSS STATION", 200, 100, 25);
            Square newSquare6 = new Square("THE ANGEL ISLINGTON", 100, 50, 50, 50, 6);
            Square newSquare7 = new Square("CHANCE");
            Square newSquare8 = new Square("EUSTON ROAD", 100, 50, 50, 50, 6);
            Square newSquare9 = new Square("PENTONVILLE ROAD", 120, 50, 50, 60, 8);
            Square newSquare10 = new Square("JUST VISITING");
            Square newSquare11 = new Square("PALL MALL", 140, 100, 100, 70, 10);
            Square newSquare12 = new Square("ELECTRIC COMPANY", 150, 75, 0);
            Square newSquare13 = new Square("WHITEHALL", 140, 100, 100, 70, 10);
            Square newSquare14 = new Square("NORTHUMBERLAND AVENUE", 160, 100, 100, 80, 12);
            Square newSquare15 = new Square("MARYLEBONE STATION", 200, 100, 25);
            Square newSquare16 = new Square("BOW STREET", 180, 100, 100, 90, 14);
            Square newSquare17 = new Square("COMMUNITY CHEST");
            Square newSquare18 = new Square("MARLBOROUGH STREET", 180, 100, 100, 90, 14);
            Square newSquare19 = new Square("VINE STREET", 200, 100, 100, 100, 16);
            Square newSquare20 = new Square("FREE PARKING");
            Square newSquare21 = new Square("STRAND", 220, 150, 150, 110, 18);
            Square newSquare22 = new Square("CHANCE");
            Square newSquare23 = new Square("FLEET STREET", 220, 150, 150, 110, 18);
            Square newSquare24 = new Square("TRAFALGAR SQUARE", 240, 150, 150, 120, 20);
            Square newSquare25 = new Square("FENCHURCH ST. STATION", 200, 100, 25);
            Square newSquare26 = new Square("LECHESTER SQUARE", 260, 150, 150, 150, 22);
            Square newSquare27 = new Square("COVENTRY STREET", 260, 150, 150, 150, 22);
            Square newSquare28 = new Square("WATER WORKS", 150, 75, 0);
            Square newSquare29 = new Square("PICCADILLY", 280, 140, 140, 150, 22);
            Square newSquare30 = new Square("GO TO JAIL");
            Square newSquare31 = new Square("REGENT STREET", 300, 150, 150, 200, 26);
            Square newSquare32 = new Square("OXFORD STREET", 300, 150, 150, 200, 26);
            Square newSquare33 = new Square("COMMUNITY CHEST");
            Square newSquare34 = new Square("BOND STREET", 320, 160, 160, 200, 28);
            Square newSquare35 = new Square("LIVERPOOL ST. STATION", 200, 100, 25);
            Square newSquare36 = new Square("CHANCE");
            Square newSquare37 = new Square("PARK LANE", 350, 200, 200, 175, 35);
            Square newSquare38 = new Square("SUPER TAX", 100);
            Square newSquare39 = new Square("MAYFAIR", 400, 200, 200, 200, 50);          
            squares[0] = newSquare0;           
            squares[1] = newSquare1;
            squares[2] = newSquare2;
            squares[3] = newSquare3;
            squares[4] = newSquare4;
            squares[5] = newSquare5;
            squares[6] = newSquare6;
            squares[7] = newSquare7;
            squares[8] = newSquare8;
            squares[9] = newSquare9;
            squares[10] = newSquare10;
            squares[11] = newSquare11;
            squares[12] = newSquare12;
            squares[13] = newSquare13;
            squares[14] = newSquare14;
            squares[15] = newSquare15;
            squares[16] = newSquare16;
            squares[17] = newSquare17;
            squares[18] = newSquare18;
            squares[19] = newSquare19;
            squares[20] = newSquare20;
            squares[21] = newSquare21;
            squares[22] = newSquare22;
            squares[23] = newSquare23;
            squares[24] = newSquare24;
            squares[25] = newSquare25;
            squares[26] = newSquare26;
            squares[27] = newSquare27;
            squares[28] = newSquare28;
            squares[29] = newSquare29;
            squares[30] = newSquare30;
            squares[31] = newSquare31;
            squares[32] = newSquare32;
            squares[33] = newSquare33;
            squares[34] = newSquare34;
            squares[35] = newSquare35;
            squares[36] = newSquare36;
            squares[37] = newSquare37;
            squares[38] = newSquare38;
            squares[39] = newSquare39;
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
