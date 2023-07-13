import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TecnicosRow {
    IdTecnico?: number;
    IdEmpresa?: number;
    IdArea?: number;
    NombreCompleto?: string;
    Celular?: string;
    Email?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class TecnicosRow {
    static readonly idProperty = 'IdTecnico';
    static readonly nameProperty = 'NombreCompleto';
    static readonly localTextPrefix = 'Parametros.Tecnicos';
    static readonly lookupKey = 'Parametros.Tecnicos';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TecnicosRow>('Parametros.Tecnicos') }
    static async getLookupAsync() { return getLookupAsync<TecnicosRow>('Parametros.Tecnicos') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TecnicosRow>();
}