# Generated from c:\Users\ama\source\repos\arbolGenealogico\arbolGenealogico.g4 by ANTLR 4.9.2
from antlr4 import *
if __name__ is not None and "." in __name__:
    from .arbolGenealogicoParser import arbolGenealogicoParser
else:
    from arbolGenealogicoParser import arbolGenealogicoParser

# This class defines a complete generic visitor for a parse tree produced by arbolGenealogicoParser.

class arbolGenealogicoVisitor(ParseTreeVisitor):

    # Visit a parse tree produced by arbolGenealogicoParser#program.
    def visitProgram(self, ctx:arbolGenealogicoParser.ProgramContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by arbolGenealogicoParser#descendencia.
    def visitDescendencia(self, ctx:arbolGenealogicoParser.DescendenciaContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by arbolGenealogicoParser#hijos.
    def visitHijos(self, ctx:arbolGenealogicoParser.HijosContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by arbolGenealogicoParser#matrimonio.
    def visitMatrimonio(self, ctx:arbolGenealogicoParser.MatrimonioContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by arbolGenealogicoParser#persona.
    def visitPersona(self, ctx:arbolGenealogicoParser.PersonaContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by arbolGenealogicoParser#fallecido.
    def visitFallecido(self, ctx:arbolGenealogicoParser.FallecidoContext):
        return self.visitChildren(ctx)



del arbolGenealogicoParser