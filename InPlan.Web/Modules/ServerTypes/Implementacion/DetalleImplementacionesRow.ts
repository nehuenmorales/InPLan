import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface DetalleImplementacionesRow {
    IdDetalleImplementacion?: number;
    IdImplementacion?: number;
    IdTecnicoResponsable?: number;
    Orden?: string;
    DescripcionTarea?: string;
    NotasAdicionales?: string;
    DocumentosAdicionales?: string;
    FechaInicio?: string;
    FechaFinalizacion?: string;
    Observaciones?: string;
    IdEstadoTarea?: number;
    IdImplementacionNroTicket?: string;
    IdTecnicoResponsableNombreCompleto?: string;
    IdEstadoTareaDescripcion?: string;
}

export abstract class DetalleImplementacionesRow {
    static readonly idProperty = 'IdDetalleImplementacion';
    static readonly nameProperty = 'Orden';
    static readonly localTextPrefix = 'Implementacion.DetalleImplementaciones';
    static readonly lookupKey = 'Implementacion.DetalleImplementaciones';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DetalleImplementacionesRow>('Implementacion.DetalleImplementaciones') }
    static async getLookupAsync() { return getLookupAsync<DetalleImplementacionesRow>('Implementacion.DetalleImplementaciones') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DetalleImplementacionesRow>();
}