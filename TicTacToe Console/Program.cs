using System;

public class Program
{
	public static void Main()
	{
		string[,] gameBoard = new string[3, 3];
		var oPoints = 0;
		var xPoints = 0;
		var turn = 0;
		bool xTurn = true;

		PopulateBoard(gameBoard);
		DrawBoard(gameBoard);
		while (true) // main loop
		{
			gameBoard = PlayerInput(gameBoard, xTurn);
			Console.Clear();
			DrawBoard(gameBoard);
			turn++;
			if (checkResult(gameBoard))
			{
				string winner;
				if (xTurn) { winner = "X"; xPoints++; } else { winner = "O"; oPoints++; }
				Console.WriteLine(winner + " has won the game! Congratulations!");
				break;
			}
            else
            {
				if (turn == 9) { 
					Console.WriteLine("It's a draw!");
					break;
				}
            }
			xTurn = !xTurn;

		}
	}

	public static bool checkResult(string[,] gameBoard)
	{
		if (gameBoard[0, 0] == gameBoard[0, 1] && gameBoard[0, 0] == gameBoard[0, 2] && gameBoard[0, 0] != ".")
		{
			return true;
		}
		else if (gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1, 0] == gameBoard[1, 2] && gameBoard[1, 0] != ".")
		{
			return true;
		}
		else if (gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 0] == gameBoard[2, 2] && gameBoard[2, 0] != ".")
		{
			return true;
		}
		else if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[2, 2] == gameBoard[1, 1] && gameBoard[0, 0] != ".")
		{
			return true;
		}
		else if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[2, 0] == gameBoard[1, 1] && gameBoard[0, 2] != ".")
		{
			return true;
		}
		else if (gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[2, 0] == gameBoard[1, 0] && gameBoard[0, 0] != ".")
		{
			return true;
		}
		else if (gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[2, 1] == gameBoard[1, 1] && gameBoard[0, 1] != ".")
		{
			return true;
		}
		else if (gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[2, 2] == gameBoard[1, 2] && gameBoard[0, 2] != ".")
		{
			return true;
		}
		return false;
	}

	public static void DrawBoard(string[,] gameBoard)
	{
		for (int i = 0; i <= 2; i++)
		{
			for (int j = 0; j <= 2; j++)
			{
				Console.Write(gameBoard[i, j]);
			}
			Console.WriteLine();
		}
	}
	public static string[,] PopulateBoard(string[,] gameBoard)
	{
		for (int i = 0; i <= 2; i++)
		{
			for (int j = 0; j <= 2; j++)
			{
				gameBoard[i, j] = ".";
			}
		}
		return gameBoard;
	}
	public static string[,] PlayerInput(string[,] gameBoard, bool xTurn)
	{
		string playerTurn = "";
		if (xTurn)
		{
			playerTurn = "X";
		}
		else { playerTurn = "O"; }
		string input = Console.ReadLine();
		if (input == "7" && gameBoard[0, 0] == ".")
		{
			gameBoard[0, 0] = playerTurn;
		}
		else if (input == "8" && gameBoard[0, 1] == ".")
		{
			gameBoard[0, 1] = playerTurn;
		}
		else if (input == "9" && gameBoard[0, 2] == ".")
		{
			gameBoard[0, 2] = playerTurn;
		}
		else if (input == "4" && gameBoard[1, 0] == ".")
		{
			gameBoard[1, 0] = playerTurn;
		}
		else if (input == "5" && gameBoard[1, 1] == ".")
		{
			gameBoard[1, 1] = playerTurn;
		}
		else if (input == "6" && gameBoard[1, 2] == ".")
		{
			gameBoard[1, 2] = playerTurn;
		}
		else if (input == "1" && gameBoard[2, 0] == ".")
		{
			gameBoard[2, 0] = playerTurn;
		}
		else if (input == "2" && gameBoard[2, 1] == ".")
		{
			gameBoard[2, 1] = playerTurn;
		}
		else if (input == "3" && gameBoard[2, 2] == ".")
		{
			gameBoard[2, 2] = playerTurn;
		}
		else
		{
			Console.WriteLine("Wrong input.");
			PlayerInput(gameBoard, xTurn);
		}
		return gameBoard;
	}
}
