using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolGenealogico
{

    internal class analizadorArbolGenealogicoMejorado : arbolGenealogicoV2BaseVisitor<Persona>
    {
        


        public override Persona VisitDescendencia([NotNull] arbolGenealogicoV2Parser.DescendenciaContext context)
        {
            return base.VisitDescendencia(context);
        }



        public override Persona VisitHijos([NotNull] arbolGenealogicoV2Parser.HijosContext context)
        {
            return base.VisitHijos(context);
        }

        public override Persona VisitFamilia([NotNull] arbolGenealogicoV2Parser.FamiliaContext context)
        {
            
            Persona persona = Visit(context.hijo);
            Persona conyugue = Visit(context.conyugue);
            Console.WriteLine($"V2: {persona.nombre} {(persona.fallecido ? "(que en paz descance) " : "")}" +
                    $"se casó con {conyugue.nombre} {(conyugue.fallecido ? "(que en paz descance) " : "")}");
            return base.VisitFamilia(context);
        }

        public override Persona VisitJamon([NotNull] arbolGenealogicoV2Parser.JamonContext context)
        {

            Persona persona = Visit(context.persona());
            Console.WriteLine($"V2: {persona.nombre} {(persona.fallecido ? "(que en paz descance) " : "")}se quedó jamón");
            return base.VisitJamon(context);
        }


        public override Persona VisitVivo([NotNull] arbolGenealogicoV2Parser.VivoContext context)
        {
            Persona persona = new Persona();
            persona.nombre = context.NOMBRE().GetText();
            return persona;
        }

        public override Persona VisitFallecido([NotNull] arbolGenealogicoV2Parser.FallecidoContext context)
        {
            Persona persona = new Persona();
            persona.nombre = context.NOMBRE().GetText();
            persona.fallecido = true;
            return persona;
        }

        public override Persona VisitProgram([NotNull] arbolGenealogicoV2Parser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }
    }
}