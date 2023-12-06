using System;
using System.Text.Json.Serialization;

namespace CursoConsumoAPI.Denpedencias.Modelo
{
    public class Fornecedor
    {
        [JsonPropertyName("code")]
        public string Codigo { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public string Mensagem { get; set; }

        [JsonPropertyName("nome_empresarial")]
        public string NomeEmpresarial { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("inscricao_estadual")]
        public string InscricaoEstadual { get; set; }

        [JsonPropertyName("tipo_inscricao")]
        public string TipoInscricao { get; set; }

        [JsonPropertyName("data_situacao_cadastral")]
        public string DataSituacaoCadastral { get; set; }

        [JsonPropertyName("situacao_cnpj")]
        public string SituacaoCnpj { get; set; }

        [JsonPropertyName("situacao_ie")]
        public string SituacaoIe { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("data_inicio_atividade")]
        public string DataInicioAtividade { get; set; }

        [JsonPropertyName("regime_tributacao")]
        public string RegimeTributacao { get; set; }

        [JsonPropertyName("informacao_ie_como_destinatario")]
        public string InformacaoIeComoDestinatario { get; set; }
        [JsonPropertyName("porte_empresa")]
        public string PorteEmpresa { get; set; }

        [JsonPropertyName("data_fim_atividade")]
        public string DataFimAtividade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }



        public class CnaePrincipal
        {
            [JsonPropertyName("code")]
            public string Codigo { get; set; }
            [JsonPropertyName("text")]
            public string Texto { get; set; }
        }
        public class Ibge
        {
            [JsonPropertyName("codigo_municipio")]
            public int CodigoMunicipio { get; set; }
            [JsonPropertyName("codigo_uf")]
            public int CodigoUf { get; set; }
        }
        public void DetalhesAPI()
        {
            Console.WriteLine($"Codigo do fornecedor:{Codigo}");
            Console.WriteLine($"Codigo do Status:{Status}");
            Console.WriteLine($"Codigo do Nome do fornecedor:{NomeEmpresarial}");
            Console.WriteLine($"Codigo do Cnpj do fornecedor:{Cnpj}");
        }
    }

}

