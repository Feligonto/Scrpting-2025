# 3

Realizar los retos de manejo de terminal de la siguiente pagina:

[**Comand Challenge**](https://cmdchallenge.com/)

## Evidencia

<img width="1508" height="753" alt="image" src="https://github.com/user-attachments/assets/2b9e76ac-0183-494f-84ef-c0c3e2259dbf" />


### ¿Qué es un directorio?

En el contexto de la programación, un directorio (también conocido como carpeta) es una estructura jerárquica que organiza archivos y otros directorios en un sistema de archivos. Esencialmente, es un contenedor virtual que permite agrupar elementos relacionados, facilitando la organización y gestión de la información en un sistema informático.

#### Create a directory named tmp/files in the current working directory

En sistemas operativos tipo Unix/Linux (como Ubuntu, macOS, etc.), puedes usar el comando mkdir para crear directorios.

- Si intentas hacer mkdir tmp/files pero tmp/ no existe, te dará un error.

Para crear toda la ruta completa de una vez, debes usar la opción -p:

#### ¿Qué hace -p?
-p (de "parents" => dirección de archivos “padre”, es decir la carpeta que contiene a otra) le dice a mkdir que:

- Cree los directorios padres que hagan falta (como tmp/).
- No marque error si alguno ya existe.
<img width="1397" height="136" alt="image" src="https://github.com/user-attachments/assets/4b87b8d4-9e7d-41d7-b1fa-a51dd0e32973" />

#### Ejemplo:
<img width="1416" height="606" alt="image" src="https://github.com/user-attachments/assets/8f93ac12-c16b-4de5-b860-cc04e2826499" />
