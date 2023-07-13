import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface DetalleImplementacionesRollBackRow {
    IdDetalleImplementacionRollBack?: number;
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

export abstract class DetalleImplementacionesRollBackRow {
    static readonly idProperty = 'IdDetalleImplementacionRollBack';
    static readonly nameProperty = 'Orden';
    static readonly localTextPrefix = 'Implementacion.DetalleImplementacionesRollBack';
    static readonly lookupKey = 'Implementacion.DetalleImplementacionesRollBack';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DetalleImplementacionesRollBackRow>('Implementacion.DetalleImplementacionesRollBack') }
    static async getLookupAsync() { return getLookupAsync<DetalleImplementacionesRollBackRow>('Implementacion.DetalleImplementacionesRollBack') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DetalleImplementacionesRollBackRow>();
}