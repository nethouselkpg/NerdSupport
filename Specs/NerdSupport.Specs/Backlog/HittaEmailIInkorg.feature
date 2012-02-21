Egenskap: Filtrera e-mail i inkorg

	För att undivka att onödiga ärenden skapas upp
	Som system
	Vill jag att endast att utvalda e-mail genererar ärende i systemet

@e-mail

Scenario: Avsändare finns ej registrerad
	Givet att Ove inte finns registrerad som användare
	När Ove skickar in ett e-mail
	Så ska det inte skapas ett ärende

Scenario: Flera likadana mail
	Givet att Hans redan har skickat in ett ärende via mail
	När Hans skickar samma mail en gång till
	Så ska det inte skapas ett ärende

