using JJ.Net.Core.Extensoes;
using JJ.Net.Core.Validador;
using JJ.Net.CrossData.Atributo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCheck.Domain.Entidades
{
    [Entidade("Cor")]
    public class Cor
    {
        [ChavePrimaria, Obrigatorio]
        public int PK_Cor { get; set; }

        [Obrigatorio]
        public string Nome { get; set; }

        [Obrigatorio]
        public string Hexadecimal { get; set; }
        [Obrigatorio]
        public string RGB { get; set; }

        [Editavel(false)]
        public ValidarResultado ValidarResultado { get; set; } = new ValidarResultado();

        public bool Validar()
        {
            ValidarResultado = new ValidarResultado();

            if (Nome.ObterValorOuPadrao("").Trim() == "")
            {
                ValidarResultado.Adicionar("Nome da cor é obrigatório.");
                return false;
            }
            else if (Hexadecimal.ObterValorOuPadrao("").Trim() == "")
            {
                ValidarResultado.Adicionar("Propriedade Hexadecimal é obrigatória.");
                return false;
            }
            else if (RGB.ObterValorOuPadrao("").Trim() == "")
            {
                ValidarResultado.Adicionar("Propriedade RGB é obrigatória.");
                return false;
            }

            return true;
        }
    }
}
