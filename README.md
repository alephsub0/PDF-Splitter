
<a name="readme-top"></a>

<!-- PROJECT SHIELDS -->
[![Colaboradores][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/alephsub0/PDF-Splitter">
    <img src="src/PDF Splitter/PdfSplitterIcon.ico" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">PDF Splitter</h3>
  <p align="center">
    Herramienta de AlephSub0 para dividir un archivo PDF dada la configuración en un archivo CSV.
    <br />
    <a href="https://go.alephsub0.org/PDFSplitter"><strong>Más Información »</strong></a>
    <br />
    <br />
    <a href="https://go.alephsub0.org/PDFSplitter-video">Ver demostración</a>
    ·
    <a href="https://github.com/alephsub0/PDF-Splitter/issues">Reportar un Problema</a>
    ·
    <a href="https://github.com/alephsub0/PDF-Splitter/issues">Solicitar función</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Tabla de Contenidos</summary>
  <ol>
    <li>
      <a href="#sobre-el-proyecto">Sobre el Proyecto</a>
      <ul>
        <li><a href="#construido-con">Construido con</a></li>
        <li><a href="#Disponible para">Disponible para</a></li>
      </ul>
    </li>
    <li><a href="#cómo-instalar-pdf-splitter">¿Cómo instalar PDF Splitter?</a></li>
    <li>
      <a href="#cómo-usar-pdf-splitter">¿Cómo usar PDF Splitter?</a>
      <ul>
        <li><a href="#entradas-input">Entradas (input)</a></li>
        <li><a href="#salida-output">Salida (output)</a></li>
      </ul>
    </li>
    <li><a href="#licencia">Licencia</a></li>
    <li><a href="#créditos">Créditos</a></li>
    <li><a href="#proyectos-de-alephsub0">Proyectos de AlephSub0</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre el Proyecto

PDF Splitter es una herramienta construida con el fin de facilitar el trabajo de la división de un archivo PDF dada la cantidad de hojas. El resultado será un archivo en la misma locación del PDF, cuyo contenido serán todos los archivos PDF divididos.

### Construido con

[![C#][C-Sharp]][C-Sharp-url]

### Disponible para

[![Windows][windows-shield]][windows-url]

<!-- GETTING STARTED -->
## ¿Cómo instalar PDF Splitter?
En la carpeta [installer](https://github.com/alephsub0/PDF-Splitter/tree/main/installer), se encontrará un archivo con la extensión `.msi`. Al ejecutarlo, se abrirá un Wizard de instalación. Seguir los pasos de configuración y el programa estará listo para su ejecución. **Se copiará un acceso directo en el escritorio**.

[![Installer Screenshot][installer-screenshot]](https://github.com/alephsub0/PDF-Splitter/tree/main/installer)

<!-- USAGE EXAMPLES -->
## ¿Cómo usar PDF Splitter?

### Entradas (input)
El programa acepta dos archivos principalmente. El primero, es un archivo PDF que será dividido. La integridad de este archivo se mantiene. También acepta un archivo CSV que deberá estar cerrado para su lectura.

El archivo CSV deberá tener 9 columnas, de las cuales las primeras 8 serán generadas por Moodle y la última se deberá llenar manualmente. Las primeras columnas serviránpara generar el nombre de los PDFs resultantes y la última columna indicará el tamaño del PDF (en hojas).

Si el archivo CSV no contiene una matriz de tamaño de, almenos, 2 columnas, **no será aceptado**.

### Salida (output)
El programa generará un archivo zip, en la misma locación del PDF, cuyo contenido serán todos los archivos PDF divididos. El nombre se guardará con la hora y fecha de la ejecución del comando.

<!-- LICENSE -->
## Licencia

Distribuido bajo la licencia MIT. Consulte archivo [`LICENSE`](https://github.com/alephsub0/PDF-Splitter/blob/main/LICENSE) para obtener más información.


<!-- CONTACT -->
## Créditos
### Desarrollador
Víctor Silverio\
Desarrollador Full-Stack\
Graduado de Ingeniería en Sistemas y Computación en la \
Pontificia Universidad Católica del Ecuador\
vjose_2007@hotmail.com\
vsilverio262@puce.edu.ec\
[![LinkedIn][linkedin-shield]][linkedin-url-vjst]

### Promotor
Mat. Andrés Merino\
[Proyecto Alephsub0](https://www.alephsub0.org/about/),\
Docente de Matemática en la\
Pontificia Universidad Católica del Ecuador\
aemerinot@gmail.com\
info@alephsub0.org\
[![LinkedIn][linkedin-shield]][linkedin-url-aemt]

<!-- PROYECTOS DE ALEPHSUB0 -->
## Proyectos de AlephSub0

* [PDF Splitter](https://github.com/alephsub0/PDF-Splitter)
* [TestAssigner](https://github.com/alephsub0/TestAssigner)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/alephsub0/PDF-Splitter.svg?style=for-the-badge
[contributors-url]: https://github.com/alephsub0/PDF-Splitter/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/alephsub0/PDF-Splitter.svg?style=for-the-badge
[forks-url]: https://github.com/alephsub0/PDF-Splitter/network/members
[stars-shield]: https://img.shields.io/github/stars/alephsub0/PDF-Splitter.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/alephsub0/PDF-Splitter.svg?style=for-the-badge
[issues-url]: https://github.com/alephsub0/PDF-Splitter/issues
[license-shield]: https://img.shields.io/github/license/alephsub0/PDF-Splitter.svg?style=for-the-badge
[license-url]: https://github.com/alephsub0/PDF-Splitter/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white
[linkedin-url-vjst]: https://www.linkedin.com/in/victor-jose-silverio-torres/
[linkedin-url-aemt]: https://www.linkedin.com/in/andrés-merino-010a9b12b/
[installer-screenshot]: resources/markdown/installer-screenshot.png
[C-Sharp]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[C-Sharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/
[windows-shield]: https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white
[windows-url]: https://www.microsoft.com/en-us/windows