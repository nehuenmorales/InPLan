import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ClientesRow {
    IdCliente?: number;
    IdEmpresa?: number;
    IdArea?: number;
    DescripcionCorta?: string;
    Descripcion?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class ClientesRow {
    static readonly idProperty = 'IdCliente';
    static readonly nameProperty = 'DescripcionCorta';
    static readonly localTextPrefix = 'Parametros.Clientes';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ClientesRow>();
}