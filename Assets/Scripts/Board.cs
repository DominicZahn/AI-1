using System.Collections;
using System.Collections.Generic;

public class Board
{
    private const byte EMPTY = 0;
    private const byte PLAYER1 = 1;
    private const byte PLAYER2 = 2;
    private byte[,] board;
    private int length;


    public Board(int length)
    {
        //create board
        this.length = length;
        board = new byte[length, length];
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                board[x, y] = EMPTY;
            }
        }
        //place tokens
        for (int y = 0; y < length; y++)
        {
            setField(0, y, PLAYER1);
            setField(2, y, PLAYER2);
        }
    }

    public bool setField(int x, int y, byte value)
    {
        if (x >= length || y >= length)
        {
            return false;
        }
        board[x, y] = value;
        return true;
    }

    public byte getField(int x, int y)
    {
        return board[x, y];
    }

    public override string ToString()
    {
        string output = "";
        for (int y = 0; y < length; y++)
        {
            output += "|";
            for (int x = 0; x < length; x++)
            {
                output += board[x, y].ToString() + "|";
            }
            output += "\n";
        }
        return output;
    }
}
