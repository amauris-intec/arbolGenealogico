using Antlr4.Runtime;
using arbolGenealogico;

var input = CharStreams.fromPath(@"..\..\..\familia.txt");
var lexer = new arbolGenealogicoV2Lexer(input);
var tokenStream = new CommonTokenStream(lexer);
var parser = new arbolGenealogicoV2Parser(tokenStream);
var tree = parser.program();

var visitor = new analizadorArbolGenealogicoMejorado();
visitor.Visit(tree);