using System;
using EditorTexto;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class FormularioTests
    {
        [Test]
        public void buscar_SiEncontro_RetornaNumeroMayorA0()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtTexto.Text = "hola hola hola";
            editorTest.txtBuscar.Text = "hola";
            //int cont = editorTest.buscar();
            //System.Windows.Forms.MessageBox.Show(cont.ToString());

            //Assert
            //Assert.AreNotEqual(0, cont);
            //Assert.That(cont, Is.True);
            Assert.That(editorTest.buscar() > 0);

        }

        [Test]
        public void buscar_NoEncontro_Retorna0()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtTexto.Text = "ola";
            editorTest.txtBuscar.Text = "hola";
            
            //Assert
            Assert.That(editorTest.buscar() == 0);

        }

/*       [Test]
        public void abrirArchivo_RutaVacia_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Assert
            Assert.That(editorTest.abrirArchivo("") == false);

        }

        [Test]
        public void abrirArchivo_RutaIncorrecta_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Assert
            Assert.That(editorTest.abrirArchivo("C:\\Users\\gabg_\\Desktop\\nuevoArchivo.txt") == false);

        }

        [Test]
        public void abrirArchivo_RutaCorrecta_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            //editorTest.;

            //Assert
            //Assert.That(editorTest.abrirArchivo() == false);

        }
*/
        [Test]
        public void regresar_Hay1ElemetoEnHistorialDeTexto_RetornaTrue()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtTexto.Text = "hola hola hola";
            editorTest.historialTexto.Add(editorTest.txtTexto.Text);
            editorTest.HistorialFuentes.Add(editorTest.txtTexto.Font);

            //Assert
            Assert.That(editorTest.regresar() == true);

        }

        [Test]
        public void regresar_HayMasDe1ElemetoEnHistorialDeTexto_RetornaTrue()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtTexto.Text = "hola hola hola";
            editorTest.historialTexto.Add(editorTest.txtTexto.Text);
            editorTest.HistorialFuentes.Add(editorTest.txtTexto.Font);
            editorTest.txtTexto.Text = "hola 2 hola 2 hola 2";
            editorTest.historialTexto.Add(editorTest.txtTexto.Text);
            editorTest.HistorialFuentes.Add(editorTest.txtTexto.Font);

            //Assert
            Assert.That(editorTest.regresar() == true);

        }

        [Test]
        public void regresar_NoHayElemetosEnHistorialDeTexto_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            

            //Assert
            Assert.That(editorTest.regresar() == false);

        }

        [Test]
        public void guardarArchivo_HayAlgoQueGuardar_RetornaTrue()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtTexto.Text = "hola hola hola";
            editorTest.txtTexto.Enabled = true;
            //A continuacion tiene que poner la ruta de su escritorio personal.
            editorTest.ruta = "\\Users\\gabg_\\Escritorio";

            //Assert
            Assert.That(editorTest.guardarArchivo() == true);

        }

        [Test]
        public void guardarArchivo_NoHayNadaQueGuardar_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            
            //Assert
            Assert.That(editorTest.guardarArchivo() == false);

        }

        [Test]
        public void cargarFuentes_SiHayElementosEnLaLista_RetornaTrue()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act

            //Assert
            Assert.That(editorTest.cargarFuentes() == true);

        }

        /*
                [Test]
                public void cargarFuentes_NoHayElementosEnLaLista_RetornaFalse()
                {
                    //Arrange
                    frmEditor editorTest = new frmEditor();

                    //Act
                    //Borrar las fuentes del sistema en windows :)

                    //Assert
                    Assert.That(editorTest.cargarFuentes() == false);

                }
        */
        [Test]
        public void reemplazar_HayTextoABuscarYHayTextoReemplazo_RetornaTrue()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtBuscar.Text = "Hola";
            editorTest.txtReemplazo.Text = "Adios";

            //Assert
            Assert.That(editorTest.reemplazar() == true);

        }

        [Test]
        public void reemplazar_NoHayTextoABuscarYNoHayTextoReemplazo_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            

            //Assert
            Assert.That(editorTest.reemplazar() == false);

        }

        [Test]
        public void reemplazar_NoHayTextoABuscarYHayTextoReemplazo_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtReemplazo.Text = "Adios";

            //Assert
            Assert.That(editorTest.reemplazar() == false);

        }

        [Test]
        public void reemplazar_HayTextoABuscarYNoHayTextoReemplazo_RetornaFalse()
        {
            //Arrange
            frmEditor editorTest = new frmEditor();

            //Act
            editorTest.txtBuscar.Text = "Hola";

            //Assert
            Assert.That(editorTest.reemplazar() == false);

        }

    }
}

//          Terminé :)               (Gus Rules)
