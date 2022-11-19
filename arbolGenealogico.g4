grammar arbolGenealogico;

program: descendencia EOF;

descendencia: LPAR hijos RPAR ;

hijos: matrimonio (COMA matrimonio)* ;

matrimonio: persona MAS persona descendencia  | persona;

persona: fallecido
       | NOMBRE
       |  ;

fallecido : NOMBRE FALLECIDO ;

MAS: '+' ;
LPAR: '{' ;
RPAR: '}' ;
COMA: ',' ;
FALLECIDO: '#';
NOMBRE: [A-Za-z]+ ;

WS: [ \r\n\t] -> skip;