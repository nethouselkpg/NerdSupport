Egenskap: Prioritering av frågor

För nörden ska vara på rätt fråga
Som system
Ska jag räkna ut prioriteringen på frågorna enligt ett regelsystem

@prioritering @currentiteration

Bakgrund:
Givet att ett serviceavtal har följande SLA regler

  | Namn						| Prioritet | 
  | 8 timmars regeln			| 1			| 
  | Dygnsregeln					| 5			|
  | VIP avsändar regeln			| 78		|

Scenario: Beräkna prioritet när en av SLA reglerna bryts
	Givet att "8 timmars regeln" inte uppfylls
	När Systemet beräknar frågans prioritet
	Så är frågans prioritet 1

Scenario: Beräkna prioritet när flera SLA regler inte uppfylls
	Givet att "8 timmars regeln" inte uppfylls
	Och att "Dygnsregeln" inte uppfylls
	När Systemet beräknar frågans prioritet
	Så är frågans prioritet 6

Scenario: Inga regler brutna
	Givet att inga regler är brutna
	När Systemet beräknar frågans prioritet
	Så är frågans prioritet 0