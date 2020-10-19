grammar MyExel;

/*
* Parser Rules
*/

compileUnit : expression EOF;

expression :
	LPAREN expression RPAREN #ParenthesizedExpr
	| NOT expression #NotExpr
	| expression operatorToken=(MULTIPLY | DIVIDE | DIV | MOD) expression #MultiplicativeExpr
	| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
	| expression operatorToken=(GREATER | LESS | EQUAL) expression #LogicalExpr
	| operatorToken=(MIN | MAX) LPAREN expression COMMA expression RPAREN #MinMaxExpr
	| IDENTIFIER #IdentifierExpr
	| NUMBER #NumberExpr	
	;


/*
* Lexer Rules
*/

NUMBER: INT('.' INT)?;
IDENTIFIER: ['R']+[1-9]+['C']+[1-9]+;

INT :('0'..'9')+;

LPAREN: '(';
RPAREN: ')';
NOT: 'not';
MULTIPLY: '*';
DIVIDE: '/';
MOD: 'mod';
DIV: 'div';
SUBTRACT: '-';
ADD: '+';
GREATER: '>';
LESS: '<';
EQUAL: '=';
MIN: 'min';
MAX: 'max';
COMMA: ',';




WS: [ \t\r\n] -> channel(HIDDEN);
