//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\ama\source\repos\arbolGenealogico\arbolGenealogico.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class arbolGenealogicoParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MAS=1, LPAR=2, RPAR=3, COMA=4, FALLECIDO=5, NOMBRE=6, WS=7;
	public const int
		RULE_program = 0, RULE_descendencia = 1, RULE_hijos = 2, RULE_matrimonio = 3, 
		RULE_persona = 4, RULE_fallecido = 5;
	public static readonly string[] ruleNames = {
		"program", "descendencia", "hijos", "matrimonio", "persona", "fallecido"
	};

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'{'", "'}'", "','", "'#'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MAS", "LPAR", "RPAR", "COMA", "FALLECIDO", "NOMBRE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "arbolGenealogico.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static arbolGenealogicoParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public arbolGenealogicoParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public arbolGenealogicoParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DescendenciaContext descendencia() {
			return GetRuleContext<DescendenciaContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(arbolGenealogicoParser.Eof, 0); }
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			descendencia();
			State = 13;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DescendenciaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAR() { return GetToken(arbolGenealogicoParser.LPAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public HijosContext hijos() {
			return GetRuleContext<HijosContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAR() { return GetToken(arbolGenealogicoParser.RPAR, 0); }
		public DescendenciaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_descendencia; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDescendencia(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DescendenciaContext descendencia() {
		DescendenciaContext _localctx = new DescendenciaContext(Context, State);
		EnterRule(_localctx, 2, RULE_descendencia);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			Match(LPAR);
			State = 16;
			hijos();
			State = 17;
			Match(RPAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HijosContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MatrimonioContext[] matrimonio() {
			return GetRuleContexts<MatrimonioContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MatrimonioContext matrimonio(int i) {
			return GetRuleContext<MatrimonioContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMA() { return GetTokens(arbolGenealogicoParser.COMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMA(int i) {
			return GetToken(arbolGenealogicoParser.COMA, i);
		}
		public HijosContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hijos; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHijos(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HijosContext hijos() {
		HijosContext _localctx = new HijosContext(Context, State);
		EnterRule(_localctx, 4, RULE_hijos);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			matrimonio();
			State = 24;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMA) {
				{
				{
				State = 20;
				Match(COMA);
				State = 21;
				matrimonio();
				}
				}
				State = 26;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MatrimonioContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PersonaContext[] persona() {
			return GetRuleContexts<PersonaContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PersonaContext persona(int i) {
			return GetRuleContext<PersonaContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MAS() { return GetToken(arbolGenealogicoParser.MAS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DescendenciaContext descendencia() {
			return GetRuleContext<DescendenciaContext>(0);
		}
		public MatrimonioContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_matrimonio; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMatrimonio(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MatrimonioContext matrimonio() {
		MatrimonioContext _localctx = new MatrimonioContext(Context, State);
		EnterRule(_localctx, 6, RULE_matrimonio);
		try {
			State = 33;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 27;
				persona();
				State = 28;
				Match(MAS);
				State = 29;
				persona();
				State = 30;
				descendencia();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 32;
				persona();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PersonaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FallecidoContext fallecido() {
			return GetRuleContext<FallecidoContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOMBRE() { return GetToken(arbolGenealogicoParser.NOMBRE, 0); }
		public PersonaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_persona; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPersona(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PersonaContext persona() {
		PersonaContext _localctx = new PersonaContext(Context, State);
		EnterRule(_localctx, 8, RULE_persona);
		try {
			State = 38;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 35;
				fallecido();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 36;
				Match(NOMBRE);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FallecidoContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOMBRE() { return GetToken(arbolGenealogicoParser.NOMBRE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALLECIDO() { return GetToken(arbolGenealogicoParser.FALLECIDO, 0); }
		public FallecidoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fallecido; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IarbolGenealogicoVisitor<TResult> typedVisitor = visitor as IarbolGenealogicoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFallecido(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FallecidoContext fallecido() {
		FallecidoContext _localctx = new FallecidoContext(Context, State);
		EnterRule(_localctx, 10, RULE_fallecido);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 40;
			Match(NOMBRE);
			State = 41;
			Match(FALLECIDO);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\t', '.', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\x19', '\n', '\x4', '\f', 
		'\x4', '\xE', '\x4', '\x1C', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', 
		'$', '\n', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', 
		')', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x2', '\x2', '\b', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\x2', '\x2', 
		'\x2', '+', '\x2', '\xE', '\x3', '\x2', '\x2', '\x2', '\x4', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '\x15', '\x3', '\x2', '\x2', '\x2', '\b', 
		'#', '\x3', '\x2', '\x2', '\x2', '\n', '(', '\x3', '\x2', '\x2', '\x2', 
		'\f', '*', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x5', '\x4', '\x3', 
		'\x2', '\xF', '\x10', '\a', '\x2', '\x2', '\x3', '\x10', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x12', '\a', '\x4', '\x2', '\x2', '\x12', 
		'\x13', '\x5', '\x6', '\x4', '\x2', '\x13', '\x14', '\a', '\x5', '\x2', 
		'\x2', '\x14', '\x5', '\x3', '\x2', '\x2', '\x2', '\x15', '\x1A', '\x5', 
		'\b', '\x5', '\x2', '\x16', '\x17', '\a', '\x6', '\x2', '\x2', '\x17', 
		'\x19', '\x5', '\b', '\x5', '\x2', '\x18', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\x1A', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x1E', '\x5', '\n', '\x6', '\x2', '\x1E', '\x1F', '\a', 
		'\x3', '\x2', '\x2', '\x1F', ' ', '\x5', '\n', '\x6', '\x2', ' ', '!', 
		'\x5', '\x4', '\x3', '\x2', '!', '$', '\x3', '\x2', '\x2', '\x2', '\"', 
		'$', '\x5', '\n', '\x6', '\x2', '#', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'#', '\"', '\x3', '\x2', '\x2', '\x2', '$', '\t', '\x3', '\x2', '\x2', 
		'\x2', '%', ')', '\x5', '\f', '\a', '\x2', '&', ')', '\a', '\b', '\x2', 
		'\x2', '\'', ')', '\x3', '\x2', '\x2', '\x2', '(', '%', '\x3', '\x2', 
		'\x2', '\x2', '(', '&', '\x3', '\x2', '\x2', '\x2', '(', '\'', '\x3', 
		'\x2', '\x2', '\x2', ')', '\v', '\x3', '\x2', '\x2', '\x2', '*', '+', 
		'\a', '\b', '\x2', '\x2', '+', ',', '\a', '\a', '\x2', '\x2', ',', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x5', '\x1A', '#', '(',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}