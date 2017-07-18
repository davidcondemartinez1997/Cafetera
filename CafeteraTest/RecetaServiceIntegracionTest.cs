using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Cafetera;

namespace CafeteraTest
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        [TestMethod]
        public void TestCreate()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            IRecetaService sut = container.Resolve<IRecetaService>();
            Receta receta = new Receta();
            receta.Nombre = "Arroz negro";
            int peso = 100;
            receta.Peso = peso;
            Receta resultado = sut.Create(receta);
            Assert.AreEqual(2 * peso, resultado.Peso);
        }
    }
}
