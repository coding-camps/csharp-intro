using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    // 委托的案例1：古老的方法

    // 委托的官方定义
    // 委托是一种类型安全的指针，它封装了对方法的引用，
    // 强制要求方法签名和委托定义一致，避免了不安全的类型转换。
    // 民间看法：方法-> 一道菜，委托 -> 菜单

    // 1. 声明委托
    delegate int MathOprDelegate(int num1, int num2);
    internal class Tech01
    {
        // 2. 写方法
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // 3. 定义委托
        static MathOprDelegate mathOprDelegate;
        public void useDelegate()
        {
            // 4. 绑定委托
            mathOprDelegate = Add;

            // 5. 使用委托
            if (mathOprDelegate == null)
            {
                Console.WriteLine("委托没有绑定");
            }
            else
            {
                int result = mathOprDelegate(1, 2);
                Console.WriteLine($"result = {result}");
            }
        }

        // 新的Delegate机制
        // Action可以传递参数0-16个，无返回值
        // Func可以传递参数0-16个，有返回值
        // 可结合Lambda goesto 语法糖，用户创建“匿名方法”的简洁语法
        // 方便创建Action和Func使用

        // 新方式之定义委托
        Action<int, int> AddAction;
        public void useNewDelegateV1()
        {
            // 不使用上面的 step 1 和 2

            AddAction = (a, b) =>
            {
                Console.WriteLine($"新方式Action示例1：{a} + {b} = {a + b}");
            };
            AddAction(1, 3);
        }
        public void useNewDelegateV2()
        {
            Action<int, int> AddAction = (a, b) => Console.WriteLine($"新方式Action示例2：{a} + {b} = {a + b}");
            AddAction(2, 3);

        }
        public void useNewDelegateFunc()
        {
            //Func<int, int, int> addFunc = (a, b) =>
            //{
            //    return a + b;
            //};
            Func<int, int, int> addFunc = (a, b) => a + b;
            int p1 = 1, p2 = 2;
            int result = addFunc(p1, p2);
            Console.WriteLine($"新方式Func示例：{p1} + {p2} = {p1 * p2}");
        }

        public void testMockDownload()
        {
            MockDownloadThread mockDownload = new MockDownloadThread();
            mockDownload.download("http://www.xxx.com", (isSuccess) =>
            {
                var result = isSuccess ? "下载成功~！" : "下载失败~！";
                Console.WriteLine(result);
            });
        }
    }

    public class MockDownloadThread
    {
        public void download(string url, Action<bool> callback)
        {
            Console.WriteLine();
            Console.Write("模拟正在下载");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            // 根据下载成功或失败的具体情况，以下两条语句只使用一个
            // 模拟下载成功
            callback(true);
            //// 模拟下载失败
            //callback(false);
        }

    }
}
