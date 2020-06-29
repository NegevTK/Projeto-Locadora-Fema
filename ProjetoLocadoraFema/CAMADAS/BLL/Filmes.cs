using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.BLL
{
    public class Filmes
    {

        public List<MODEL.Filmes> Select()
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.Select();
        }

        public void Insert(MODEL.Filmes filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Insert(filmes);
        }

        public void Update(MODEL.Filmes filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Update(filmes);
        }

        public void Delete(int idFilmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Delete(idFilmes);
        }

        public List<CAMADAS.MODEL.Filmes> SelectByID(int filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByID(filmes);
            
        }

        public List<CAMADAS.MODEL.Filmes> SelectByNome(String filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByNome(filmes);

        }

    }
}
