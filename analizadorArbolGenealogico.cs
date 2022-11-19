using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolGenealogico
{
    public class Persona
    {
        public string? nombre;
        public bool fallecido = false;
    }

    internal class analizadorArbolGenealogico : arbolGenealogicoBaseVisitor<Persona>
    {
        public override Persona VisitDescendencia([NotNull] arbolGenealogicoParser.DescendenciaContext context)
        {
            return base.VisitDescendencia(context);
        }

        public override Persona VisitFallecido([NotNull] arbolGenealogicoParser.FallecidoContext context)
        {
            Persona persona = new Persona();
            persona.nombre = context.NOMBRE().GetText();
            persona.fallecido = true;
            return persona;

        }

        public override Persona VisitHijos([NotNull] arbolGenealogicoParser.HijosContext context)
        {
            return base.VisitHijos(context);
        }

        public override Persona VisitMatrimonio([NotNull] arbolGenealogicoParser.MatrimonioContext context)
        {
            if (context.persona().Length > 1) // otra alternativa: context.MAS() != null
            {
                Persona persona = Visit(context.persona()[0]);
                Persona conyugue = Visit(context.persona()[1]);
                Console.WriteLine($"{persona.nombre} {(persona.fallecido ? "(que en paz descance) " : "")}" +
                    $"se casó con {conyugue.nombre} {(conyugue.fallecido ? "(que en paz descance) " : "")}");
            }
            else
            {
                Persona persona = Visit(context.persona()[0]);
                Console.WriteLine($"{persona.nombre} {(persona.fallecido ? "(que en paz descance) " : "")}se quedó jamón");
            }
            return base.VisitMatrimonio(context);
        }

        public override Persona VisitPersona([NotNull] arbolGenealogicoParser.PersonaContext context)
        {
            Persona persona;
            bool fallecido = context.fallecido() != null;
            if (fallecido)
            {
                persona = Visit(context.fallecido());
            }
            else
            {
                persona = new Persona();
                persona.nombre = context.NOMBRE().GetText();

            }
            return persona;
        }

        public override Persona VisitProgram([NotNull] arbolGenealogicoParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }
    }
}