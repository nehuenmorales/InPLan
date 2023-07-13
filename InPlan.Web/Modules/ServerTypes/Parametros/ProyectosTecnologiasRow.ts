import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProyectosTecnologiasRow {
    IdProyectoTecnologia?: number;
    IdProyecto?: number;
    IdTecnologia?: number;
    IdProyectoNombreProyecto?: string;
    IdTecnologiaDescripcion?: string;
}

export abstract class ProyectosTecnologiasRow {
    static readonly idProperty = 'IdProyectoTecnologia';
    static readonly localTextPrefix = 'Parametros.ProyectosTecnologias';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProyectosTecnologiasRow>();
}