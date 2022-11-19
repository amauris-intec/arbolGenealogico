// Generated from java-escape by ANTLR 4.11.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link arbolGenealogicoParser}.
 */
public interface arbolGenealogicoListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(arbolGenealogicoParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(arbolGenealogicoParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#descendencia}.
	 * @param ctx the parse tree
	 */
	void enterDescendencia(arbolGenealogicoParser.DescendenciaContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#descendencia}.
	 * @param ctx the parse tree
	 */
	void exitDescendencia(arbolGenealogicoParser.DescendenciaContext ctx);
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#hijos}.
	 * @param ctx the parse tree
	 */
	void enterHijos(arbolGenealogicoParser.HijosContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#hijos}.
	 * @param ctx the parse tree
	 */
	void exitHijos(arbolGenealogicoParser.HijosContext ctx);
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#matrimonio}.
	 * @param ctx the parse tree
	 */
	void enterMatrimonio(arbolGenealogicoParser.MatrimonioContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#matrimonio}.
	 * @param ctx the parse tree
	 */
	void exitMatrimonio(arbolGenealogicoParser.MatrimonioContext ctx);
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#persona}.
	 * @param ctx the parse tree
	 */
	void enterPersona(arbolGenealogicoParser.PersonaContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#persona}.
	 * @param ctx the parse tree
	 */
	void exitPersona(arbolGenealogicoParser.PersonaContext ctx);
	/**
	 * Enter a parse tree produced by {@link arbolGenealogicoParser#fallecido}.
	 * @param ctx the parse tree
	 */
	void enterFallecido(arbolGenealogicoParser.FallecidoContext ctx);
	/**
	 * Exit a parse tree produced by {@link arbolGenealogicoParser#fallecido}.
	 * @param ctx the parse tree
	 */
	void exitFallecido(arbolGenealogicoParser.FallecidoContext ctx);
}