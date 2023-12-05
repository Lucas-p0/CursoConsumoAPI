
using System.Net.Http;
using System;
using System.Text.Json;
using System.Collections.Generic;
using CursoConsumoAPI.Denpedencias.Modelo;

using (HttpClient client = new())
{
    //API_Sintegra
    string SINTEGRA_API_MOCK = "https://86b73228-4c2b-40a0-953f-0f91909e228c.mock.pstmn.io/api/v1/execute-api.php?token=ED55ABD3-5343-4046-B3B4-C98E48F7B440&cnpj=56156274000129&plugin=ST";

    string SINTEGRA_API = "https://www.sintegraws.com.br/api/v1/execute-api.php?token=ED55ABD3-5343-4046-B3B4-C98E48F7B440&cnpj=56156274000129&plugin=ST";
    try
    {
        HttpResponseMessage resposta = client.GetAsync(SINTEGRA_API_MOCK).Result;
        //var fornecedores = JsonSerializer.Deserialize<Fornecedor>(resposta);
        Console.WriteLine(resposta.Content.ReadAsStringAsync().Result);
        // Console.WriteLine($"Código do fornecedor:{fornecedores.Codigo}");
        // Console.WriteLine($"Código do fornecedor:{fornecedores.Uf}");
        //Console.WriteLine(DetalhesAPI);


        //Console.WriteLine(value);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema:{ex.Message}");
    }


}

