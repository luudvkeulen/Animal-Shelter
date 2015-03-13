# Dierenasiel - Week 5

Eerder heb je Dierenasiel I en Dierenasiel II gemaakt. Je gaat deze nu
aanpassen. Allereerst ga je de opdracht Animals met de abstracte klasse Animals
integreren in deze applicatie (zie de opgavenbundel, opdracht 7.4.1). Pas
hiervoor je klassendiagram aan. Neem het klassendiagram dat in week 3 gegeven
is bij de animal shelter opgave en breid deze uit.

Vervolgens moet er een interface `Prijsbaar` worden toegevoegd aan dit
klassendiagram. Het asiel heeft geld nodig om alle dieren te voeren en gaat
daarom dieren in het asiel verkopen i.p.v. weggeven. Maak een interface die
dieren *prijsbaar* maakt. Ofwel: elk dier dat deze interface implementeert moet
een `Price` property hebben.

De prijs van een hond wordt anders berekend dan de prijs van een kat:

 * Voor honden is de prijs afhankelijk van hun chipnummer. Is het chipnummer
   kleiner dan 50.000, dan is de prijs 200,00 euro en anders is de prijs 350,00
   euro.
 * Voor katten is de prijs afhankelijk van de extra informatie, die bijgehouden
   wordt. In het algemeen geldt: hoe meer extra informatie, hoe meer negatieve
   opmerkingen over die kat en dus hoe lager de prijs. De prijs van een kat is
   gelijk aan "60,00 euro min de lengte van de string met de extra informatie
   over die kat". Mocht dit minder dan 20,00 euro zijn, dan is de prijs 20,00
   euro.

Teken eerst het nieuwe klassendiagram met je gemaakte interface daarin. Maak de
klassen die abstract kunnen zijn ook daadwerkelijk abstract en geef dit ook in
het klassendiagram aan. Gebruik vervolgens in de applicatie de nieuwe
functionaliteit.

