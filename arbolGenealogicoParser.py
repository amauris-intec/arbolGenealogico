# Generated from c:\Users\ama\source\repos\arbolGenealogico\arbolGenealogico.g4 by ANTLR 4.9.2
# encoding: utf-8
from antlr4 import *
from io import StringIO
import sys
if sys.version_info[1] > 5:
	from typing import TextIO
else:
	from typing.io import TextIO


def serializedATN():
    with StringIO() as buf:
        buf.write("\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\t")
        buf.write(".\4\2\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\3\2")
        buf.write("\3\2\3\2\3\3\3\3\3\3\3\3\3\4\3\4\3\4\7\4\31\n\4\f\4\16")
        buf.write("\4\34\13\4\3\5\3\5\3\5\3\5\3\5\3\5\5\5$\n\5\3\6\3\6\3")
        buf.write("\6\5\6)\n\6\3\7\3\7\3\7\3\7\2\2\b\2\4\6\b\n\f\2\2\2+\2")
        buf.write("\16\3\2\2\2\4\21\3\2\2\2\6\25\3\2\2\2\b#\3\2\2\2\n(\3")
        buf.write("\2\2\2\f*\3\2\2\2\16\17\5\4\3\2\17\20\7\2\2\3\20\3\3\2")
        buf.write("\2\2\21\22\7\4\2\2\22\23\5\6\4\2\23\24\7\5\2\2\24\5\3")
        buf.write("\2\2\2\25\32\5\b\5\2\26\27\7\6\2\2\27\31\5\b\5\2\30\26")
        buf.write("\3\2\2\2\31\34\3\2\2\2\32\30\3\2\2\2\32\33\3\2\2\2\33")
        buf.write("\7\3\2\2\2\34\32\3\2\2\2\35\36\5\n\6\2\36\37\7\3\2\2\37")
        buf.write(" \5\n\6\2 !\5\4\3\2!$\3\2\2\2\"$\5\n\6\2#\35\3\2\2\2#")
        buf.write("\"\3\2\2\2$\t\3\2\2\2%)\5\f\7\2&)\7\b\2\2\')\3\2\2\2(")
        buf.write("%\3\2\2\2(&\3\2\2\2(\'\3\2\2\2)\13\3\2\2\2*+\7\b\2\2+")
        buf.write(",\7\7\2\2,\r\3\2\2\2\5\32#(")
        return buf.getvalue()


class arbolGenealogicoParser ( Parser ):

    grammarFileName = "arbolGenealogico.g4"

    atn = ATNDeserializer().deserialize(serializedATN())

    decisionsToDFA = [ DFA(ds, i) for i, ds in enumerate(atn.decisionToState) ]

    sharedContextCache = PredictionContextCache()

    literalNames = [ "<INVALID>", "'+'", "'{'", "'}'", "','", "'#'" ]

    symbolicNames = [ "<INVALID>", "MAS", "LPAR", "RPAR", "COMA", "FALLECIDO", 
                      "NOMBRE", "WS" ]

    RULE_program = 0
    RULE_descendencia = 1
    RULE_hijos = 2
    RULE_matrimonio = 3
    RULE_persona = 4
    RULE_fallecido = 5

    ruleNames =  [ "program", "descendencia", "hijos", "matrimonio", "persona", 
                   "fallecido" ]

    EOF = Token.EOF
    MAS=1
    LPAR=2
    RPAR=3
    COMA=4
    FALLECIDO=5
    NOMBRE=6
    WS=7

    def __init__(self, input:TokenStream, output:TextIO = sys.stdout):
        super().__init__(input, output)
        self.checkVersion("4.9.2")
        self._interp = ParserATNSimulator(self, self.atn, self.decisionsToDFA, self.sharedContextCache)
        self._predicates = None




    class ProgramContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def descendencia(self):
            return self.getTypedRuleContext(arbolGenealogicoParser.DescendenciaContext,0)


        def EOF(self):
            return self.getToken(arbolGenealogicoParser.EOF, 0)

        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_program

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitProgram" ):
                return visitor.visitProgram(self)
            else:
                return visitor.visitChildren(self)




    def program(self):

        localctx = arbolGenealogicoParser.ProgramContext(self, self._ctx, self.state)
        self.enterRule(localctx, 0, self.RULE_program)
        try:
            self.enterOuterAlt(localctx, 1)
            self.state = 12
            self.descendencia()
            self.state = 13
            self.match(arbolGenealogicoParser.EOF)
        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class DescendenciaContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def LPAR(self):
            return self.getToken(arbolGenealogicoParser.LPAR, 0)

        def hijos(self):
            return self.getTypedRuleContext(arbolGenealogicoParser.HijosContext,0)


        def RPAR(self):
            return self.getToken(arbolGenealogicoParser.RPAR, 0)

        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_descendencia

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitDescendencia" ):
                return visitor.visitDescendencia(self)
            else:
                return visitor.visitChildren(self)




    def descendencia(self):

        localctx = arbolGenealogicoParser.DescendenciaContext(self, self._ctx, self.state)
        self.enterRule(localctx, 2, self.RULE_descendencia)
        try:
            self.enterOuterAlt(localctx, 1)
            self.state = 15
            self.match(arbolGenealogicoParser.LPAR)
            self.state = 16
            self.hijos()
            self.state = 17
            self.match(arbolGenealogicoParser.RPAR)
        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class HijosContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def matrimonio(self, i:int=None):
            if i is None:
                return self.getTypedRuleContexts(arbolGenealogicoParser.MatrimonioContext)
            else:
                return self.getTypedRuleContext(arbolGenealogicoParser.MatrimonioContext,i)


        def COMA(self, i:int=None):
            if i is None:
                return self.getTokens(arbolGenealogicoParser.COMA)
            else:
                return self.getToken(arbolGenealogicoParser.COMA, i)

        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_hijos

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitHijos" ):
                return visitor.visitHijos(self)
            else:
                return visitor.visitChildren(self)




    def hijos(self):

        localctx = arbolGenealogicoParser.HijosContext(self, self._ctx, self.state)
        self.enterRule(localctx, 4, self.RULE_hijos)
        self._la = 0 # Token type
        try:
            self.enterOuterAlt(localctx, 1)
            self.state = 19
            self.matrimonio()
            self.state = 24
            self._errHandler.sync(self)
            _la = self._input.LA(1)
            while _la==arbolGenealogicoParser.COMA:
                self.state = 20
                self.match(arbolGenealogicoParser.COMA)
                self.state = 21
                self.matrimonio()
                self.state = 26
                self._errHandler.sync(self)
                _la = self._input.LA(1)

        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class MatrimonioContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def persona(self, i:int=None):
            if i is None:
                return self.getTypedRuleContexts(arbolGenealogicoParser.PersonaContext)
            else:
                return self.getTypedRuleContext(arbolGenealogicoParser.PersonaContext,i)


        def MAS(self):
            return self.getToken(arbolGenealogicoParser.MAS, 0)

        def descendencia(self):
            return self.getTypedRuleContext(arbolGenealogicoParser.DescendenciaContext,0)


        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_matrimonio

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitMatrimonio" ):
                return visitor.visitMatrimonio(self)
            else:
                return visitor.visitChildren(self)




    def matrimonio(self):

        localctx = arbolGenealogicoParser.MatrimonioContext(self, self._ctx, self.state)
        self.enterRule(localctx, 6, self.RULE_matrimonio)
        try:
            self.state = 33
            self._errHandler.sync(self)
            la_ = self._interp.adaptivePredict(self._input,1,self._ctx)
            if la_ == 1:
                self.enterOuterAlt(localctx, 1)
                self.state = 27
                self.persona()
                self.state = 28
                self.match(arbolGenealogicoParser.MAS)
                self.state = 29
                self.persona()
                self.state = 30
                self.descendencia()
                pass

            elif la_ == 2:
                self.enterOuterAlt(localctx, 2)
                self.state = 32
                self.persona()
                pass


        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class PersonaContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def fallecido(self):
            return self.getTypedRuleContext(arbolGenealogicoParser.FallecidoContext,0)


        def NOMBRE(self):
            return self.getToken(arbolGenealogicoParser.NOMBRE, 0)

        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_persona

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitPersona" ):
                return visitor.visitPersona(self)
            else:
                return visitor.visitChildren(self)




    def persona(self):

        localctx = arbolGenealogicoParser.PersonaContext(self, self._ctx, self.state)
        self.enterRule(localctx, 8, self.RULE_persona)
        try:
            self.state = 38
            self._errHandler.sync(self)
            la_ = self._interp.adaptivePredict(self._input,2,self._ctx)
            if la_ == 1:
                self.enterOuterAlt(localctx, 1)
                self.state = 35
                self.fallecido()
                pass

            elif la_ == 2:
                self.enterOuterAlt(localctx, 2)
                self.state = 36
                self.match(arbolGenealogicoParser.NOMBRE)
                pass

            elif la_ == 3:
                self.enterOuterAlt(localctx, 3)

                pass


        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class FallecidoContext(ParserRuleContext):
        __slots__ = 'parser'

        def __init__(self, parser, parent:ParserRuleContext=None, invokingState:int=-1):
            super().__init__(parent, invokingState)
            self.parser = parser

        def NOMBRE(self):
            return self.getToken(arbolGenealogicoParser.NOMBRE, 0)

        def FALLECIDO(self):
            return self.getToken(arbolGenealogicoParser.FALLECIDO, 0)

        def getRuleIndex(self):
            return arbolGenealogicoParser.RULE_fallecido

        def accept(self, visitor:ParseTreeVisitor):
            if hasattr( visitor, "visitFallecido" ):
                return visitor.visitFallecido(self)
            else:
                return visitor.visitChildren(self)




    def fallecido(self):

        localctx = arbolGenealogicoParser.FallecidoContext(self, self._ctx, self.state)
        self.enterRule(localctx, 10, self.RULE_fallecido)
        try:
            self.enterOuterAlt(localctx, 1)
            self.state = 40
            self.match(arbolGenealogicoParser.NOMBRE)
            self.state = 41
            self.match(arbolGenealogicoParser.FALLECIDO)
        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx





