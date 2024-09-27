# Lern-Periode 6
# Ihor Tienietilov
# 16.08.2024 bis 27.09.2024

## fertiges Projekt
a little audio track visualizer.
created with blood and sweat.
basic information was taken from Peer Play's tutorials.
![github_visualisation](https://github.com/user-attachments/assets/fb474396-7af8-48b9-ba1c-af2d81bb88e2)
- https://youtu.be/pxsvwGzfbiQ

## 23.08
- [x] Auswahl einer Programmiersprache (JavaScript / C#).
- [x] Video-Tutorials ansehen.
- [x] Video-Referenzen ansehen.
- [x] Verschiedene Dokumentationen ansehen.

Ich habe heute einige Nachforschungen zu diesem Thema angestellt. Mein erster Gedanke war, weiter an meiner Website zu arbeiten, sie in irgendeiner Weise zu verbessern oder ihr etwas hinzuzufügen, aber das habe ich schnell verworfen, weil ich mich entschlossen habe, etwas Neues und Anderes zu machen. Auf Anraten von Herrn Colic beschloss ich, meine beiden Interessen - Musik und Programmieren - zu kombinieren. Also wandte ich mich als erstes der künstlichen Intelligenz zu, nämlich Gemini. Er gab mir ein paar Ideen, wie ich diese Hobbys kombinieren könnte, und ich entschied mich für die folgende - einen 3D-Audio-Visualisierer in C# auf der Grundlage von Unity zu erstellen. Ich suchte lange nach einer geeigneten Referenz und einem Tutorial, das mir bei meiner Arbeit helfen würde, und schließlich wurde ich fündig und erstellte sogar ein Projekt in Unity.

## 30.08
- [x] Modell eines Ikosaeders finden
- [x] Modell des Ikosaeders herunterladen
- [x] Schreiben einen Code zum Verfolgen (oder Magnetisieren) kleiner Kugeln zum Ikosaeder
- [x] Testen diesen Code
Heute war ein äußerst effizienter Tag, an dem ich eine Menge geschafft habe. Als erstes habe ich das Isokaeder-Modell installiert und in Fortsetzung des Tutorials den ersten Code geschrieben, der es kleinen Kugeln (eigentlich Isokaedern) ermöglicht, einer unsichtbaren Kugel zu folgen. Außerdem habe ich die Möglichkeit implementiert, die Kraft- und Schwellenparameter für „Magnetismus“ zu ändern.
Der nächste Schritt bestand darin, die Logik der Audiovisualisierung selbst zu schreiben - wie viele Kugeln sich bewegen würden, welchen Regeln sie folgen würden und so weiter und so fort. Das Ergebnis ist, dass das Programm beim Einschalten automatisch 64 Isokaeder auf jeder der acht Kugeln erzeugt, die für sie Magnete sind.
Gegen Ende begann ich, mich speziell mit der Logik von Audio zu beschäftigen - wie genau das Spektrum der Frequenzen in Audio angezeigt und verarbeitet werden würde.

## 06.09
- [x] Theoretische Berechnung eines geeigneten Frequenzspektrums auf der Grundlage von Audio
- [x] Praktische Berechnung eines geeigneten Frequenzspektrums auf der Grundlage von Audiodaten (schreiben einen Code dafür)
Heute war kein sehr produktiver Tag, denn mein Internet war unterbrochen und ich musste mein mobiles Internet nutzen, um arbeiten zu können. Aber am Ende habe ich es geschafft, wie erwartet zwei Arbeitspakete fertigzustellen, in denen ich die Logik für die Berechnung von Frequenzen und deren weitere Verwendung geschrieben habe.

## 13.09
- [x] Schreiben einer Methode zur Ermittlung der durchschnittlichen Amplitude
- [x] Schreiben einer Methode für ein Audioprofil
- [x] Schreiben einer Methode zur Erzeugung von Stereo- statt Monoton
- [x] Schreiben einer Methode für 64 Audiobänder
Heute war ein äusserst produktiver Tag, dank dem ich die Hauptklasse des gesamten Projekts – AudioPeer – schnell und erfolgreich abgeschlossen habe. Heute habe ich die Berechnung der durchschnittlichen Amplitude, des Audioprofils, des Stereo- statt Mono-Tons sowie weiterer 64 Audiobänder abgeschlossen. Jetzt habe ich nur noch sehr wenig Zeit und kann mich an schönen und ansprechenden Musikvisualisierungen erfreuen.

## 20.09
- [x] Hinzufügen von Methoden aus der AudioPeer-Klasse zur Hauptcodedatei.
- [x] Implementierung der Ballbewegungslogik
- [x] Reaktionsfähigkeit der Musik beim Schreiben von Bällen
- [ ] Kosmetische Änderungen und Ergänzungen (Shader usw.)
Heute war ein ziemlich effizienter Tag, ich konnte das erledigen, was ich zu erledigen hatte. Es gibt nur ein Problem.

Ich habe also weiter an dem Hauptcode gearbeitet, der für die Erstellung und Bewegung der Kugeln verantwortlich ist, die die Musik visualisieren. Schließlich konnte ich die AudioPeer-Klasse einbinden, aber leider bin ich auf zwei Fehler gestoßen, für deren Behebung ich etwa zwei Stunden gebraucht habe. Der erste Fehler war ein „Array-Exit“-Fehler, den ich beim Schreiben eines der for-Zyklen machte. Und der zweite Fehler war, dass ich vergessen hatte, „static“ für einige Variablen anzugeben, was den Fehler verursachte.
Am Ende habe ich die Fehler behoben und die Visualisierung läuft, allerdings vorerst ohne Shader. Leider war das Ergebnis ekelerregend. Das war ganz und gar nicht das Ergebnis, das ich erwartet hatte, und am Ende beschloss ich, es am Ende von LernPeriode 6 selbst zu beheben, da ich bereits den grundlegenden Code für die Musikvisualisierungslogik habe und alles, was noch übrig ist, ist die Visualisierung selbst.

Ich habe einfach anfangs eine zu komplizierte Visualisierung genommen, die ich am Ende nicht hinbekommen habe, also habe ich beschlossen, eine einfachere zu machen, mit der gleichen Logik für die Visualisierung selbst, die ich schon habe.

## 27.09
- [x] Wählen die Art der Visualisierung
- [x] Code zum Erstellen von Objekten (Prefabs) schreiben
- [x] Schreiben Code, um Musik zu visualisieren.
Heute war ein extrem effizienter und schneller Tag - ich habe erfolgreich und ohne grosse Schwierigkeiten eine leichtere Version des Visualisierungsprojekts erstellt, indem ich 64 reguläre Würfel als Basis genommen und ein paar Zeilen Code geschrieben habe, um sie von der AudioPeer-Klasse abhängig zu machen. Kurz gesagt, die Skala jedes Würfels ändert sich im Verhältnis zu dem entsprechenden Band.

## Reflexion
Dies war ein äusserst interessantes Projekt für mich.

Erstens habe ich Unity3D entdeckt. Davor hatte ich ausschliesslich mit Unity2D gearbeitet. Ausserdem weiss ich jetzt viel, viel mehr darüber, woraus Sound eigentlich besteht, was mir sogar beim direkten Erstellen von Musik helfen kann. Ausserdem bin ich mit dem Programmieren trivialerweise wieder auf dem gleichen Stand wie früher und habe schon eine Idee für mein nächstes Projekt.

Der Entstehungsprozess selbst war extrem schwierig und mühsam, weil ich mir anfangs eine Aufgabe gestellt habe, die für mich unmöglich war (und wie immer habe ich alles im letzten Moment geändert), aber trotz der enormen Dumpfheit, die überall herrschte, habe ich gelernt, mit komplexem Code leichter umzugehen, den man verstehen muss und nicht nur lesen kann.
