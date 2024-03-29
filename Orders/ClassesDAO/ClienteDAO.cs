﻿using MySql.Data.MySqlClient;
using Orders.Classes;
using System.Data;

namespace Orders.ClassesDAO
{
    class ClienteDAO
    {
        MySqlDataAdapter comando_sql;
        DataTable tabela_memoria;
        Cliente cli = new Cliente();

        internal Cliente Cli { get => cli; set => cli = value; }

        private void ExecutarComando(string comando)
        {
            tabela_memoria = new DataTable();
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
            comando_sql.Fill(tabela_memoria);
        }

        #region LISTA TODOS OS CLIENTES
        public DataTable Listartudo()
        {
            DataTable listaDescripto;
            ExecutarComando("SELECT nome as NOME FROM CLIENTE;");
            listaDescripto = tabela_memoria.Clone();

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = listaDescripto.NewRow();
                linha["NOME"] = tabela_memoria.Rows[i]["NOME"].ToString();
                listaDescripto.Rows.Add(linha);
            }
            return listaDescripto;
        }
        #endregion
    }
}
