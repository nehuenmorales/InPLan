import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProyectosRow {
    IdProyecto?: number;
    IdEmpresa?: number;
    IdArea?: number;
    NombreProyecto?: string;
    DescripcionProyecto?: string;
    NroTicket?: string;
    FechaCarga?: string;
    FechaInicio?: string;
    FechaFin?: string;
    DocumentosRelacionados?: string;
    Observaciones?: string;
    Baja?: boolean;
    IdEmpresaDescripcionCorta?: string;
    IdAreaDescripcion?: string;
}

export abstract class ProyectosRow {
    static readonly idProperty = 'IdProyecto';
    static readonly nameProperty = 'NombreProyecto';
    static readonly localTextPrefix = 'Parametros.Proyectos';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProyectosRow>();
}