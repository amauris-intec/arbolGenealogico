// Generated from java-escape by ANTLR 4.11.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class arbolGenealogicoParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.11.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		MAS=1, LPAR=2, RPAR=3, COMA=4, FALLECIDO=5, NOMBRE=6, WS=7;
	public static final int
		RULE_program = 0, RULE_descendencia = 1, RULE_hijos = 2, RULE_matrimonio = 3, 
		RULE_persona = 4, RULE_fallecido = 5;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "descendencia", "hijos", "matrimonio", "persona", "fallecido"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'+'", "'{'", "'}'", "','", "'#'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "MAS", "LPAR", "RPAR", "COMA", "FALLECIDO", "NOMBRE", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "java-escape"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public arbolGenealogicoParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ProgramContext extends ParserRuleContext {
		public DescendenciaContext descendencia() {
			return getRuleContext(DescendenciaContext.class,0);
		}
		public TerminalNode EOF() { return getToken(arbolGenealogicoParser.EOF, 0); }
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterProgram(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitProgram(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(12);
			descendencia();
			setState(13);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class DescendenciaContext extends ParserRuleContext {
		public TerminalNode LPAR() { return getToken(arbolGenealogicoParser.LPAR, 0); }
		public HijosContext hijos() {
			return getRuleContext(HijosContext.class,0);
		}
		public TerminalNode RPAR() { return getToken(arbolGenealogicoParser.RPAR, 0); }
		public DescendenciaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_descendencia; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterDescendencia(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitDescendencia(this);
		}
	}

	public final DescendenciaContext descendencia() throws RecognitionException {
		DescendenciaContext _localctx = new DescendenciaContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_descendencia);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(15);
			match(LPAR);
			setState(16);
			hijos();
			setState(17);
			match(RPAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class HijosContext extends ParserRuleContext {
		public List<MatrimonioContext> matrimonio() {
			return getRuleContexts(MatrimonioContext.class);
		}
		public MatrimonioContext matrimonio(int i) {
			return getRuleContext(MatrimonioContext.class,i);
		}
		public List<TerminalNode> COMA() { return getTokens(arbolGenealogicoParser.COMA); }
		public TerminalNode COMA(int i) {
			return getToken(arbolGenealogicoParser.COMA, i);
		}
		public HijosContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_hijos; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterHijos(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitHijos(this);
		}
	}

	public final HijosContext hijos() throws RecognitionException {
		HijosContext _localctx = new HijosContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_hijos);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(19);
			matrimonio();
			setState(24);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==COMA) {
				{
				{
				setState(20);
				match(COMA);
				setState(21);
				matrimonio();
				}
				}
				setState(26);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class MatrimonioContext extends ParserRuleContext {
		public List<PersonaContext> persona() {
			return getRuleContexts(PersonaContext.class);
		}
		public PersonaContext persona(int i) {
			return getRuleContext(PersonaContext.class,i);
		}
		public TerminalNode MAS() { return getToken(arbolGenealogicoParser.MAS, 0); }
		public DescendenciaContext descendencia() {
			return getRuleContext(DescendenciaContext.class,0);
		}
		public MatrimonioContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_matrimonio; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterMatrimonio(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitMatrimonio(this);
		}
	}

	public final MatrimonioContext matrimonio() throws RecognitionException {
		MatrimonioContext _localctx = new MatrimonioContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_matrimonio);
		try {
			setState(33);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(27);
				persona();
				setState(28);
				match(MAS);
				setState(29);
				persona();
				setState(30);
				descendencia();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(32);
				persona();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class PersonaContext extends ParserRuleContext {
		public FallecidoContext fallecido() {
			return getRuleContext(FallecidoContext.class,0);
		}
		public TerminalNode NOMBRE() { return getToken(arbolGenealogicoParser.NOMBRE, 0); }
		public PersonaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_persona; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterPersona(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitPersona(this);
		}
	}

	public final PersonaContext persona() throws RecognitionException {
		PersonaContext _localctx = new PersonaContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_persona);
		try {
			setState(38);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(35);
				fallecido();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(36);
				match(NOMBRE);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FallecidoContext extends ParserRuleContext {
		public TerminalNode NOMBRE() { return getToken(arbolGenealogicoParser.NOMBRE, 0); }
		public TerminalNode FALLECIDO() { return getToken(arbolGenealogicoParser.FALLECIDO, 0); }
		public FallecidoContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_fallecido; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).enterFallecido(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof arbolGenealogicoListener ) ((arbolGenealogicoListener)listener).exitFallecido(this);
		}
	}

	public final FallecidoContext fallecido() throws RecognitionException {
		FallecidoContext _localctx = new FallecidoContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_fallecido);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			match(NOMBRE);
			setState(41);
			match(FALLECIDO);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\u0004\u0001\u0007,\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002"+
		"\u0005\u0007\u0005\u0001\u0000\u0001\u0000\u0001\u0000\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0005"+
		"\u0002\u0017\b\u0002\n\u0002\f\u0002\u001a\t\u0002\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0003\u0003\"\b\u0003"+
		"\u0001\u0004\u0001\u0004\u0001\u0004\u0003\u0004\'\b\u0004\u0001\u0005"+
		"\u0001\u0005\u0001\u0005\u0001\u0005\u0000\u0000\u0006\u0000\u0002\u0004"+
		"\u0006\b\n\u0000\u0000)\u0000\f\u0001\u0000\u0000\u0000\u0002\u000f\u0001"+
		"\u0000\u0000\u0000\u0004\u0013\u0001\u0000\u0000\u0000\u0006!\u0001\u0000"+
		"\u0000\u0000\b&\u0001\u0000\u0000\u0000\n(\u0001\u0000\u0000\u0000\f\r"+
		"\u0003\u0002\u0001\u0000\r\u000e\u0005\u0000\u0000\u0001\u000e\u0001\u0001"+
		"\u0000\u0000\u0000\u000f\u0010\u0005\u0002\u0000\u0000\u0010\u0011\u0003"+
		"\u0004\u0002\u0000\u0011\u0012\u0005\u0003\u0000\u0000\u0012\u0003\u0001"+
		"\u0000\u0000\u0000\u0013\u0018\u0003\u0006\u0003\u0000\u0014\u0015\u0005"+
		"\u0004\u0000\u0000\u0015\u0017\u0003\u0006\u0003\u0000\u0016\u0014\u0001"+
		"\u0000\u0000\u0000\u0017\u001a\u0001\u0000\u0000\u0000\u0018\u0016\u0001"+
		"\u0000\u0000\u0000\u0018\u0019\u0001\u0000\u0000\u0000\u0019\u0005\u0001"+
		"\u0000\u0000\u0000\u001a\u0018\u0001\u0000\u0000\u0000\u001b\u001c\u0003"+
		"\b\u0004\u0000\u001c\u001d\u0005\u0001\u0000\u0000\u001d\u001e\u0003\b"+
		"\u0004\u0000\u001e\u001f\u0003\u0002\u0001\u0000\u001f\"\u0001\u0000\u0000"+
		"\u0000 \"\u0003\b\u0004\u0000!\u001b\u0001\u0000\u0000\u0000! \u0001\u0000"+
		"\u0000\u0000\"\u0007\u0001\u0000\u0000\u0000#\'\u0003\n\u0005\u0000$\'"+
		"\u0005\u0006\u0000\u0000%\'\u0001\u0000\u0000\u0000&#\u0001\u0000\u0000"+
		"\u0000&$\u0001\u0000\u0000\u0000&%\u0001\u0000\u0000\u0000\'\t\u0001\u0000"+
		"\u0000\u0000()\u0005\u0006\u0000\u0000)*\u0005\u0005\u0000\u0000*\u000b"+
		"\u0001\u0000\u0000\u0000\u0003\u0018!&";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}