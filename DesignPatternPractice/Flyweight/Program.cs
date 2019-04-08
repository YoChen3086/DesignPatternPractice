using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            Flyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);

            Console.WriteLine();

            WebSiteFactory webSiteFactory = new WebSiteFactory();

            WebSite wx = webSiteFactory.GetWebSiteCategory("產品展示");
            wx.Use();

            WebSite wy = webSiteFactory.GetWebSiteCategory("產品展示");
            wy.Use();

            WebSite wz = webSiteFactory.GetWebSiteCategory("產品展示");
            wz.Use();

            WebSite wl = webSiteFactory.GetWebSiteCategory("部落格");
            wl.Use();

            WebSite wm = webSiteFactory.GetWebSiteCategory("部落格");
            wm.Use();

            WebSite wn = webSiteFactory.GetWebSiteCategory("部落格");
            wn.Use();

            Console.WriteLine($"網站分類總數為: {webSiteFactory.GetWebStieCount()}");

            Console.ReadLine();
        }
    }
}
