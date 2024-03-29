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

![](imagesProjet/schema_bdd.png)

## Visuels de l'interface de l'application

### Interface d'accueil :
![](imagesProjet/APPLI_HOTEL_accueil.png)

### Interface de gestion des informations hôtel :
![](imagesProjet/APPLI_HOTEL_info.png)

### Interface de gestion des chambres :
![](imagesProjet/APPLI_HOTEL_chambre.png)

### Interface de visualisation et d'édition des réservations :
![](imagesProjet/APPLI_HOTEL_visuRes.png)

### Interface de création de réservation :
![](imagesProjet/APPLI_HOTEL_addRes.png)

# Installation

## Comment importer la base de données du projet ?

*Explication pour Microsoft SQL Server Management Studio*
--> Récupérez le [fichier .bak](https://github.com/vgtom4/SIO2-AP-HOTEL-APPLI/blob/master/DataBase/bdhotel_lepers-vieillard.bak) de la base de données.
Dans MSSMS, faites *clic-droit* sur "**Bases de données**" -> "**Restaurer la base de données...**" -> cochez "**Support**" -> cliquez sur "**[...]**" -> "**Ajouter**" -> *sélectionnez le fichier .bak*-> Enfin, cliquez sur "**Ok**" puis "**Ok**".

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
