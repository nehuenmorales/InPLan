import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface AmbientesRow {
    IdAmbiente?: number;
    IdEmpresa?: number;
    IdArea?: number;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class AmbientesRow {
    static readonly idProperty = 'IdAmbiente';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.Ambientes';
    static readonly lookupKey = 'Parametros.Ambientes';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AmbientesRow>('Parametros.Ambientes') }
    static async getLookupAsync() { return getLookupAsync<AmbientesRow>('Parametros.Ambientes') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AmbientesRow>();
}