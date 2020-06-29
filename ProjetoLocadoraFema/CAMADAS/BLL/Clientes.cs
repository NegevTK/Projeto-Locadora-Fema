using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.BLL
{
    public class Clientes
    {

        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            return dalClientes.Select();
        }

        public void Inserir(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            dalCliente.Insert(clientes);
        }

        public void Update(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            dalCliente.Update(clientes);
        }

        public void Delete(int clientes)
        {
            DAL.Clientes dalClientes = new DAL.Clientes();
            dalClientes.Delete(clientes);
        }


    }
}
