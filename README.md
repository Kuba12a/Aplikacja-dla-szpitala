Aplikacja do obsługi pacjentów i lekarzy. Projekt składa się z kilku mikrousług, wystawiających styki REST. Dane z nich są pobierane przez inne "wyższe mikrousługi" i "zaciągane".
Na tę chwilę mamy 2 mikrousługi danych(posiadają one dane o lekarzach, pacjentach, wizytach, klinikach), 2 mikrousługi aplikacyjne pobierające dane z mikrousług danych
oraz robiące na nich operacje(w naszym przypadku będzie to parowanie lekarza z pacjentem do danej wizyty w danej klinice, w mikrousługach aplikacyjnych mamy możliwość
wyświetlania wizyt danego lekarza oraz pacjentaw zależności od mikrousługi aplikacyjnej).
Ostatnią mikrousługą jest klient pobierający dane z mikrousług aplikacyjnych oraz wyświetlający dane w przyjemnej dla człowieka formie.
Projekt wykonywany jest w zespole 4-osobowym.
