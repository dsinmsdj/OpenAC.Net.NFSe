﻿using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.NFSe.Test
{
    public class SetupOpenNFSe
    {
        #region Fields

        private static OpenNFSe ginfes;
        private static OpenNFSe sigiss;

        #endregion Fields

        #region Properties

        public static OpenNFSe Ginfes => ginfes ?? (ginfes = GetGinfes());

        public static OpenNFSe Sigiss => sigiss ?? (sigiss = GetSigiss());

        #endregion Properties

        #region Setup

        private static OpenNFSe GetGinfes()
        {
            var openNFSe = new OpenNFSe();

            //Salvar os arquivos
            openNFSe.Configuracoes.Geral.Salvar = true;
            openNFSe.Configuracoes.Arquivos.Salvar = true;

            //webservices
            //Configure os dados da cidade e do Certificado aqui
            openNFSe.Configuracoes.WebServices.Ambiente = DFeTipoAmbiente.Homologacao;
            openNFSe.Configuracoes.WebServices.CodigoMunicipio = 3543402;

            openNFSe.Configuracoes.Certificados.Certificado = "4E009FA5F9CABB8F";
            openNFSe.Configuracoes.Certificados.Senha = "";

            openNFSe.Configuracoes.PrestadorPadrao.CpfCnpj = "03514896000115";
            openNFSe.Configuracoes.PrestadorPadrao.InscricaoMunicipal = "85841";

            return openNFSe;
        }

        private static OpenNFSe GetSigiss()
        {
            var openNFSe = new OpenNFSe();

            //Salvar os arquivos
            openNFSe.Configuracoes.Geral.Salvar = false;
            openNFSe.Configuracoes.Arquivos.Salvar = false;

            //prestador
            openNFSe.Configuracoes.PrestadorPadrao.CpfCnpj = "37761587000161";

            //webservices
            //Configure os dados da cidade e do Certificado aqui
            openNFSe.Configuracoes.WebServices.Ambiente = DFeTipoAmbiente.Producao;
            openNFSe.Configuracoes.WebServices.CodigoMunicipio = 3529005;

            openNFSe.Configuracoes.WebServices.Usuario = "888888";//USUARIO
            openNFSe.Configuracoes.WebServices.Senha = "123456";//SENHA

            return openNFSe;
        }

        #endregion Setup
    }
}