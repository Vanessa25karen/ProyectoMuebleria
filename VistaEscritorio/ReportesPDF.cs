using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using AccesoDato;

namespace VistaEscritorio
{
    class ReportesPDF
    {
        BD mbd = new BD();
        public void reporteSalas()
        {

            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Documento PDF|*.pdf";
            DialogResult res = dlgGuardar.ShowDialog();
            if (res == DialogResult.OK)
            {
                string ruta = dlgGuardar.FileName;
                DataTable t = mbd.mostrarSalas();
                FileInfo archivo = new FileInfo(ruta);
                PdfWriter write = new PdfWriter(archivo);
                PdfDocument pdf = new PdfDocument(write);
                Document doc = new Document(pdf, PageSize.LETTER.Rotate());

                //string rutaImagen = @"../../Resources/logo.PNG";
                //Image img = new Image(ImageDataFactory.Create(rutaImagen));
                MemoryStream ms = new MemoryStream();
                System.Drawing.Image imagen = VistaEscritorio.Properties.Resources.logo;
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] foto = ms.ToArray();
                Image img = new Image(ImageDataFactory.Create(foto));
                img.SetWidth(125);
                img.SetHeight(125);
                img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                doc.Add(img);

                // doc.Add(new AreaBreak());
                doc.Add(new Paragraph("REPORTE DE SALAS EN INVENTARIO\n")
                     .SetTextAlignment(TextAlignment.CENTER)
                     .SetFontSize(16f).SetBold());
                doc.Add(new Paragraph("Distribuidoras Romo\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f).SetBold().SetFontColor(fontColor: ColorConstants.RED));
                doc.Add(new Paragraph("Tel: 8754965214\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f));
                doc.Add(new Paragraph("Fecha y hora de reporte \n")
                   .SetTextAlignment(TextAlignment.RIGHT)
                   .SetFontSize(12f));
                doc.Add(new Paragraph(DateTime.Now.ToString())
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12f));


                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                Table tb = new Table(5);
                tb.SetWidth(UnitValue.CreatePercentValue(100f));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Codigo de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Nombre de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Descripcion de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Sala menor")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Precio de Sala")));
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][0].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][1].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][2].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][3].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][4].ToString())));
                }
                tb.AddFooterCell(new Cell(1, 5).SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph("Total de salas en inventario: " + t.Rows.Count.ToString())));
                doc.Add(tb);
                doc.Close();
                Process.Start(ruta);
                //MessageBox.Show("Reporte generado en " + ruta);
            }

        }
        public void reporteSalasMenor()
        {

            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Documento PDF|*.pdf";
            DialogResult res = dlgGuardar.ShowDialog();
            if (res == DialogResult.OK)
            {
                string ruta = dlgGuardar.FileName;
                DataTable t = mbd.mostrarSalasMenores();
                FileInfo archivo = new FileInfo(ruta);
                PdfWriter write = new PdfWriter(archivo);
                PdfDocument pdf = new PdfDocument(write);
                Document doc = new Document(pdf, PageSize.LETTER.Rotate());

                //string rutaImagen = @"../../Resources/logo.PNG";
                //Image img = new Image(ImageDataFactory.Create(rutaImagen));
                MemoryStream ms = new MemoryStream();
                System.Drawing.Image imagen = VistaEscritorio.Properties.Resources.logo;
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] foto = ms.ToArray();
                Image img = new Image(ImageDataFactory.Create(foto));
                img.SetWidth(125);
                img.SetHeight(125);
                img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                doc.Add(img);

                // doc.Add(new AreaBreak());
                doc.Add(new Paragraph("REPORTE DE SALAS MENORES A MIL EN INVENTARIO\n")
                     .SetTextAlignment(TextAlignment.CENTER)
                     .SetFontSize(16f).SetBold());
                doc.Add(new Paragraph("Distribuidoras Romo\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f).SetBold().SetFontColor(fontColor: ColorConstants.RED));
                doc.Add(new Paragraph("Tel: 8754965214\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f));
                doc.Add(new Paragraph("Fecha y hora de reporte \n")
                   .SetTextAlignment(TextAlignment.RIGHT)
                   .SetFontSize(12f));
                doc.Add(new Paragraph(DateTime.Now.ToString())
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12f));


                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                Table tb = new Table(5);
                tb.SetWidth(UnitValue.CreatePercentValue(100f));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Codigo de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Nombre de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Descripcion de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Sala menor")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Precio de Sala")));
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][0].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][1].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][2].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][3].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][4].ToString())));
                }
                tb.AddFooterCell(new Cell(1, 5).SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph("Total de salas menores de $1,000 en inventario: " + t.Rows.Count.ToString())));
                doc.Add(tb);
                doc.Close();
                Process.Start(ruta);
                //MessageBox.Show("Reporte generado en " + ruta);
            }
        }
        public void reporteSalasMayor()
        {

            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Documento PDF|*.pdf";
            DialogResult res = dlgGuardar.ShowDialog();
            if (res == DialogResult.OK)
            {
                string ruta = dlgGuardar.FileName;
                DataTable t = mbd.mostrarSalasMayores();
                FileInfo archivo = new FileInfo(ruta);
                PdfWriter write = new PdfWriter(archivo);
                PdfDocument pdf = new PdfDocument(write);
                Document doc = new Document(pdf, PageSize.LETTER.Rotate());

                //string rutaImagen = @"../../Resources/logo.PNG";
                //Image img = new Image(ImageDataFactory.Create(rutaImagen));
                MemoryStream ms = new MemoryStream();
                System.Drawing.Image imagen = VistaEscritorio.Properties.Resources.logo;
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] foto = ms.ToArray();
                Image img = new Image(ImageDataFactory.Create(foto));
                img.SetWidth(125);
                img.SetHeight(125);
                img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                doc.Add(img);

                // doc.Add(new AreaBreak());
                doc.Add(new Paragraph("REPORTE DE SALAS MAYORES A MIL EN INVENTARIO\n")
                     .SetTextAlignment(TextAlignment.CENTER)
                     .SetFontSize(16f).SetBold());
                doc.Add(new Paragraph("Distribuidoras Romo\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f).SetBold().SetFontColor(fontColor: ColorConstants.RED));
                doc.Add(new Paragraph("Tel: 8754965214\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f));
                doc.Add(new Paragraph("Fecha y hora de reporte \n")
                   .SetTextAlignment(TextAlignment.RIGHT)
                   .SetFontSize(12f));
                doc.Add(new Paragraph(DateTime.Now.ToString())
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12f));


                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                Table tb = new Table(5);
                tb.SetWidth(UnitValue.CreatePercentValue(100f));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Codigo de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Nombre de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Descripcion de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Sala menor")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Precio de Sala")));
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][0].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][1].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][2].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][3].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][4].ToString())));
                }
                tb.AddFooterCell(new Cell(1, 5).SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .Add(new Paragraph("Total de salas mayores a $1,000 en inventario: " + t.Rows.Count.ToString())));
                doc.Add(tb);
                doc.Close();
                Process.Start(ruta);
                //MessageBox.Show("Reporte generado en " + ruta);
            }
        }
        public void Ventas()
        {

            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Documento PDF|*.pdf";
            DialogResult res = dlgGuardar.ShowDialog();
            if (res == DialogResult.OK)
            {
                string ruta = dlgGuardar.FileName;
                DataTable t = mbd.mostrarVentas();
                FileInfo archivo = new FileInfo(ruta);
                PdfWriter write = new PdfWriter(archivo);
                PdfDocument pdf = new PdfDocument(write);
                Document doc = new Document(pdf, PageSize.LETTER.Rotate());

                //string rutaImagen = @"../../Resources/logo.PNG";
                //Image img = new Image(ImageDataFactory.Create(rutaImagen));
                MemoryStream ms = new MemoryStream();
                System.Drawing.Image imagen = VistaEscritorio.Properties.Resources.logo;
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] foto = ms.ToArray();
                Image img = new Image(ImageDataFactory.Create(foto));
                img.SetWidth(125);
                img.SetHeight(125);
                img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                doc.Add(img);

                // doc.Add(new AreaBreak());
                doc.Add(new Paragraph("REPORTE DE VENTAS\n")
                     .SetTextAlignment(TextAlignment.CENTER)
                     .SetFontSize(16f).SetBold());
                doc.Add(new Paragraph("Distribuidoras Romo\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f).SetBold().SetFontColor(fontColor: ColorConstants.RED));
                doc.Add(new Paragraph("Tel: 8754965214\n")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14f));
                doc.Add(new Paragraph("Fecha y hora de reporte \n")
                   .SetTextAlignment(TextAlignment.RIGHT)
                   .SetFontSize(12f));
                doc.Add(new Paragraph(DateTime.Now.ToString())
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12f));


                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                Table tb = new Table(6);
                tb.SetWidth(UnitValue.CreatePercentValue(100f));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Codigo de Venta")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Nombre de Cliente")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Fecha de Compra")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Codigo de Sala")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Cantidad de Sillones")));
                tb.AddHeaderCell(new Cell().SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Total")));
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][0].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][1].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][2].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][3].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][4].ToString())));
                    tb.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(t.Rows[i][5].ToString())));
                }
                //tb.AddFooterCell(new Cell(1, 5).SetBackgroundColor(ColorConstants.DARK_GRAY).SetFontColor(fontColor: ColorConstants.WHITE)
                //    .SetTextAlignment(TextAlignment.RIGHT)
                //    .Add(new Paragraph("Total de salas mayores a $1,000 en inventario: " + t.Rows.Count.ToString())));
                doc.Add(tb);
                doc.Close();
                Process.Start(ruta);
                //MessageBox.Show("Reporte generado en " + ruta);
            }
        }
    }
}