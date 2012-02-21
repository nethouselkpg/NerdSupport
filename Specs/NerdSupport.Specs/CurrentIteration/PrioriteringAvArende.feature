Egenskap: Prioritering av arenden

För att undvika vite
Som handläggare
Vill jag att prioriteringen av ärenden räknas ut åt mig

@prioritering @currentiteration

Bakgrund:
Givet att följande regler är kopplade till Nethouse avtal	

| Namn | Prioritetsklassificering |
| Tid  | 3						  |
| Pris | 1					      |
| VIP  | 2						  |

Scenario: En regel är bruten
	Givet att VIP regeln bryts
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering 2

Scenario: Alla regler är brutna
	Givet att alla regler är brutna
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering 1

Scenario: Inga regler brutna
	Givet att inga regler är brutna
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering nollställd