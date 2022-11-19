grammar arbolGenealogicoV2;

program: descendencia EOF;

descendencia: LPAR hijos RPAR ;

hijos: matrimonio (COMA matrimonio)* ;

matrimonio: hijo=persona MAS conyugue=persona descendencia #familia | persona #jamon;

persona: NOMBRE FALLECIDO  #fallecido
       | NOMBRE            #vivo
       ;

MAS: '+' ;
LPAR: '{' ;
RPAR: '}' ;
COMA: ',' ;
FALLECIDO: '#';
NOMBRE: [A-Za-z]+ ;

WS: [ \r\n\t] -> skip;