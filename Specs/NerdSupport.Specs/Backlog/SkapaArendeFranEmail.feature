Egenskap: Skapa ärende från e-mail

	För att underlätta för kunder
	Som system
	Så ska de kunna skicka in e-mail som genererar ett ärende

Scenario: Skapa nytt ärende
	Givet följande e-mail
	
	| Ämne             | Brödtext           |
	| Problem med Lync | Hjälp det är panik |
	
	När Hans skickar in detta
	Så ska ett nytt ärende skapas upp

Scenario: Uppdatera befintligt ärende mha id i ämnesrad
	Givet följande email
	| Ämne				  | Brödtext		    |
	| Mer problem med 502 | Återigen problem :( |
	
	Och att följande ärenden redan finns registrerade
	| Id  | Ämne                | Beskrivning         |
	| 502 | Mer problem med 502 | Återigen problem :( |
	
	När Greta skickar emailet
	Så ska det befintliga ärendet uppdateras

Scenario: Mail med id utan befintligt ärende
	Givet följande email
	| Ämne              | Brödtext                  |
	| 602 fungerar inte | Mitt tangentbord är borta |

	Och att det inte finns något befintligt ärende med id 602
	När Greta skickar emailet
	Så ska inget ärende skapas
	