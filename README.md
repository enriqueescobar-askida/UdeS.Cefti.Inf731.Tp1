# UdeS.Cefti.Inf731.Tp1

## Énoncé du problème

Un organisme de charité vous demande de concevoir une application qui
permettra de faire un rapport sur les dons reçus des donateurs au fil des ans, afin
d’avoir un portrait plus clair de la stratégie à adopter pour solliciter les donateurs
lors de la prochaine campagne de financement.

L’organisme a cumulé, au fil des ans, un fichier qui contient des données brutes.
On y retrouve, sur une ligne, un numéro de donateur qui a été assigné par
l’organisme, l’année du don ainsi que le montant de ce don. Le programme que
vous écrirez ne saura pas, au point de départ, combien il y a de lignes dans le
fichier. Votre programme devra donc faire le nécessaire pour réserver l’espace
requis pour représenter les différents dons durant le cours de l’exécution.

Les données à traiter seront inscrites dans un fichier en mode texte. Votre
programme devra lire le fichier en entier, organiser les données et les traiter en
fonction

## Réalisation du travail

Le programme que vous devez réaliser doit être écrit en Microsoft Visual C#1 en
utilisant au mieux les concepts de la programmation orientée objet que nous
avons vus et verrons dans le courant des prochaines semaines. Ce travail fait
appel à de nombreuses notions que nous voyons durant les huit premières
rencontres du cours – création d’une classe, création d’instances, propriétés,
construction, composition, création de tableaux ou utilisation d’une collection,
gestion des exceptions, méthode de classe, etc.

Il y a aussi la question de la lecture et de l’écriture dans des fichiers, mais cette
difficulté est somme toute assez minime et une courte explication en classe
assortie d’un exemple ou deux suffira à vous informer de la manière de procéder.

### Format des données

Les données qui décriront sur une ligne le don qui a été fait par un donateur
seront :

- Un numéro de donateur, qui a été assigné par l’organisme. Il s’agira d’une
chaîne de caractères sans espace (par exemple, on pourrait avoir la chaîne
A-12345 qui a été assignée comme numéro de donateur, ou encore 123-
789 par exemple); il n’y a pas de règle particulière qui s’applique au
numéro de donateur outre l’absence d’espace;
- L’année du don, un entier de 4 chiffres. L’organisme ayant été créé en
1996, aucune année ne peut être plus petite que cette valeur. Puisque nous
sommes en 2017, il ne sera pas possible non plus de trouver une année
plus grande que 20172;
- Le montant du don, qui doit être strictement positif, c’est-à-dire plus
grand que 0.


