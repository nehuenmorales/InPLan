import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TecnicosProyectosRow {
    IdTecnicoProyecto?: number;
    IdProyecto?: number;
    IdTecnicos?: number;
    Observaciones?: string;
    Baja?: boolean;
    IdProyectoNombreProyecto?: string;
    IdTecnicosNombreCompleto?: string;
}

export abstract class TecnicosProyectosRow {
    static readonly idProperty = 'IdTecnicoProyecto';
    static readonly nameProperty = 'Observaciones';
    static readonly localTextPrefix = 'Parametros.TecnicosProyectos';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TecnicosProyectosRow>();
}