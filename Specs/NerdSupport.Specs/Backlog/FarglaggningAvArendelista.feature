Egenskap: Färgläggning av ärenden i lista

För att kunna överskåda vad jag ska jobba med
Som en handläggare
Så vill jag en färgkodad lista som hjälper mig att prioritera

@arendelista @currentiteration

Scenario: Ärende med prio 1
	Givet ett ärende med prio 1
	Och att prio 1 kodas med röd färg
	När handläggaren listar ärenden
	Så har ärendet röd färg


Scenario: Sortering
	Givet följande ärenden
	
	| Ärende  | Prioritetsklassificering |
	| viktigt | 1						 |
	| mindre  | 2						 |
	
	När handläggaren listar ärenden
	Så ska "viktigt ärende" vara överst
	Och "minst viktigt ärende" ska vara underst

