# Mixer Manager

Mixer Manager es un sistema CRM moderno que permite a las empresas gestionar y entender mejor sus relaciones con los clientes. Basado en ASP.NET Core 6 y diseñado con una Arquitectura Limpia, este proyecto se centra en la eficiencia, la escalabilidad y la mantenibilidad.

## Características

- Gestión de Compañías.
- Gestión de Clientes.

## Tecnologías Utilizadas

- **ASP.NET Core 6**: Framework de desarrollo web.
- **Arquitectura Limpia**: Enfoque arquitectónico que separa las preocupaciones del software, promoviendo la independencia de frameworks, testabilidad y mantenibilidad.

## Patrones de diseño

- Repostory

## Requisitos

- .NET SDK 6.0
- Base de datos SQL Server

## Instrucciones para la Ejecución

1. **Clonar el Repositorio**:
   ```bash
   git clone https://github.com/Michael-Nunez/mirex-manager
   cd mirex-manager
   dotnet restore
   dotnet ef database update
   dotnet run

# La aplicación ahora debería estar ejecutándose en http://localhost:5244.

## Documentación
La documentación completa del proyecto, incluyendo detalles de arquitectura, diseño de la base de datos y descripciones de las principales características, puede encontrarse en el directorio /docs.

## Licencia
Este proyecto está licenciado bajo MIT. Consulta el archivo LICENSE para más detalles.
