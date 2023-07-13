import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EstadosTareasRow {
    IdEstadoTarea?: number;
    IdEmpresa?: number;
    IdArea?: number;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class EstadosTareasRow {
    static readonly idProperty = 'IdEstadoTarea';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.EstadosTareas';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EstadosTareasRow>();
}