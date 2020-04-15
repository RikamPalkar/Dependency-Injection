using DataAccess;
using DataAccess.Interfaces;
using DataAccProductDetailsess;
using System;
using Unity;

namespace Presentation
{
    class ProductPresentation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 layered architecture");
            UnityContainer container = new UnityContainer();
            container.RegisterType<IProductDetails, ProductDetails>();

            ProductDataAccess prodDetails = container.Resolve<ProductDataAccess>();
            prodDetails.PrintProductDetails();
            Console.WriteLine();
            prodDetails.PrintProductDetailsWithPropDI();
            Console.WriteLine();
            prodDetails.PrintProductDetailsWithMethodDI();
            Console.ReadLine();
        }
    }
}
