import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TecnicoProyectoTecnologiasRow {
    IdTecnicoProyectoTecnologia?: number;
    IdTecnicoProyecto?: number;
    IdTecnologia?: number;
    IdTecnicoProyectoObservaciones?: string;
    IdTecnologiaDescripcion?: string;
}

export abstract class TecnicoProyectoTecnologiasRow {
    static readonly idProperty = 'IdTecnicoProyectoTecnologia';
    static readonly localTextPrefix = 'Parametros.TecnicoProyectoTecnologias';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TecnicoProyectoTecnologiasRow>();
}