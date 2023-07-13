import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EmpresasRow {
    IdEmpresa?: number;
    DescripcionCorta?: string;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
}

export abstract class EmpresasRow {
    static readonly idProperty = 'IdEmpresa';
    static readonly nameProperty = 'DescripcionCorta';
    static readonly localTextPrefix = 'Tenencia.Empresas';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EmpresasRow>();
}