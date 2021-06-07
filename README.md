# Projekt AI 3D Ballance Ball

1.Czym jest Unity ML-Agents Toolkit?
  
Jest to open-sourcowy projekt, który pozwala grom i symulacjom służyć jako środowisko do trenowania inteligentnych agentów.
  Dostarcza on implementację ( opartą o PyTorch ) algorytmu, który z łatwością  umożliwia trenowanie agentów dla 2D, 3D oraz VR
  gier. Wytrenowani agenci mogą  być używani w wielu celach, w tym do kontrolowania zachowania NPC, zautomatyzowanego testowania 
  kompilacji gier i oceny różnych decyzji dotyczących projektu gry przed wydaniem. Zestaw narzędzi ML-Agents Toolkit jest korzystny
  zarówno dla twórców gier, jak i badaczy sztucznej inteligencji, ponieważ zapewnia centralną platformę, na której AI można oceniać
  w bogatych środowiskach Unity, a następnie udostępniać szerszej społeczności badaczy i twórców gier.
 
2.Jakie modele są  wykorzystane w ML-Agents?

  ML-Agents posiada modele takie jak wsparcie szkolenia scenariuszy z jednym agentem, z wieloma współpracownikami i rywalizacją z wieloma agentami za pomocą kilku algorytmów Deep Reinforcement Learning (PPO, SAC, MA-POCA, samodzielna gra).  Wsparcie uczenia się z demonstracji poprzez dwa algorytmy Imitation Learning (BC i GAIL).
Łatwo definiowalne scenariusze Curriculum Learning dla złożonych zadań

Wszyscy agenci zostali wytrenowani przeze mnie za pomocą modelu PPO (Proximal Policy Optimization). Algorytm PPO został wprowadzony przez zespół OpenAI w 2017 roku i szybko stał się jedną z najpopularniejszych metod RL uzurpujących sobie metodę uczenia Deep-Q. Polega on na zebraniu niewielkiej partii doświadczeń wchodzących w interakcję ze środowiskiem i wykorzystaniu tej partii do aktualizacji polityki podejmowania decyzji. Po zaktualizowaniu zasad przy użyciu tej partii, są one odrzucane, a nowsza partia jest zbierana z nowo zaktualizowanymi zasadami. To jest powód, dla którego jest to podejście oparte na „on-policy”, w którym zebrane próbki doświadczeń są przydatne tylko do jednorazowej aktualizacji obecnej polityki.

3.Środowisko 3D Balance Ball zawiera wiele kostek i kul agentów (które są kopiami siebie nawzajem). Każda kostka agenta stara się zapobiec upadkowi swojej kuli, obracając się w poziomie lub w pionie. W tym środowisku kostka agenta jest agentem, który otrzymuje nagrodę za każdy krok, w którym równoważy piłkę. Agent jest również karany negatywną nagrodą za upuszczenie piłki. Celem procesu szkoleniowego jest nauczenie agentów balansowania piłką na głowie.
  
4.Przykład źródłowy( bez modyfikacji środowiska) z przetrenowanym przeze mnie agentem.

https://user-images.githubusercontent.com/36816150/120990843-4ce95200-c781-11eb-9a10-222e1e481c29.mp4

5.Zmiana grawitacji środowiska.
Aby zmienić grawitację środowiska, należy zmienić ustawienia w projekcie.
![image](https://user-images.githubusercontent.com/36816150/120994804-2200fd00-c785-11eb-99f2-27d0ef685907.png)

a) Standardowy agent vs 10x gravity


https://user-images.githubusercontent.com/36816150/121001381-858e2900-c78b-11eb-80ad-454d2505cf87.mp4


b) agent dla 10x gravity

https://user-images.githubusercontent.com/36816150/120996835-fbdc5c80-c786-11eb-9e9a-f653456107aa.mp4


c) agent 10x gravity vs 100x gravity

https://user-images.githubusercontent.com/36816150/120998182-211d9a80-c788-11eb-9c85-9b66a58945fc.mp4

d) agent dla 100x gravity

https://user-images.githubusercontent.com/36816150/120998976-e405d800-c788-11eb-8d80-8b3e7cb32f3a.mp4

e) agent 100x vs 10x gravity

https://user-images.githubusercontent.com/36816150/120999977-02200800-c78a-11eb-9faf-28d5656d4bb3.mp4


f) agent 100x vs 1x gravity


https://user-images.githubusercontent.com/36816150/121000698-cdf91700-c78a-11eb-96aa-c6fecce49139.mp4


6.Dodatkowa siła działająca na piłkę

Zostało to zrealizowane za pomocą WindZone w unity, korzystając dodatkowo z 2 skryptów, pierwszy z nich generuje losowy
kierunek "wiatru", czyli siły, drugi natomiast pozwala tej siłe działać na  obiekt czyli naszą piłkę. Dodatkowo zauważyłem problem
w przypadku, gdy piłka ze startowej pozycji może od razu wylecieć poza obszar sześcianu, więc obniżyłem pozycję startową piłki aby
zmniejszyć szansę na wystąpienie takiej sytuacji.

Kierunek działania siły zostaje wylosowany na starcie i się nie zmienia. Siła ta jest domyślnie pulsująca z pewną częstotliwością, co nie ma większego znaczenia dla agenta.

![image](https://user-images.githubusercontent.com/36816150/121003146-7a3bfd00-c78d-11eb-81af-868abc826323.png)


a) agent vs windzone


https://user-images.githubusercontent.com/36816150/121007696-6b0b7e00-c792-11eb-8f90-ca1b2bf8d6be.mp4

b) agent windzone

Po problematycznym starcie i kilku upadkach w przypadku trudnych sytuacji, agent jest w stanie ustabilizować sytuację.

https://user-images.githubusercontent.com/36816150/121015641-7e6f1700-c79b-11eb-81eb-e96c97a67509.mp4


https://user-images.githubusercontent.com/36816150/121016293-3d2b3700-c79c-11eb-8aa6-f840fd405c91.mp4


https://user-images.githubusercontent.com/36816150/121019086-6600fb80-c79f-11eb-99fd-ecb26339b18f.mp4



7. Wykres treningu agentów

Można zauważyć, że trenowanie agentów w trudniejszych warunkach potrzebowało więcej czasu dla osiągniecia optymalnych rezultatów.
Dla treningu z dodatkową siłą można zauważyć 2 ogromne spadki co mogło być spowodowane sytuacją w której wylosowany kierunek siły
uniemożliwiał agentowi zrobienie czegokolwiek, aby utrzymać piłkę.
![image](https://user-images.githubusercontent.com/36816150/121016648-ad39bd00-c79c-11eb-9365-f9dcc88068e2.png)

9.Instalacja

  -Zainstalowanie pakietu ML-Agents https://github.com/Unity-Technologies/ml-agents/blob/release_17_docs/docs/Installation.md

  -Podmiana plików z gita w ML-Agents/Examples/3DBall







