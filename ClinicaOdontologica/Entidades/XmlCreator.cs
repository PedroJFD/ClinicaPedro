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
        private string CaminhoXml = "C:\\XmlClinica\\XmlClientes\\DocumentoXml.XML";
        private string CaminhoXmlHorarios = "C:\\XmlClinica\\XmlHorarios\\DocumentoXmlHorarios.XML";
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
                new XElement("Sobrenome", cliente.Sobrenome.Trim()),
                new XElement("Email", cliente.Email.Trim()),
                new XElement("Telefone", cliente.Telefone.Trim()),
                new XElement("Cidade", cliente.Cidade.Trim())
            );

            DocumentoXml.Root.Add(novoRegistro);
            DocumentoXml.Save(CaminhoXml);
        }

        public void GravarXmlHorarios(Tratamento tratamento)
        {
            XDocument DocumentoXmlHorarios;

            if (File.Exists(CaminhoXmlHorarios))
            {
                DocumentoXmlHorarios = XDocument.Load(CaminhoXmlHorarios);
            }
            else
            {
                DocumentoXmlHorarios = new XDocument(new XElement("Horarios"));
            }

            XElement novoRegistroHorarios = new XElement("Registro",
                new XElement("Cliente", tratamento.Cliente.Trim()),
                new XElement("Data", tratamento.Data.Trim()),
                new XElement("Horario", tratamento.Horario.Trim()),
                new XElement("TipoTratamento", tratamento.TipoTratamento.Trim())
            );

            DocumentoXmlHorarios.Root.Add(novoRegistroHorarios);
            DocumentoXmlHorarios.Save(CaminhoXmlHorarios);
        }
    }
}
