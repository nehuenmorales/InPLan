import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

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
    static readonly lookupKey = 'Implementacion.TiposImplementacion';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TiposImplementacionRow>('Implementacion.TiposImplementacion') }
    static async getLookupAsync() { return getLookupAsync<TiposImplementacionRow>('Implementacion.TiposImplementacion') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TiposImplementacionRow>();
}