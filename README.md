# Unity2020.3.18f1-README-Template

### Projektbeschreibung: 
Wir haben ein 2D Spiel entwickelt. ZieL des Spieles ist im Weltall so schnell wie möglich 10 Aliens zu treffen.

### Entwicklungsplattform: 
Windows 10, Unity 2020.3.18f1, Visual Studio Version 2019 Community

### Zielplattform: 
die Spielbare Version:
https://3ahmns2122mtin.github.io/12BNSOMMER-UE02-shootingisland/

### Visuelle Einblicke in das Projekt:
![ShootinIsland](https://user-images.githubusercontent.com/90834410/144325078-1ad854d9-f7cb-4fc4-bbfd-152a82c76c47.png)

### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Hintergrund:
https://www.google.com/url?sa=i&url=https%3A%2F%2Fpixabay.com%2Fde%2Fillustrations%2Fraum-himmel-textur-hintergrund-2294795%2F&psig=AOvVaw3W5yzM4iZ89rz9QGNi5WFm&ust=1638480878512000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLiq2YvHw_QCFQAAAAAdAAAAABAT

Target:
https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.teepublic.com%2Fsticker%2F21447546-green-alien-head-with-big-black-eyes&psig=AOvVaw3ufGB3SMJZ7SfsKMyhoyk5&ust=1638481070194000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCODrl-fHw_QCFQAAAAAdAAAAABAJ

won font:
https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.vectorstock.com%2Froyalty-free-vector%2Falphabet-modern-font-space-typeface-minimalist-vector-22508891&psig=AOvVaw2MfT6oDDjRbxlQzhOAIJxG&ust=1638480818989000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLi-3-vGw_QCFQAAAAAdAAAAABAD

sounds:
https://www.youtube.com/watch?v=FuvmTL1nPDs
https://www.youtube.com/watch?v=yPVQRyMtnpI
https://www.youtube.com/watch?v=xeU9RkQRVEM

### Anforderungsliste:  
 
  WebGL export/upload lauffähig/spielbar

 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen

 In Assets Folder MyGame anlegen.

 Den Ordner Scenes in Assets > MyGame ziehen

 Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene

 Ein Canvas GameObject anlegen.

 Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.

 In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.

 In Asstets > MyGame den Folder Sprites anlegen.

 Ein Hintergrund Sprite reinladen.

 In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.

 Das Image ggf. positionieren und größentechnisch anpassen.

 Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen.

 Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag.

 Das empty GameObject umbenennen in ParentTargets.

 in Assets > MyGame > Prefabs Folder anlegen.

 Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.

 Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen.

 Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die

 Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen.

 In Assets > MyGame einen neuen Ordner anlegen Scripts

 In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio.

 Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop).

 Einen 2D Collider als Komponente dem Target hinzufügen.

 Dem Script Target eine Methode OnMouseDown() hinzufügen.

 In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen

 Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen.

 In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen.

 Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.

 Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.

 Projekt etwas verschönern (EndSound, Extratext(Mission))
 
Copyright by BNSOMMER
