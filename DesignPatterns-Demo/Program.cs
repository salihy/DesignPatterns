using DesignPatterns_Demo.Patterns;
using DesignPatterns_Demo.Patterns.Adaptor;
using DesignPatterns_Demo.Patterns.Bridge;

namespace DesignPatterns_Demo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region singleton
            DatabaseCache dbCache = DatabaseCache.GetInstance();
            await dbCache.AddUserToCache("27566672320", "ahmet");
            #endregion

            #region abstract-factory
            BallFactory ballFactory = null;

            if (args.Length > 0) { 
                ballFactory = new FootBallFactory();
            }
            else
            {
                ballFactory = new BasketBallFactory();
            }
           
            var ball = ballFactory.CreateBall();
            await ball.ToString();
            #endregion

            #region adaptor
            IEncryption encryption = null;

            if (1< 0)
            {
                encryption = new DESEnccryption();
            }
            else if (2 < 0)
            {
                encryption = new RSAEncryption();
            }
            else {
                encryption = new LegacyEncryptionAdaptor();
            }

            var enctxt = await encryption.Encrypt("TEST");
            Console.WriteLine(enctxt);
            var plaintext = await encryption.Decrypt("TEST2");
            Console.WriteLine(plaintext);


            #endregion

            #region bridge

            Shape redBall = new Circle(10, 20, 30, new RedPaint());
            Shape greenBall = new Circle(10, 20, 30, new GreenPaint());

            await redBall.draw();
            await greenBall.draw();

            Shape rect1 = new Rectangle(10, 20, 30, 30, new GreenPaint());
            await rect1.draw();


            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
