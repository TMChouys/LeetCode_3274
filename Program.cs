using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_3274
{
    internal class Program
    {
        // 主程式進入點
        static void Main(string[] args)
        {
            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換、字串連接運算子
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程
            //知識點：Ch5 選擇控制項與條件敘述，if/else 二選一條件敘述

            Console.WriteLine("Enter the Coordinates1:"); //輸出提示使用者輸入棋盤座標1
            string str1 = Console.ReadLine(); //輸入棋盤座標，並存入字串資料型別變數 str1初值

            Console.WriteLine("Enter the Coordinates2:"); //輸出提示使用者輸入棋盤座標2
            string str2 = Console.ReadLine(); //輸入棋盤座標，並存入字串資料型別變數 str2初值

            Console.WriteLine("Are the colors of " + str1 + " and " + str2 + " the same?"); //輸出LeetCode 3274的問題
            //輸出棋盤格子參考圖
            Console.WriteLine("8 ■□■□■□■□\r\n7 □■□■□■□■\r\n6 ■□■□■□■□\r\n5 □■□■□■□■\r\n4 ■□■□■□■□\r\n3 □■□■□■□■\r\n2 ■□■□■□■□\r\n1 □■□■□■□■\r\n a b c d e f g h");

            //if/else 二選一條件敘述
            if (CheckTwoChessboards(str1, str2)) //呼叫區域函數 CheckTwoChessboards，並傳入引數 str1, str2 兩個棋盤座標，判斷是否為相同顏色
            {
                Console.WriteLine("Yes, they are the same."); //輸出結果是相同顏色
            }
            else
            {
                Console.WriteLine("No, they are different."); //輸出結果不是相同顏色
            }

            Console.Read(); //等待使用者按下任意鍵後結束程式


            //區域函數 CheckTwoChessboards，傳入引數是兩個棋盤座標字串，回傳值是布林值(true或false) 檢查兩個棋盤格子是否為相同顏色
            bool CheckTwoChessboards(string coordinate1, string coordinate2)
            {
                //這是使用XOR運算子的寫法
                //return !SquareIsWhite(coordinate1)^SquareIsWhite(coordinate2);

                //這是使用巢狀if/else條件敘述的寫法
                //上次寫過SquareIsWhite函數，作用是判斷傳入的棋盤座標是白色還是黑色，黑色為false，白色為true
                if (SquareIsWhite(coordinate1)) //呼叫全域函數SquareIsWhite，如果座標1是白色true
                {
                    if (SquareIsWhite(coordinate2)) //再次呼叫全域函數SquareIsWhite，如果座標2是白色true
                    {
                        return true; //兩個座標都是白色，回傳true
                    }
                    else
                    {
                        return false; //座標1是白色，座標2不是白色，回傳false
                    }
                }
                else //else的意思就是上面條件不成立，所以座標1不是白色，那就是黑色
                {
                    if (!SquareIsWhite(coordinate2)) //再次呼叫全域函數SquareIsWhite，SquareIsWhite回傳座標2是不是白色，但這裡要找一樣的顏色，這次要找黑色，所以要加一個否!
                    {
                        return true; //兩個座標都是黑色，回傳true
                    }
                    else
                    {
                        return false; //座標1是黑色，座標2不是黑色，回傳false
                    }
                }
            }
        }

        /*
        LeetCode 3274. Check if Two Chessboard Squares Have the Same Color

        You are given two strings, coordinate1 and coordinate2, representing the coordinates of a square on an 8 x 8 chessboard.
        Below is the chessboard for reference.

        8■□■□■□■□
        7□■□■□■□■
        6■□■□■□■□
        5□■□■□■□■
        4■□■□■□■□
        3□■□■□■□■
        2■□■□■□■□
        1□■□■□■□■
          a b c d e f g h 

        Return true if these two squares have the same color and false otherwise.
        The coordinate will always represent a valid chessboard square.The coordinate will always have the letter first(indicating its column), and the number second(indicating its row).

        Example 1:
        Input: coordinate1 = "a1", coordinate2 = "c3"
        Output: true
        Explanation:
        Both squares are black.

        Example 2:
        Input: coordinate1 = "a1", coordinate2 = "h3"
        Output: false
        Explanation:
        Square "a1" is black and "h3" is white.

        Constraints:
        coordinate1.length == coordinate2.length == 2
        'a' <= coordinate1[0], coordinate2[0] <= 'h'
        '1' <= coordinate1[1], coordinate2[1] <= '8'


        LeetCode 3274. 判斷兩個棋盤格顏色是否相同

        給定兩個字串，座標1和座標2，分別表示8 x 8棋盤格上一個方格的座標。
        以下是棋盤格供參考。

        8■□■□■□■□
        7□■□■□■□■
        6■□■□■□■□
        5□■□■□■□■
        4■□■□■□■□
        3□■□■□■□■
        2■□■□■□■□
        1□■□■□■□■
          a b c d e f g h

        如果這兩個方格顏色相同，則傳回 true，否則傳回 false。
        座標始終表示一個有效的棋盤格。座標始終以字母（表示其列）為首，數字（表示其行）為次。

        範例 1：
        輸入：coordinate1 = "a1", coordinate2 = "c3"
        輸出：true
        解釋：
        兩個方塊都是黑色。

        範例 2：
        輸入：coordinate1 = "a1", coordinate2 = "h3"
        輸出：false
        解釋：
        方塊「a1」為黑色，「h3」為白色。

        約束：
        coordinate1.length == coordinate2.length == 2
        'a' <= coordinate1[0], coordinate2[0] <= 'h'
        '1' <= coordinate1[1], coordinate2[1] <= '8'

        */



        // 解題思路
        // LeetCode 1812寫過判斷棋盤格子顏色的函數SquareIsWhite，這次可以重複使用這個函數來判斷兩個棋盤格子是否為相同顏色

        // 這是LeetCode 1812題的解答
        // 全域函數 SquareIsWhite，傳入引數是棋盤座標字串，回傳值是布林值(true或false) 檢查使否為白色格子
        static bool SquareIsWhite(string coordinates) //記得修飾子要改為跟主程式一樣的static
        {
            //使用switch條件敘述來判斷傳入的棋盤座標是白色還是黑色,暴力法列出所有黑色格子座標
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
                    return false; //不是，是黑色格子

                default:
                    return true; //是白色格子
            }
        }
        //結束簽名TMChouys
    }
}
