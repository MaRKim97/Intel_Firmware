using System;
using static System.Console; //include와 비슷한 느낌 하지만 훨씬 더 파워풀하다
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Test01_Hello
{
    static class myLib
    {
        public static string GetToken(string str, int n, char ch)  //함수마다 일일이 public을 붙여줘야 함
        {                                            //인자 샘플: (str): "1 2 3" "1,2,3"  (n)번째  (ch)',' ' '
            return str.Split(ch)[n];
        }

        internal class Program //주로 메인만 들어가 있는 클래스
        {                      //워킹 클래스를 따로 만들어서 작동시킨다
            static void Main(string[] args)
            {
                //Program pgr = new Program(); //클래스라는 틀에서 new라는 명령어를 통해 객체를 만들어야 한다
                //pgr.func();//객체의 멤버 함수로 넣어줘야 한다
                Test01 sub = new Test01();
                sub.MainFunc();
                

                
            }
            //int func() { return 1; }
        }
    }
    class Point
    {
        int x, y;
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
       public double Dist(Point p1)
       {
            int d1 = p1.x - x;
            int d2 = p1.y - y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
       }
        public static double operator - (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
        //곱하기 연산자를 통해 두 점이 이루는 사각형의 면적을 구하라
        public static int operator * (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Abs(d1 * d2);
        }
    }

    class Test01  //main 클래스가 된다
    {
        public void Func1()
        {
            Point p = new Point(10, 20);
            Point p1 = new Point(30, 40);
            WriteLine($"두 점 P1(10, 20)와 P2(30, 40)의 거리는 DIST({p.Dist(p1):F2})입니다"); //:F2->출력 형태 조절 소수점 이하 두자리만 나오도록
            WriteLine($"두 점 P1(10, 20)와 P2(30, 40)의 거리는 p-p1({(p1-p):F2})입니다");
            WriteLine($"두 점 P1(10, 20)와 P2(30, 40)가 만드는 사각형의 넓이는 {(p*p1)}");
            string s1 = "Good";
            string s2 = "morning";
            string s3 = s1 + s2;
        }
        public void MainFunc()
        {
            //Func1(); //point test
            //return;

            int i = 10, j = 20;
            double d = 1.5, e = 2.5;
            object o = i + 1;
            var v = i * 10; //컴파일러 내부에서 int로 자동 간주->권장하진 않는 자료타입
                            //변수들을 먼저 선언한 후 사용시 디버깅이 편리해짐
            Console.WriteLine("Hello world({0}, {1}, {5})\nMain Function({2},{3},{4})", i, j, d, e, o, v);
            //printf 역할,{0}: 변환자, 가운데 0: 순서(0:i,1:j)
            Console.WriteLine($"Hello world({j})\nMain Function({i})"); //보관문자열 따옴표 앞에 $를 붙여서 인용 가능하게 만듦
            o = d + 0.5; //object: int나 double 등등 상관없이 필요한 자료 타입을 담을 수 있다
            //v = d * 10; //int로 자동 간주했는데 double을 넣으려 하니 오류 발생
            Console.WriteLine("Hello world({0}, {1})\nMain Function({2},{3},{4})", i, j, d, e, o);
            //WriteLine($"this is double d: {d}, e: {e}"); //실수나 정수나 같은 포맷으로 써도 문제없음
            //using static System.Console;을 위에 언급했기 때문에 Console을 붙이지 않아도 된다
            WriteLine("i: {0}, j: {1}, d: {2}, e: {3}, o: {4}", i, j, d, e, o);
            WriteLine($"i: {sizeof(int)} d: {sizeof(double)}"); //C#에서 제공하는 sizeof의 경우 자료 타입으로 계산해야 함
            //j; {(sizeof(object)}: object의 경우 sizeof로 할 수 없음->정해진 사이즈가 없는 타입이기 때문에
            //myLib my = new myLib();


            int[] arr = new int[i]; //int[]: 배열 타입의 클래스다(int형 변수들의 집합이 아님!)
            for(int ii = 0; ii<10; ii++) arr[ii] = ii;
            
            while (true)
            {
                try //내부에서 오류가 발생할 경우 catch로 넘어간 후에 함수를 종료함->main에서 함수를 끝냄
                {   //예외처리라고 부른다
                    WriteLine("정수 2개를 입력하세요");
                    string str = Console.ReadLine(); //ReadLine: 문자열 전체를 입력받는 함수
                    i = int.Parse(str.Split(' ')[0]);
                    i = int.Parse(myLib.GetToken(str, 0, ' '));
                    j = int.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 정수: ({i}, {j})");

                    WriteLine("실수 2개를 입력하세요");
                    str = ReadLine();
                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 실수: ({d}, {e})");
                    //string str = "STX" + i.ToString() + "ETX";
                    //string stt = $"STX{i,5}ETX";
                    //WriteLine($"{str}\n{stt}");
                }
                catch (Exception ex)   //ex: 에러를 표시해주는 구조체 (이름은 수정 가능)
                {
                    WriteLine(ex.Message); //오류가 난 이유를 알려준다
                }
            }
        }
    }
}
