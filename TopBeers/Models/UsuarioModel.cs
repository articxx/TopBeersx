using System;

namespace TopBeers.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime EDITAR_NAO_E_SENHA { get; set; }

    }

    //public bool ValidarLogin()
    //{
    //    string sql = $"SELECT ID, NOME, DATA_NASCIMENTO FROM USUARIO WHERE EMAIL'{Email}' AND SENHA'{Senha}'";
    //    DAL objDAL = new DAL();
    //    DataTable dt = objDAL.RetDataTable(sql);

    //    if(dt != null)
    //    {
    //        if (dt.Rows.Count == 1)
    //        {
    //            return true;
    //        }

    //        return false;
    //    }
    //}
}
