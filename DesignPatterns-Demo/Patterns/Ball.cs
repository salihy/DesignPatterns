using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns
{
    //Abstract Factory
    public interface Ball
    {
        Task ToString();
        Task<Ball> Clone();
    }

    public class FootBall : Ball
    {
        public int _a { get; set; }
        public string _b { get; set; }
        public bool _c { get; set; }

        public FootBall(int a, string b, bool c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        //prototype
        public async Task<Ball> Clone()
        {
            return new FootBall(_a, _b, _c);
        }

        public async Task ToString()
        {
            System.Console.WriteLine("futbol topu!\n");
        }
    }

    public class BasketBall : Ball
    {
        public BasketBall(int a, string b)
        {

        }

        public Task<Ball> Clone()
        {
            throw new NotImplementedException();
        }

        public async Task  ToString()
        {
            System.Console.WriteLine("basketbol topu!\n");
        }
    }

    public abstract class BallFactory
    {
        public abstract Ball CreateBall();
    }

    public class FootBallFactory : BallFactory
    {
        public override Ball CreateBall()
        {
            return new FootBall(1, "asasa", true);
        }
    }

    public class BasketBallFactory : BallFactory
    {
        public override Ball CreateBall()
        {
            return new BasketBall(2, "safdf");
        }
    }


}
