# Informations du projet

Ce projet **WinForm** a été réalisé en **C#** avec **EntityFramework** associé à une base de données SQL Server.


# Objectif de l'application

L'application  a  pour  but  de  manipuler  et  de  visionner  les  informations  d'une  base  de  données concernant des hôtels.

## Fonctionnalités

L'application permet de :
- Se connecter à un hôtel.
- Modifier les informations (coordonnées, équipements, ...) de l'hôtel connecté.
- Ajouter/Supprimer des chambres de l'hôtel connecté.
- Visionner et Modifier des réservations de l'hôtel connecté.
- Créer des réservations (Nom, Mail, Chambres disponibles à réserver)

## Schéma relationnel de la base de données exploitée

Image bdd

## Visuels de l'interface de l'application

Images appli

# Installation

## Comment joindre la base de données du projet ?

*Explication pour Microsoft SQL Server Management Studio*
--> Récupérez les fichiers .mdf et .ldf de la base de données.
Dans MSSMS, faites *clic-droit* sur "**Bases de données**" -> "**Joindre**" -> "**Ajouter**" -> *sélectionnez le fichier .mdf*-> Enfin, cliquez sur "**Ok**".

## Comment lier une base de données au projet ?

Dans le dossier du projet, ouvrir le fichier "**App.config**".
--> Cherchez la balise suivante :

    <connectionStrings>
	    ...
    </connectionStrings>

 --> Dans cette balise, modifier le nom du serveur et de l'instance suivant le paramètre "***data source=***" par votre propre serveur et instance

    <add name="connexiondb" 
	    ...
	    data source=VGTOM\SQLSERVEREXPRESS;
	    ...
    />

Si vous lancez directement le .exe situé dans  "`bin/Debug/`", réalisez la même opération mais dans le fichier  "**AP-HOTEL-APPLI.exe.config**".
