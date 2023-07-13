import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposImplementacionRow {
    IdTipoImplementacion?: number;
    IdEmpresa?: number;
    IdArea?: number;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class TiposImplementacionRow {
    static readonly idProperty = 'IdTipoImplementacion';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Implementacion.TiposImplementacion';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TiposImplementacionRow>();
}