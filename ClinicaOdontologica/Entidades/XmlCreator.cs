using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaOdontologica.Telas;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace ClinicaOdontologica.Entidades
{
    internal class XmlCreator
    {
        private string CaminhoXml = "C:\\Users\\pedro\\source\\repos\\teste.XML";
        public void GravarXml(Cliente cliente)
        {
            XDocument DocumentoXml;

            if (File.Exists(CaminhoXml))
            {
                DocumentoXml = XDocument.Load(CaminhoXml);
            }
            else
            {
                DocumentoXml = new XDocument(new XElement("Registros"));
            }

            XElement novoRegistro = new XElement("Registro",
                new XElement("Nome", cliente.Nome.Trim()),
                new XElement("Email", cliente.Email.Trim()),
                new XElement("Telefone", cliente.Telefone.Trim()),
                new XElement("Cidade", cliente.Cidade.Trim())
            );

            DocumentoXml.Root.Add(novoRegistro);
            DocumentoXml.Save(CaminhoXml);
        }
    }
}
