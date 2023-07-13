﻿import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AreasRow {
    IdArea?: number;
    IdEmpresa?: number;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
}

export abstract class AreasRow {
    static readonly idProperty = 'IdArea';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Tenencia.Areas';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AreasRow>();
}