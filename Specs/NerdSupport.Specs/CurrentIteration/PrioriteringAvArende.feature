Egenskap: Prioritering av arenden

För att undvika vite
Som handläggare
Vill jag att prioriteringen av ärenden räknas ut åt mig

@prioritering @currentiteration

Bakgrund:
Givet att ett serviceavtal har regler med följande prioritetsklass

  | Regel | Prioritet | 
  | Vip   | 1		  | 
  | Pris  | 2		  | 
  | Tid	  | 3		  |

Scenario: En regel är bruten
	Givet att Vip regel bryts
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering 2

Scenario: Alla regler är brutna
	Givet att alla regler är brutna
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering 1

Scenario: Inga regler brutna
	Givet att inga regler är brutna
	När handläggaren granskar ärendets prioritet
	Så är ärendets prioritetsklassificering 0