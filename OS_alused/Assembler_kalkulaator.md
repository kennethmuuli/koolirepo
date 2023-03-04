		MOV DL, C0
		MOV CL, 80

	Rep1:
		IN 00
		MOV [DL], AL
		SUB AL, 30
		MOV [CL], AL
		INC DL
		INC CL
		CMP CL, 82
		JZ Sum1
		JMP Rep1

	Sum1:
		MOV BL, [80]
		MUL BL, 10
		ADD AL, BL	
		MOV [CL], AL
		MOV [DL], AL

		MOV CL, 83

	Rep2:
		IN 00
		MOV [DL], AL
		SUB AL, 30
		MOV [CL], AL
		INC DL
		INC CL
		CMP CL, 85
		JZ Sum2
		JMP Rep2

	Sum2:
		MOV BL, [83]
		MUL BL, 10
		ADD AL, BL
		MOV [CL], AL	
		MOV [DL], AL

	SumTotal:

		INC DL
		INC CL
		MOV BL,	[82]
		PUSH AL POP BL
		MOV BL,	[85]
		ADD AL, BL
		MOV [CL], AL
		MOV [DL], AL

	END
