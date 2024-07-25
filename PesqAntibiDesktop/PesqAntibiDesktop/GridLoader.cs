using Dados;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public class GridLoader
    {
        public static void addDefaultCollumns(DataGridView grid)
        {
            // Create the columns with the desired names
            grid.Columns.Add("nome", "Nome do Antibiótico");
            grid.Columns.Add("tipo_antibiotico", "Tipo de Antibiótico");
            grid.Columns.Add("gram_positiva", "Age em Gram Positiva");
            grid.Columns.Add("gram_negativa", "Age em Gram Negativa");
            grid.Columns.Add("morfologia", "Morfologia Bacteriana");
        }

        public static string getGramPositivaString(DataRow row)
        {
            string gramPositiva = "Não informado";
            if ((byte)row["gram_positiva"] == 0)
            {
                gramPositiva = "❌";
            }
            else if ((byte)row["gram_positiva"] == 1)
            {
                gramPositiva = "✅";
            }

            return gramPositiva;
        }

        public static string getGramNegativaString(DataRow row)
        {
            string gramNegativa = "Não informado";
            if ((byte)row["gram_negativa"] == 0)
            {
                gramNegativa = "❌";
            }
            else if ((byte)row["gram_negativa"] == 1)
            {
                gramNegativa = "✅";
            }

            return gramNegativa;
        }


        public static string getTipoAntibioticoString(DataRow row)
        {
            return Enum.GetName(typeof(TipoAntibiotico), row["tipo_antibiotico"]);
        }

        public static string getMorfologiaString(DataRow row)
        {
            string nome = Enum.GetName(typeof(TipoMorfologia), row["morfologia"]);
            if (nome == null)
            {
                return "Não informado";
            }
            if (nome == Enum.GetName(typeof(TipoMorfologia), 3))
            {
                return "Cocos e Bacilos";
            }
            return nome;
        }

        public static void setGramForeColor(DataGridView grid, string gramNegativa, string gramPositiva)
        {
            if (gramNegativa == "❌")
            {
                grid.Rows[grid.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Red;
            }
            else
            {
                grid.Rows[grid.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Green;
            }

            if (gramPositiva == "❌")
            {
                grid.Rows[grid.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Red;
            }
            else
            {
                grid.Rows[grid.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Green;
            }
        }

        public static void clearGrid(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
        }
    }
}
