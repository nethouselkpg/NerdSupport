Egenskap: VIsa fraga

För att säkerhetsställa att frågor blir besvarade i tur och ordning
Som Nörd
Ska jag bara se den högst prioriterade frågan

@currentIteration

Scenario: Visa fråga med högst prio
	Givet att följande frågor finns
	| Fråga              | Prioritet |
	| Hur uttalas Azure? | 23        |
	| Vad är molnet?     | 10        |

	När Nörden navigerar till sidan för att besvara frågor
	Så ser nörden frågan om "Hur uttalas Azure?" eftersom att den har högst prioritet

Scenario: När två frågor har samma prioritet
	Givet att följande frågor finns
	| Fråga                                                  | Inskickad  | Prioritet |
	| Kommer Microsoft ge bort WP7 som giveaway på techdays? | 2012-04-15 | 42        |
	| Varför används inte Windows ME längre ?                | 2000-03-02 | 42        |

	När Nörden navigerar till sidan för att besvara frågor
	Så ser nörden frågan om "Varför används inte Windows ME längre ?" eftersom att den är äldst