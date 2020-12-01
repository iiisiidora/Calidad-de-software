using System;
using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitPruebas2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]

        public void AgregarProductoCategoriaObjeto() //tambien se prueba el agregar categoria por objeto
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado1 = 1;
            int resultadoObtenido1 = 0;

            resultadoObtenido1 = auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            resultadoObtenido = auxPro.AgregarProducto(prod);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            Assert.AreEqual(resultadoEsperado1, resultadoObtenido1);

        }

        [TestMethod]
        public void AgregarProductoParametros() //no pude agregar cat por parametros, no sabia como llamarla dsps 
        {
            AuxProducto auxPro = new AuxProducto();
            Categoria cate = new Categoria();
            AuxCategoria auxCate = new AuxCategoria();

            int resultadoEsperado1 = 1;
            int resultadoObtenido1 = 0;



            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muye bueno";

            resultadoObtenido1 = auxCate.Agregar(cate);

            var idProducto = 1;
            var nombre = "Nose";
            var precio = 100;
            var stock = 5;
            var cat = cate;
            var estado = true;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            resultadoObtenido = auxPro.AgregarProducto(idProducto, nombre, estado, cat, precio, stock);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            Assert.AreEqual(resultadoEsperado1, resultadoObtenido1);
        }

        [TestMethod]
        public void DardeBajaProductoExistente()
        {
            //se agrega categoria y producto
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            resultadoObtenido = auxPro.DardeBaja(1);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void DardeBajaProductoNoExistente()
        {
            //se agrega categoria y producto
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            resultadoObtenido = auxPro.DardeBaja(2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        [TestMethod]
        public void TestActualizarStock()
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 3;
            cate.Nombre = "Shampoooo";
            cate.Descripcion = "Muy buenardo";

            auxCate.Agregar(cate);

            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            int resultadoEsperado = 10;
            int resultadoObtenido = 0;

            var idProducto = 1;
            var cantidadAgregar = 5;

            //act
            resultadoObtenido = auxPro.ActualizarStock(idProducto, cantidadAgregar);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        [TestMethod]
        public void TestModificarProducto() //Solo tiene metodo por parametros
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 3;
            cate.Nombre = "Shampoooo";
            cate.Descripcion = "Muy buenardo";

            auxCate.Agregar(cate);

            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            var idProducto = 1;
            var nombre = "Producto33";
            var cat = cate;
            var precio = 200;
            var stock = 3;

            //act
            resultadoObtenido = auxPro.Modificar(idProducto, nombre, cat, precio, stock);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
