# MouseController
Aplikacja pozwala na wyzwalanie zdefiniowanych wcześniej działań myszą w zależności od tego, czy na ekranie są widoczne interesujące nas obszary 

### Areas Manager
Okno służące do zarządzania obszarami, które zamierzamy obserwować. Umożliwia dodanie do listy nowych obszarów, zapewnia ich podląd oraz przechowuje w obiekcie typu Area:
 - bitmape z którą podczas pracy porównujemy konkretny wycinek naszego ekranu
 - współrzędne rejestrowanego obszaru
 
### Activity Manager 
Część aplikacji służąca do definiowania aktywności - zbioru czynności (akcji), które zostaną wykonane po pojawieniu się przypisanego im obszaru.
Aktualnie dostępne są dwie akcje myszy: click i move.

### Conditions Manager
Okno służące do powiązania obszarów ze zdefiniowanymi aktywnościami wyzwalanymi po ich rozpoznaniu

TO DO:
 - 
 - właściwa praca aplikacji - sprawdzanie obszarów i wyzwalanie związanych z nimi aktywności.

LAST COMMIT:
- wczytanie ustawień użytkownika, zapewnienie deserializacji json do obiektu WorkProfile
