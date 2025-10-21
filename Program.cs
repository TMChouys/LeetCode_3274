namespace LeetCode_3274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換、字串連接運算子
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程
            //知識點：Ch5 選擇控制項與條件敘述，if/else 二選一條件敘述

            Console.WriteLine("Enter the Coordinates1:"); //輸出提示使用者輸入棋盤座標
            string str1 = Console.ReadLine(); //輸入棋盤座標，並存入字串資料型別變數 str1初值

            Console.WriteLine("Enter the Coordinates2:"); //輸出提示使用者輸入棋盤座標
            string str2 = Console.ReadLine(); //輸入棋盤座標，並存入字串資料型別變數 str2初值

            Console.WriteLine("Are the colors of " + str1 + " and " + str2 + " the same?"); //輸出提示使用者輸入棋盤座標
            //輸出棋盤格子參考圖
            Console.WriteLine("8 ■□■□■□■□\r\n7 □■□■□■□■\r\n6 ■□■□■□■□\r\n5 □■□■□■□■\r\n4 ■□■□■□■□\r\n3 □■□■□■□■\r\n2 ■□■□■□■□\r\n1 □■□■□■□■\r\n a b c d e f g h");

            //if/else 二選一條件敘述
            if (CheckTwoChessboards(str1, str2)) //呼叫區域函數 SquareIsWhite，並傳入參數 str1 棋盤座標，判斷是否為白色格子
            {
                Console.WriteLine("Yes, they are the same."); //輸出結果為白色格子
            }
            else
            {
                Console.WriteLine("No, they are different."); //輸出結果為黑色格子
            }

            Console.Read(); //等待使用者按下任意鍵後結束程式


            bool CheckTwoChessboards(string coordinate1, string coordinate2)
            {
                //return !SquareIsWhite(coordinate1)^SquareIsWhite(coordinate2);

                if (SquareIsWhite(coordinate1))
                {
                    if (SquareIsWhite(coordinate2))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (!SquareIsWhite(coordinate2))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        //全域變數
        static bool SquareIsWhite(string coordinates)
        {
            switch (coordinates)
            {
                case "a1":
                case "a3":
                case "a5":
                case "a7":

                case "b2":
                case "b4":
                case "b6":
                case "b8":

                case "c1":
                case "c3":
                case "c5":
                case "c7":

                case "d2":
                case "d4":
                case "d6":
                case "d8":

                case "e1":
                case "e3":
                case "e5":
                case "e7":

                case "f2":
                case "f4":
                case "f6":
                case "f8":

                case "g1":
                case "g3":
                case "g5":
                case "g7":

                case "h2":
                case "h4":
                case "h6":
                case "h8":
                    return false;

                default:
                    return true;
            }
        }
    }
}
