import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AmbientesProyectosRow {
    IdAmbienteProyecto?: number;
    IdProyecto?: number;
    IdAmbiente?: number;
    ServidorDatos?: string;
    InstaciaServidor?: string;
    ServidorWeb?: string;
    NotasAdicionales?: string;
    DocumentosRelacionados?: string;
    Observaciones?: string;
    IdProyectoNombreProyecto?: string;
    IdAmbienteDescripcion?: string;
}

export abstract class AmbientesProyectosRow {
    static readonly idProperty = 'IdAmbienteProyecto';
    static readonly nameProperty = 'ServidorDatos';
    static readonly localTextPrefix = 'Parametros.AmbientesProyectos';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AmbientesProyectosRow>();
}