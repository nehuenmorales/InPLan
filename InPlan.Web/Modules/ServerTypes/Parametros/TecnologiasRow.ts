﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TecnologiasRow {
    IdTecnologia?: number;
    IdEmpresa?: number;
    IdArea?: number;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class TecnologiasRow {
    static readonly idProperty = 'IdTecnologia';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.Tecnologias';
    static readonly lookupKey = 'Parametros.Tecnologias';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TecnologiasRow>('Parametros.Tecnologias') }
    static async getLookupAsync() { return getLookupAsync<TecnologiasRow>('Parametros.Tecnologias') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TecnologiasRow>();
}