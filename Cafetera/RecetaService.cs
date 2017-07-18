using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository recetaRepository;

        public RecetaService()
        {

        }

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public Receta Create (Receta Receta)
        {
            Receta.Peso *= 2;
            return recetaRepository.Create(Receta);
        }
    }
}
