using System;
using static System.Console; //include와 비슷한 느낌 하지만 훨씬 더 파워풀하다
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
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

class Test01  //main 클래스가 된다
{
    public void MainFunc()
    {
        var v = 100;
        int i = 10, j = 20;
        double d = 1.5, e = 2.5;
        Object o = i + 1; 
        Console.WriteLine("Hello world({0}, {1})\nMain Function({2},{3},{4})", i, j, d, e, o); //printf 역할,{0}: 변환자, 가운데 0: 순서(0:i,1:j)
        Console.WriteLine($"Hello world({j})\nMain Function({i})"); //보관문자열 따옴표 앞에 $를 붙여서 인용 가능하게 만듦
        o = d + 0.5; //object: int나 double 등등 상관없이 필요한 자료 타입을 담을 수 있다
        Console.WriteLine("Hello world({0}, {1})\nMain Function({2},{3},{4})", i, j, d, e, o);
        //WriteLine($"this is double d: {d}, e: {e}"); //실수나 정수나 같은 포맷으로 써도 문제없음
        //using static System.Console;을 위에 언급했기 때문에 Console을 붙이지 않아도 된다
        while (true)
        {
            try //내부에서 오류가 발생할 경우 catch로 넘어간 후에 함수를 종료함->main에서 함수를 끝냄
            {   //예외처리라고 부른다
                WriteLine("정수 2개를 입력하세요");
                string str = Console.ReadLine(); //ReadLine: 문자열 전체를 입력받는 함수
                i = int.Parse(str.Split(' ')[0]);
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
