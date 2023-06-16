# Aplicatie_PIU
##Aplicatia de evidenta a Angajatilor unei firme de IT

Aceasta este o aplicatie simpla in care administratorul firmei isi poate inregistra angajati.

Aplicatia **Windows Form** utilizatorul/administratorul ce foloseste aplicatia, ii sunt prezentate urmatoarele optiuni:

1. Numele Angajatului.
2. Prenumele Angajatului.
3. Selectarea Specializarii.
4. Butonul de Adaugare a unui angajat.
5. Butonul de Afisare angajat.
6. Un **richTextBox** unde se va afisa cum sunt salvati Angajatii.
7. Iar in dreapta acestor Optiuni fiecare camp pentru Nume, Prenume, Specializare sub forma de tabel.


Pentru aplicatia de tip **Terminal** utilizatorul are o serie de optiuni:

1. I. Introducere informatii angajat
2. A. Afisarea ultimului angajat introdus
3. F. Afisare angajati din fisier
4. S. Salvare angajat in fisier
5. X. Inchidere program

Pentru implementarile acestora, am folosit 
1. EvidentaAngajati_Consola
2. EvidentaAngajati_UI_WindowsForms
3. LibrarieModele
4. NivelStocareData

Clasa de baza este Angajat, iar salvarea datelor se face in documentul **Angajati.txt**. Datele se salveaza ca un sir de caractere cu separatorul **";"** intre fiecare variabila existenta, pentru a putea manipula datele mai usor.
Datele introduse in textBox-urile din UI form, sunt luate ca stringuri si avem posibilitatea de a alege specializarea dintr-un set de **radioButton-uri**, daca sunt introduse datele, iar nici un **radioButton-uri** nu este selectat atunci se va primi un **mesajBox**, unde i se va atrage atentia asupra faptului ca trebuie selectat o specializare.
