import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EstadosDetalleImplementacionesRow {
    IdEstadoDetalleImplementacion?: number;
    IdDetalleImplementacion?: number;
    IdEstadoTarea?: number;
    IdTecnicoTarea?: number;
    FechaEstado?: string;
    FechaCarga?: string;
    NotasAdicionales?: string;
    DocumentosAdicionales?: string;
    Observaciones?: string;
    UserId?: number;
    IdDetalleImplementacionOrden?: string;
    IdEstadoTareaDescripcion?: string;
    IdTecnicoTareaNombreCompleto?: string;
    Username?: string;
}

export abstract class EstadosDetalleImplementacionesRow {
    static readonly idProperty = 'IdEstadoDetalleImplementacion';
    static readonly nameProperty = 'NotasAdicionales';
    static readonly localTextPrefix = 'Implementacion.EstadosDetalleImplementaciones';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EstadosDetalleImplementacionesRow>();
}