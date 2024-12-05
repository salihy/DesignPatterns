using DesignPatterns_Demo.Patterns;
using DesignPatterns_Demo.Patterns.Adaptor;
using DesignPatterns_Demo.Patterns.Bridge;
using DesignPatterns_Demo.Patterns.Composite;
using DesignPatterns_Demo.Patterns.Decorator;
using DesignPatterns_Demo.Patterns.FlyWeight;
using DesignPatterns_Demo.Patterns.Proxy;

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

            #region composite

            Officer binbasi = new Officer();
            Officer yuzbasi = new Officer();
            Officer yuzbasi2 = new Officer();

            OfficerCS binbasiCs = new OfficerCS();
            OfficerCS yuzbasiCs = new OfficerCS();
            OfficerCS yuzbasiCs2 = new OfficerCS();

            Soldier s1 = new Soldier();
            Soldier s2 = new Soldier();
            Soldier s3 = new Soldier();
            Soldier s4 = new Soldier();
            Soldier s5 = new Soldier();
            Soldier s6 = new Soldier();

            await binbasi.Add(yuzbasi);
            await binbasi.Add(yuzbasi2);
            await yuzbasi.Add(s1);
            await yuzbasi.Add(s2);
            await yuzbasi.Add(s3);
            await yuzbasi2.Add(s4);
            await yuzbasi2.Add(s5);
            await yuzbasi2.Add(s6);

            binbasiCs.Add(yuzbasiCs);
            binbasiCs.Add(yuzbasiCs2);
            yuzbasiCs.Add(s1);
            yuzbasiCs.Add(s2);
            yuzbasiCs.Add(s3);
            yuzbasiCs2.Add(s4);
            yuzbasiCs2.Add(s5);
            yuzbasiCs2.Add(s6);


            await binbasi.execute();

            await binbasiCs.execute();


            #endregion

            #region Decorator

            INotification notif = new BaseNotification();
            INotification smsNotif = new SmsNotification(notif);
            INotification tcellSmsNotif = new TCellSmsNotification(smsNotif);

            await tcellSmsNotif.notify();

            #endregion

            #region flyweight

            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            Color c5 = new Color();

            Bike b = new Bike();
            Car c = new Car();

            b.AddColor(c1);
            b.AddColor(c2);
            b.AddColor(c3);
            b.AddColor(c4);
            b.AddColor(c5);

            c.AddColor(c1);
            c.AddColor(c2);
            c.AddColor(c3);
            c.AddColor(c4);
            c.AddColor(c5);


            #endregion

            #region proxy

            IPayment paymentOp = new PaymentOperation();
            IPayment paymentProxy = new PaymentGateway(paymentOp);

            paymentProxy.pay(12.0);

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
